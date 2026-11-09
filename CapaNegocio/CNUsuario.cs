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

        public List<EUsuario> ListarUsuarios()
        {
            return objCDUsuario.ListarUsuarios();
        }

        public bool CambiarEstado(int idUsuario, int nuevoEstado)
        {
            return objCDUsuario.CambiarEstado(idUsuario, nuevoEstado);
        }

        public bool RegistrarUsuario(EUsuario obj, out string Mensaje)
        {
            // Obtener lista actual para validar Unicidad
            List<EUsuario> lista = objCDUsuario.ListarUsuarios();

            if (lista.Any(u => u.dni.Equals(obj.dni.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                Mensaje = "El DNI ingresado ya se encuentra registrado.";
                return false;
            }

            if (lista.Any(u => u.email.Equals(obj.email.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                Mensaje = "El correo electrónico ingresado ya se encuentra registrado.";
                return false;
            }

            if (lista.Any(u => u.telefono.Equals(obj.telefono.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                Mensaje = "El número de teléfono ingresado ya se encuentra registrado.";
                return false;
            }

            // Si pasa las validaciones, enviamos a CapaDatos
            return objCDUsuario.Registrar(obj, out Mensaje);
        }

        public bool EditarUsuario(EUsuario obj, out string Mensaje)
        {
            List<EUsuario> lista = objCDUsuario.ListarUsuarios();

            // Validar Unicidad ignorando el ID del usuario en edición
            if (lista.Any(u => u.dni.Equals(obj.dni.Trim(), StringComparison.OrdinalIgnoreCase) && u.usuario_id != obj.usuario_id))
            {
                Mensaje = "El DNI ingresado ya pertenece a otro usuario.";
                return false;
            }

            if (lista.Any(u => u.email.Equals(obj.email.Trim(), StringComparison.OrdinalIgnoreCase) && u.usuario_id != obj.usuario_id))
            {
                Mensaje = "El correo ingresado ya pertenece a otro usuario.";
                return false;
            }

            if (lista.Any(u => u.telefono.Equals(obj.telefono.Trim(), StringComparison.OrdinalIgnoreCase) && u.usuario_id != obj.usuario_id))
            {
                Mensaje = "El teléfono ingresado ya pertenece a otro usuario.";
                return false;
            }

            return objCDUsuario.EditarUsuario(obj, out Mensaje);
        }

        public List<EUsuario> BuscarYFiltrarUsuario(string busqueda, int? idPerfil, int? estado)
        {
            return objCDUsuario.BuscarYFiltrar(busqueda, idPerfil, estado);
        }

        public EUsuario Login(string dni, string contrasenia, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrEmpty(dni.Trim()) || string.IsNullOrEmpty(contrasenia.Trim()))
            {
                mensaje = "Debe completar el DNI y la contraseña.";
                return null;
            }

            CDUsuario cdUsuario = new CDUsuario();
            return cdUsuario.Login(dni.Trim(), contrasenia.Trim());
        }
    }
}
