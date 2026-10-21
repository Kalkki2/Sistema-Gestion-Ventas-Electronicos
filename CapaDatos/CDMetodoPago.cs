using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDMetodoPago
    {
        public List<EMetodoPago> Listar()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.metodo_pago.Select(mp => new EMetodoPago()
                {
                    metodo_pago_id = mp.metodo_pago_id,
                    nombre = mp.nombre,
                    porcentaje = mp.porcentaje,
                    tipo_ajuste_id = mp.tipo_ajuste_id
                }).ToList();
            }
        }

        public List<ETipoAjuste> ListarTiposAjuste()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.tipo_ajuste.Select(ta => new ETipoAjuste()
                {
                    tipo_ajuste_id = ta.tipo_ajuste_id,
                    nombre = ta.nombre
                }).ToList();
            }
        }

        public bool Actualizar(int metodoPagoId, decimal porcentaje, int tipoAjusteId, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var metodo = db.metodo_pago.FirstOrDefault(mp => mp.metodo_pago_id == metodoPagoId);
                    if (metodo != null)
                    {
                        metodo.porcentaje = porcentaje;
                        metodo.tipo_ajuste_id = tipoAjusteId;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        mensaje = "No se encontró el método de pago.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}
