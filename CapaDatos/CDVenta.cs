using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDVenta
    {
        public bool Registrar(EVenta objVenta, List<EDetalleVenta> listaDetalles, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Abrimos una transacción explícita de Entity Framework
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            // 1. Registrar la Cabecera de la Venta con un número temporal
                            venta nuevaVenta = new venta
                            {
                                nro_venta = "TEMP", // Valor temporal requerido para guardar
                                fecha_venta = DateTime.Now,
                                porcentaje_aplicado = objVenta.porcentaje_aplicado,
                                estado = objVenta.estado,
                                usuario_id = objVenta.usuario_id,
                                metodo_pago_id = objVenta.metodo_pago_id,
                                cliente_id = objVenta.cliente_id
                            };

                            db.venta.Add(nuevaVenta);
                            db.SaveChanges(); // Genera el ID autoincremental (venta_id) en la BD

                            // 2. Formateamos el nro_venta a 8 dígitos basados en el ID real generado (ej: ID 321 -> "00000321")
                            nuevaVenta.nro_venta = nuevaVenta.venta_id.ToString("D8");

                            // 3. Registrar los Detalles y Descontar el Stock de cada Producto
                            foreach (var item in listaDetalles)
                            {
                                // Verificar si el producto existe
                                var productoTemp = db.producto.FirstOrDefault(p => p.producto_id == item.producto_id);
                                if (productoTemp == null)
                                {
                                    Mensaje = $"El producto con ID {item.producto_id} no existe.";
                                    transaction.Rollback();
                                    return false;
                                }

                                // Validar si hay stock suficiente
                                if (productoTemp.stock < item.cantidad)
                                {
                                    Mensaje = $"Stock insuficiente para el producto: {productoTemp.nombre}. Stock actual: {productoTemp.stock}";
                                    transaction.Rollback();
                                    return false;
                                }

                                // Insertar el detalle de la venta
                                detalle_venta nuevoDetalle = new detalle_venta
                                {
                                    venta_id = nuevaVenta.venta_id,
                                    producto_id = item.producto_id,
                                    cantidad = item.cantidad,
                                    precio_unitario = item.precio_unitario
                                };
                                db.detalle_venta.Add(nuevoDetalle);

                                // Descontar la cantidad vendida del stock actual del producto
                                productoTemp.stock -= item.cantidad;
                                productoTemp.fecha_ultima_modificacion = DateTime.Now;
                            }

                            db.SaveChanges(); // Guarda el nro_venta actualizado, los detalles y el stock

                            // Confirmamos los cambios en la base de datos
                            transaction.Commit();

                            // Asignamos el número generado de vuelta al objeto de entidad para usarlo en la UI (modal/ticket)
                            objVenta.nro_venta = nuevaVenta.nro_venta;

                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }

        public List<EVenta> ListarHistorialVentas()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from v in db.venta
                            join u in db.usuario on v.usuario_id equals u.usuario_id
                            join c in db.cliente on v.cliente_id equals c.cliente_id
                            join mp in db.metodo_pago on v.metodo_pago_id equals mp.metodo_pago_id
                            orderby v.fecha_venta descending // Las ventas más recientes primero
                            select new EVenta()
                            {
                                venta_id = v.venta_id,
                                nro_venta = v.nro_venta,
                                fecha_venta = v.fecha_venta,
                                porcentaje_aplicado = v.porcentaje_aplicado,
                                estado = v.estado,
                                usuario_id = v.usuario_id,
                                metodo_pago_id = v.metodo_pago_id,
                                cliente_id = v.cliente_id,

                                // Mapeo de objetos relacionados
                                oUsuario = new EUsuario()
                                {
                                    usuario_id = u.usuario_id,
                                    nombre = u.nombre,
                                    apellido = u.apellido,
                                    dni = u.dni
                                },
                                oCliente = new ECliente()
                                {
                                    cliente_id = c.cliente_id,
                                    nombre = c.nombre,
                                    apellido = c.apellido,
                                    dni = c.dni,
                                    email = c.email
                                },
                                oMetodoPago = new EMetodoPago()
                                {
                                    metodo_pago_id = mp.metodo_pago_id,
                                    nombre = mp.nombre,
                                    porcentaje = mp.porcentaje,
                                    tipo_ajuste_id = mp.tipo_ajuste_id,
                                    // Mapeamos el tipo de ajuste a través del método de pago
                                    oTipoAjuste = new ETipoAjuste()
                                    {
                                        tipo_ajuste_id = mp.tipo_ajuste.tipo_ajuste_id,
                                        nombre = mp.tipo_ajuste.nombre
                                    }
                                },

                                // Mapeo de los detalles para poder calcular el subtotal/total en la grilla
                                oDetalleVenta = db.detalle_venta
                                    .Where(d => d.venta_id == v.venta_id)
                                    .Select(d => new EDetalleVenta()
                                    {
                                        producto_id = d.producto_id,
                                        cantidad = d.cantidad,
                                        precio_unitario = d.precio_unitario
                                    }).ToList()
                            };

                return query.ToList();
            }
        }

        public List<EDetalleVenta> ObtenerDetalleVenta(int ventaId)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from d in db.detalle_venta
                            join p in db.producto on d.producto_id equals p.producto_id
                            where d.venta_id == ventaId
                            select new EDetalleVenta()
                            {
                                producto_id = d.producto_id,
                                venta_id = d.venta_id,
                                cantidad = d.cantidad,
                                precio_unitario = d.precio_unitario,
                                // Mapeamos el objeto producto para mostrar código y nombre en la grilla del detalle
                                oProducto = new EProducto()
                                {
                                    producto_id = p.producto_id,
                                    codigo = p.codigo,
                                    nombre = p.nombre
                                }
                            };

                return query.ToList();
            }
        }

        public List<EVenta> ListarHistorialVentasPorUsuario(int usuarioId)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from v in db.venta
                            join u in db.usuario on v.usuario_id equals u.usuario_id
                            join c in db.cliente on v.cliente_id equals c.cliente_id
                            join mp in db.metodo_pago on v.metodo_pago_id equals mp.metodo_pago_id
                            where v.usuario_id == usuarioId // <--- FILTEAMOS SOLO LAS VENTAS DE ESTE USUARIO
                            orderby v.fecha_venta descending
                            select new EVenta()
                            {
                                venta_id = v.venta_id,
                                nro_venta = v.nro_venta,
                                fecha_venta = v.fecha_venta,
                                porcentaje_aplicado = v.porcentaje_aplicado,
                                estado = v.estado,
                                usuario_id = v.usuario_id,
                                metodo_pago_id = v.metodo_pago_id,
                                cliente_id = v.cliente_id,

                                oUsuario = new EUsuario()
                                {
                                    usuario_id = u.usuario_id,
                                    nombre = u.nombre,
                                    apellido = u.apellido,
                                    dni = u.dni
                                },
                                oCliente = new ECliente()
                                {
                                    cliente_id = c.cliente_id,
                                    nombre = c.nombre,
                                    apellido = c.apellido,
                                    dni = c.dni,
                                    email = c.email
                                },
                                oMetodoPago = new EMetodoPago()
                                {
                                    metodo_pago_id = mp.metodo_pago_id,
                                    nombre = mp.nombre,
                                    porcentaje = mp.porcentaje,
                                    tipo_ajuste_id = mp.tipo_ajuste_id,
                                    // Mapeamos el tipo de ajuste a través del método de pago
                                    oTipoAjuste = new ETipoAjuste()
                                    {
                                        tipo_ajuste_id = mp.tipo_ajuste.tipo_ajuste_id,
                                        nombre = mp.tipo_ajuste.nombre
                                    }
                                },

                                oDetalleVenta = db.detalle_venta
                                    .Where(d => d.venta_id == v.venta_id)
                                    .Select(d => new EDetalleVenta()
                                    {
                                        producto_id = d.producto_id,
                                        cantidad = d.cantidad,
                                        precio_unitario = d.precio_unitario
                                    }).ToList()
                            };

                return query.ToList();
            }
        }

        public List<EMarcaVenta> ObtenerVentasPorMarca(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from v in db.venta
                            join dv in db.detalle_venta on v.venta_id equals dv.venta_id
                            join p in db.producto on dv.producto_id equals p.producto_id
                            join m in db.marca on p.marca_id equals m.marca_id 
                            where v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1
                            group dv by m.nombre into grupo
                            orderby grupo.Sum(x => x.cantidad) descending
                            select new EMarcaVenta()
                            {
                                Marca = grupo.Key,
                                TotalVentas = grupo.Sum(x => x.cantidad) // Suma total de unidades vendidas por marca
                            };

                return query.ToList();
            }
        }

        public List<ETendenciaVenta> ObtenerTendenciaVentasDiariasPorMesAnio(int mes, int anio)
        {
            // Calculamos el primer y último día del mes seleccionado
            DateTime fechaDesde = new DateTime(anio, mes, 1);
            DateTime fechaHasta = new DateTime(anio, mes, DateTime.DaysInMonth(anio, mes)).AddDays(1).AddTicks(-1);

            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var ventasCrudas = db.venta
                    .Where(v => v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1)
                    .Select(v => new {
                        FechaVenta = v.fecha_venta,
                        PorcentajeAplicado = v.porcentaje_aplicado,
                        TipoAjusteNombre = v.metodo_pago.tipo_ajuste.nombre,
                        SubtotalBruto = v.detalle_venta.Sum(d => (decimal?)(d.cantidad * d.precio_unitario)) ?? 0
                    }).ToList();

                var ventasCalculadas = ventasCrudas.Select(v => {
                    decimal montoAjuste = (v.SubtotalBruto * v.PorcentajeAplicado) / 100;
                    decimal totalReal = v.SubtotalBruto;

                    if (v.TipoAjusteNombre == "Descuento") totalReal = v.SubtotalBruto - montoAjuste;
                    else if (v.TipoAjusteNombre == "Recargo") totalReal = v.SubtotalBruto + montoAjuste;

                    return new { FechaDia = v.FechaVenta.Date, TotalReal = totalReal };
                });

                return ventasCalculadas
                    .GroupBy(x => x.FechaDia)
                    .OrderBy(g => g.Key)
                    .Select(g => new ETendenciaVenta()
                    {
                        Fecha = g.Key.ToString("dd/MM/yy"),
                        TotalVentas = g.Sum(x => x.TotalReal)
                    })
                    .ToList();
            }
        }

        public List<EReporteTopProducto> ObtenerTop10ProductosMasVendidos(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                // Traemos los detalles de ventas activas con los datos del producto y el ajuste de la venta
                var detallesCrudos = (from dv in db.detalle_venta
                                      join p in db.producto on dv.producto_id equals p.producto_id
                                      where dv.venta.estado == 1 // Solo ventas activas (no anuladas)
                                            && dv.venta.fecha_venta >= fechaDesde
                                            && dv.venta.fecha_venta <= fechaHasta
                                      select new
                                      {
                                          p.codigo,
                                          p.nombre,
                                          Cantidad = dv.cantidad,
                                          SubtotalBruto = dv.cantidad * dv.precio_unitario,
                                          PorcentajeAplicado = dv.venta.porcentaje_aplicado,
                                          TipoAjusteNombre = dv.venta.metodo_pago.tipo_ajuste.nombre
                                      }).ToList();

                // Calculamos el total real de cada línea aplicando el descuento o recargo corporativo
                var detallesCalculados = detallesCrudos.Select(d => {
                    decimal montoAjuste = (d.SubtotalBruto * d.PorcentajeAplicado) / 100;
                    decimal totalRealLinea = d.SubtotalBruto;

                    if (d.TipoAjusteNombre == "Descuento")
                    {
                        totalRealLinea = d.SubtotalBruto - montoAjuste;
                    }
                    else if (d.TipoAjusteNombre == "Recargo")
                    {
                        totalRealLinea = d.SubtotalBruto + montoAjuste;
                    }

                    return new
                    {
                        d.codigo,
                        d.nombre,
                        d.Cantidad,
                        TotalRealLinea = totalRealLinea
                    };
                }).ToList();

                //  Agrupamos por producto para sumar la cantidad de unidades y el recaudado ajustado
                var topProductos = detallesCalculados
                    .GroupBy(x => new { x.codigo, x.nombre })
                    .Select(g => new EReporteTopProducto()
                    {
                        codigo = g.Key.codigo,
                        nombre = g.Key.nombre,
                        cantidad_vendida = g.Sum(x => x.Cantidad),
                        total_recaudado = g.Sum(x => x.TotalRealLinea) // incluye descuentos/recargos
                    })
                    .OrderByDescending(x => x.cantidad_vendida) // Ordenado por mayor cantidad de unidades vendidas
                    .Take(10)
                    .ToList();

                return topProductos;
            }
        }

        // Total Ventas en dinero por rango de fechas (Considerando descuentos, recargos y ajustes)
        public decimal CalcularTotalVentasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                // Traemos las ventas del rango con su porcentaje y tipo de ajuste
                var ventasCrudas = db.venta
                    .Where(v => v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1)
                    .Select(v => new {
                        PorcentajeAplicado = v.porcentaje_aplicado,
                        TipoAjusteNombre = v.metodo_pago.tipo_ajuste.nombre, // "Descuento", "Recargo" 
                        SubtotalBruto = v.detalle_venta.Sum(d => (decimal?)(d.cantidad * d.precio_unitario)) ?? 0
                    }).ToList();

                // Calculamos el total real aplicando la regla de negocio para cada venta
                decimal totalGeneral = 0;

                foreach (var v in ventasCrudas)
                {
                    decimal montoAjuste = (v.SubtotalBruto * v.PorcentajeAplicado) / 100;
                    decimal totalReal = v.SubtotalBruto;

                    if (v.TipoAjusteNombre == "Descuento")
                    {
                        totalReal = v.SubtotalBruto - montoAjuste;
                    }
                    else if (v.TipoAjusteNombre == "Recargo")
                    {
                        totalReal = v.SubtotalBruto + montoAjuste;
                    }

                    totalGeneral += totalReal;
                }

                return totalGeneral;
            }
        }

        //  Total Artículos Vendidos por rango de fechas
        public int CalcularTotalArticulosVendidosPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var resultado = (from v in db.venta
                                 join dv in db.detalle_venta on v.venta_id equals dv.venta_id
                                 where v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1 // activo
                                 select (int?)dv.cantidad).Sum() ?? 0;

                return resultado;
            }
        }

        // Total Clientes Únicos por rango de fechas
        public int CalcularTotalClientesUnicosPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var resultado = db.venta
                    .Where(v => v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1) // activo
                    .Select(v => v.cliente_id)
                    .Distinct()
                    .Count();

                return resultado;
            }
        }

        public List<EVenta> Buscar(int? usuarioId, string dniVendedor, string dniCliente, int? metodoPagoId, int? estadoId, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = db.venta.AsQueryable();

                // 1. Filtro por ID exacto de usuario (Ideal para el Vendedor)
                if (usuarioId.HasValue && usuarioId.Value > 0)
                {
                    query = query.Where(v => v.usuario_id == usuarioId.Value);
                }

                // 2. Filtro por DNI del Vendedor en texto (Ideal para el Administrador)
                if (!string.IsNullOrWhiteSpace(dniVendedor))
                {
                    dniVendedor = dniVendedor.ToLower();
                    query = query.Where(v => v.usuario.dni.ToLower().Contains(dniVendedor));
                }

                // 3. Filtro por DNI del Cliente
                if (!string.IsNullOrWhiteSpace(dniCliente))
                {
                    dniCliente = dniCliente.ToLower();
                    query = query.Where(v => v.cliente.dni.ToLower().Contains(dniCliente));
                }

                // 4. Filtro por Método de Pago
                if (metodoPagoId.HasValue && metodoPagoId.Value > 0)
                {
                    query = query.Where(v => v.metodo_pago_id == metodoPagoId.Value);
                }

                // 5. Filtro por Estado (-1 es Todos, 1 es Activa, 0 es Anulada)
                if (estadoId.HasValue && estadoId.Value != -1)
                {
                    query = query.Where(v => v.estado == estadoId.Value);
                }

                // 6. Filtro por Rango de Fechas
                if (fechaDesde.HasValue && fechaHasta.HasValue)
                {
                    DateTime desde = fechaDesde.Value.Date;
                    DateTime hasta = fechaHasta.Value.Date.AddDays(1).AddTicks(-1);
                    query = query.Where(v => v.fecha_venta >= desde && v.fecha_venta <= hasta);
                }

                // Proyección directa hacia EVenta
                return query.OrderByDescending(v => v.fecha_venta).Select(v => new EVenta()
                {
                    venta_id = v.venta_id,
                    nro_venta = v.nro_venta,
                    fecha_venta = v.fecha_venta,
                    porcentaje_aplicado = v.porcentaje_aplicado,
                    estado = v.estado,
                    usuario_id = v.usuario_id,
                    metodo_pago_id = v.metodo_pago_id,
                    cliente_id = v.cliente_id,
                    

                    oUsuario = new EUsuario()
                    {
                        usuario_id = v.usuario.usuario_id,
                        nombre = v.usuario.nombre,
                        apellido = v.usuario.apellido,
                        dni = v.usuario.dni
                    },
                    oCliente = new ECliente()
                    {
                        cliente_id = v.cliente.cliente_id,
                        nombre = v.cliente.nombre,
                        apellido = v.cliente.apellido,
                        dni = v.cliente.dni,
                        email = v.cliente.email
                    },
                    oMetodoPago = new EMetodoPago()
                    {
                        metodo_pago_id = v.metodo_pago.metodo_pago_id,
                        nombre = v.metodo_pago.nombre,
                        porcentaje = v.metodo_pago.porcentaje,
                        tipo_ajuste_id = v.metodo_pago.tipo_ajuste_id,
                        oTipoAjuste = new ETipoAjuste()
                        {
                            tipo_ajuste_id = v.metodo_pago.tipo_ajuste.tipo_ajuste_id,
                            nombre = v.metodo_pago.tipo_ajuste.nombre
                        }
                    },
                    oDetalleVenta = v.detalle_venta.Select(d => new EDetalleVenta()
                    {
                        producto_id = d.producto_id,
                        cantidad = d.cantidad,
                        precio_unitario = d.precio_unitario
                    }).ToList()
                }).ToList();
            }
        }



        public List<ECategoriaVenta> ObtenerVentasMonetariasPorCategoria(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                // Traemos los detalles de ventas activas con la categoría y los datos de ajuste de la venta
                var detallesCrudos = (from v in db.venta
                                      join dv in db.detalle_venta on v.venta_id equals dv.venta_id
                                      join p in db.producto on dv.producto_id equals p.producto_id
                                      join cat in db.categoria on p.categoria_id equals cat.categoria_id
                                      where v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1
                                      select new
                                      {
                                          CategoriaNombre = cat.nombre,
                                          SubtotalBruto = dv.cantidad * dv.precio_unitario,
                                          PorcentajeAplicado = v.porcentaje_aplicado,
                                          TipoAjusteNombre = v.metodo_pago.tipo_ajuste.nombre
                                      }).ToList();

                // Calculamos el valor real de cada línea aplicando el descuento o recargo
                var detallesCalculados = detallesCrudos.Select(d => {
                    decimal montoAjuste = (d.SubtotalBruto * d.PorcentajeAplicado) / 100;
                    decimal totalRealLinea = d.SubtotalBruto;

                    if (d.TipoAjusteNombre == "Descuento")
                    {
                        totalRealLinea = d.SubtotalBruto - montoAjuste;
                    }
                    else if (d.TipoAjusteNombre == "Recargo")
                    {
                        totalRealLinea = d.SubtotalBruto + montoAjuste;
                    }

                    return new
                    {
                        d.CategoriaNombre,
                        TotalRealLinea = totalRealLinea
                    };
                }).ToList();

                // Agrupamos por categoría sumando los totales ya ajustados
                var resultado = detallesCalculados
                    .GroupBy(x => x.CategoriaNombre)
                    .Select(grupo => new ECategoriaVenta()
                    {
                        Categoria = grupo.Key,
                        TotalVentas = grupo.Sum(x => x.TotalRealLinea) 
                    })
                    .ToList();

                return resultado;
            }
        }

        public List<ETopVendedor> ObtenerTop5PersonalVentas(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                // Traemos solo ventas ACTIVAS (estado == 1) en el rango de fechas
                var ventasCrudas = db.venta
                    .Where(v => v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1)
                    .Select(v => new {
                        UsuarioId = v.usuario_id,
                        NombreVendedor = (v.usuario.nombre + " " + v.usuario.apellido).Trim(),
                        PorcentajeAplicado = v.porcentaje_aplicado,
                        TipoAjusteNombre = v.metodo_pago.tipo_ajuste.nombre, // "Descuento", "Recargo" o "Sin ajuste"
                        CantArticulosVenta = v.detalle_venta.Sum(d => (int?)d.cantidad) ?? 0,
                        SubtotalBruto = v.detalle_venta.Sum(d => (decimal?)(d.cantidad * d.precio_unitario)) ?? 0
                    }).ToList();

                // Calculamos el total real de cada venta aplicando el descuento o recargo
                var ventasCalculadas = ventasCrudas.Select(v => {
                    decimal montoAjuste = (v.SubtotalBruto * v.PorcentajeAplicado) / 100;
                    decimal totalReal = v.SubtotalBruto;

                    if (v.TipoAjusteNombre == "Descuento")
                    {
                        totalReal = v.SubtotalBruto - montoAjuste;
                    }
                    else if (v.TipoAjusteNombre == "Recargo")
                    {
                        totalReal = v.SubtotalBruto + montoAjuste;
                    }

                    return new
                    {
                        v.UsuarioId,
                        v.NombreVendedor,
                        TotalReal = totalReal,
                        v.CantArticulosVenta
                    };
                }).ToList();

                // Agrupamos ÚNICAMENTE por UsuarioId para evitar que aparezca el mismo usuario repetido
                var topVendedores = ventasCalculadas
                    .GroupBy(x => x.UsuarioId)
                    .Select(g => new {
                        Vendedor = g.First().NombreVendedor,
                        TotalVentas = g.Sum(x => x.TotalReal),
                        CantArticulos = g.Sum(x => x.CantArticulosVenta)
                    })
                    .OrderByDescending(x => x.TotalVentas)
                    .Take(5)
                    .ToList();

                // Calculamos el total general del negocio en ese periodo para sacar el porcentaje real
                decimal totalGeneralNegocio = ventasCalculadas.Sum(x => x.TotalReal);
                if (totalGeneralNegocio == 0) totalGeneralNegocio = 1; // Evitar división por cero

                // 5. Mapeamos a la entidad final
                List<ETopVendedor> resultado = new List<ETopVendedor>();
                foreach (var item in topVendedores)
                {
                    decimal porcentaje = (item.TotalVentas / totalGeneralNegocio) * 100;

                    resultado.Add(new ETopVendedor()
                    {
                        NombreVendedor = item.Vendedor,
                        TotalVentas = item.TotalVentas,
                        CantidadArticulos = item.CantArticulos,
                        Porcentaje = Math.Round(porcentaje, 1)
                    });
                }

                return resultado;
            }
        }

        public List<EMetodoPagoVenta> ObtenerVentasPorMetodoPago(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from v in db.venta
                            join mp in db.metodo_pago on v.metodo_pago_id equals mp.metodo_pago_id
                            where v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1
                            group v by mp.nombre into grupo
                            select new EMetodoPagoVenta()
                            {
                                MetodoPago = grupo.Key,
                                // Sumamos el total de las ventas asociadas a este método de pago
                                TotalRecaudado = grupo.Sum(x => x.detalle_venta.Sum(d => (decimal?)(d.cantidad * d.precio_unitario)) ?? 0)
                            };

                return query.OrderByDescending(x => x.TotalRecaudado).ToList();
            }
        }

        public bool CambiarEstado(int ventaId, int nuevoEstado, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var ventaAModificar = db.venta.FirstOrDefault(v => v.venta_id == ventaId);
                    if (ventaAModificar != null)
                    {
                        ventaAModificar.estado = (int)nuevoEstado;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Mensaje = "No se encontró la venta.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                return false;
            }
        }

        public List<EReporteVentaDetallado> ObtenerReportedetalladoVentas(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                // 1. Traemos los datos básicos desde la BD para ventas activas
                var query = from v in db.venta
                            join dv in db.detalle_venta on v.venta_id equals dv.venta_id
                            join p in db.producto on dv.producto_id equals p.producto_id
                            where v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta && v.estado == 1
                            orderby v.fecha_venta descending
                            select new
                            {
                                NroVenta = v.nro_venta,
                                FechaVenta = v.fecha_venta,
                                VendedorNombre = v.usuario.nombre + " " + v.usuario.apellido,
                                ClienteNombre = v.cliente.nombre + " " + v.cliente.apellido,
                                ProductoNombre = p.nombre,
                                Cantidad = dv.cantidad,
                                PrecioUnitario = dv.precio_unitario,
                                SubtotalBruto = dv.cantidad * dv.precio_unitario,
                                PorcentajeAplicado = v.porcentaje_aplicado,
                                TipoAjusteNombre = v.metodo_pago.tipo_ajuste.nombre
                            };

                var listaBruta = query.ToList();

                // 2. Calculamos en memoria el subtotal final aplicando el recargo o descuento proporcional
                var listaFinal = listaBruta.Select(x => {
                    decimal montoAjuste = (x.SubtotalBruto * x.PorcentajeAplicado) / 100;
                    decimal subtotalReal = x.SubtotalBruto;

                    if (x.TipoAjusteNombre == "Descuento")
                    {
                        subtotalReal = x.SubtotalBruto - montoAjuste;
                    }
                    else if (x.TipoAjusteNombre == "Recargo")
                    {
                        subtotalReal = x.SubtotalBruto + montoAjuste;
                    }

                    return new EReporteVentaDetallado
                    {
                        NroVenta = x.NroVenta,
                        FechaVenta = x.FechaVenta,
                        Vendedor = x.VendedorNombre,
                        Cliente = x.ClienteNombre,
                        Producto = x.ProductoNombre,
                        Cantidad = x.Cantidad,
                        PrecioUnitario = x.PrecioUnitario,
                        Subtotal = subtotalReal // <-- ajustado con el recargo/descuento!
                    };
                }).ToList();

                return listaFinal;
            }
        }
    }
}

