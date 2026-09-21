using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNUsuario
    {
        private CDUsuario objCDUsuario = new CDUsuario();

        public List<EUsuario> Listar()
        {
            return objCDUsuario.ListarUsuarios();
        }

        public bool CambiarEstado(int idUsuario, bool nuevoEstado)
        {
            return objCDUsuario.CambiarEstado(idUsuario, nuevoEstado);
        }

        public bool Registrar(EUsuario obj, out string Mensaje)
        {
            //Obtener lista actual para validar Unicidad
            List<EUsuario> lista = objCDUsuario.ListarUsuarios();

            if (lista.Any(u => u.dni.Equals(obj.dni.Trim(), System.StringComparison.OrdinalIgnoreCase)))
            {
                Mensaje = "El DNI ingresado ya se encuentra registrado.";
                return false;
            }

            if (lista.Any(u => u.correo.Equals(obj.correo.Trim(), System.StringComparison.OrdinalIgnoreCase)))
            {
                Mensaje = "El correo electrónico ingresado ya se encuentra registrado.";
                return false;
            }

            if (lista.Any(u => u.telefono.Equals(obj.telefono.Trim(), System.StringComparison.OrdinalIgnoreCase)))
            {
                Mensaje = "El número de teléfono ingresado ya se encuentra registrado.";
                return false;
            }

            // 3Si pasa las validaciones, enviamos a CapaDatos
            return objCDUsuario.Registrar(obj, out Mensaje);
        }


        public bool Editar(EUsuario obj, out string Mensaje)
        {
            
            List<EUsuario> lista = objCDUsuario.ListarUsuarios();

            // Validar Unicidad ignorando el ID del usuario en edición
            if (lista.Any(u => u.dni.Equals(obj.dni.Trim(), StringComparison.OrdinalIgnoreCase) && u.usuario_id != obj.usuario_id))
            {
                Mensaje = "El DNI ingresado ya pertenece a otro usuario.";
                return false;
            }

            if (lista.Any(u => u.correo.Equals(obj.correo.Trim(), StringComparison.OrdinalIgnoreCase) && u.usuario_id != obj.usuario_id))
            {
                Mensaje = "El correo ingresado ya pertenece a otro usuario.";
                return false;
            }

            if (lista.Any(u => u.telefono.Equals(obj.telefono.Trim(), StringComparison.OrdinalIgnoreCase) && u.usuario_id != obj.usuario_id))
            {
                Mensaje = "El teléfono ingresado ya pertenece a otro usuario.";
                return false;
            }

            return objCDUsuario.Editar(obj, out Mensaje);
        }

        public List<EUsuario> Buscar(string busqueda)
        {
            return objCDUsuario.BuscarUsuarios(busqueda);
        }

        public List<EUsuario> Filtrar(int? idPerfil, bool? estado)
        {
            return objCDUsuario.FiltrarUsuarios(idPerfil, estado);
        }
    }
}
