using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNUsuario
    {
        private CDUsuario objCDUsuario = new CDUsuario();
        
        //Metodo para Listar Todos los usuario
        public List<EUsuario> ListarUsuarios()
        {
            return objCDUsuario.ListarUsuarios();
        }

        // Metodo para hashear contraseñas con SHA256
        private string HashearContrasenia(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool RegistrarUsuario(EUsuario obj, out string Mensaje)
        {
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

            // HASHEAR LA CONTRASEÑA antes de enviarla a la Capa de Datos
            obj.contrasenia = HashearContrasenia(obj.contrasenia.Trim());

            return objCDUsuario.Registrar(obj, out Mensaje);
        }

        public bool EditarUsuario(EUsuario obj, out string Mensaje)
        {
            List<EUsuario> lista = objCDUsuario.ListarUsuarios();

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

            //  si el campo viene con texto, se hashea. 
            // Si viene vacío, se conserva la contraseña actual buscando al usuario en la BD.
            if (!string.IsNullOrWhiteSpace(obj.contrasenia))
            {
                obj.contrasenia = HashearContrasenia(obj.contrasenia.Trim());
            }
            else
            {
                // si no se escribe nada al editar, recuperamos la contraseña vieja de la BD para no borrarla
                var usuarioActual = lista.FirstOrDefault(u => u.usuario_id == obj.usuario_id);
                if (usuarioActual != null)
                {
                    obj.contrasenia = usuarioActual.contrasenia;
                }
            }

            return objCDUsuario.EditarUsuario(obj, out Mensaje);
        }


        //Metodo para dar de baja logica al usuario
        public bool CambiarEstado(int idUsuario, int nuevoEstado)
        {
            return objCDUsuario.CambiarEstado(idUsuario, nuevoEstado);
        }


        //Metodo para filtrar usuario por apellido, Dni, correo, perfil o estado
        public List<EUsuario> BuscarYFiltrarUsuario(string busqueda, int? idPerfil, int? estado)
        {
            return objCDUsuario.BuscarYFiltrar(busqueda, idPerfil, estado);
        }

        // Medor para inicio de sesion
        public EUsuario Login(string dni, string contraseniaIngresada, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(contraseniaIngresada))
            {
                mensaje = "Debe completar el DNI y la contraseña.";
                return null;
            }

            // Obtenemos la lista o buscamos al usuario por DNI
            List<EUsuario> lista = objCDUsuario.ListarUsuarios();
            EUsuario oUsuario = lista.FirstOrDefault(u => u.dni.Equals(dni.Trim(), StringComparison.OrdinalIgnoreCase));

            if (oUsuario == null)
            {
                mensaje = "El DNI ingresado no se encuentra registrado.";
                return null;
            }

            if (oUsuario.estado != 1)
            {
                mensaje = "El usuario se encuentra inactivo. Comuníquese con el administrador.";
                return null;
            }

            // Hasheamos la contraseña que ingresó el usuario en pantalla
            string passwordHasheada = HashearContrasenia(contraseniaIngresada.Trim());

            // Comparamos el hash generado con el hash almacenado en la base de datos
            if (oUsuario.contrasenia != passwordHasheada)
            {
                mensaje = "La contraseña es incorrecta.";
                return null;
            }

            return oUsuario; // Retorna el usuario completo si todo es correcto
        }
    }
}
