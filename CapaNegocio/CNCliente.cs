using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class CNCliente
    {
        public static bool Registrar(cliente objCliente, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                // Aquí llamas al método correspondiente de tu CapaDatos para insertar el cliente
                return CNCliente.Registrar(objCliente, out mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}
