using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNCliente
    {
        private readonly CDCliente objCDCliente = new CDCliente();

        public List<ECliente> Listar(string filtro = "")
        {
            return objCDCliente.Listar(filtro);
        }

        public bool Registrar(ECliente obj, out string Mensaje)
        {
            if (!Validar(obj, out Mensaje))
                return false;

            return objCDCliente.Registrar(obj, out Mensaje);
        }

        public bool Editar(ECliente obj, out string Mensaje)
        {
            if (obj.cliente_id <= 0)
            {
                Mensaje = "No se indicó qué cliente se quiere modificar.";
                return false;
            }

            if (!Validar(obj, out Mensaje))
                return false;

            return objCDCliente.Editar(obj, out Mensaje);
        }

        // Reglas de negocio: se validan antes de tocar la base de datos
        private bool Validar(ECliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj == null)
            {
                Mensaje = "No se recibieron datos del cliente.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.nombre))
                Mensaje = "El nombre es obligatorio.";
            else if (string.IsNullOrWhiteSpace(obj.apellido))
                Mensaje = "El apellido es obligatorio.";
            else if (string.IsNullOrWhiteSpace(obj.dni) || !obj.dni.All(char.IsDigit) || obj.dni.Length != 8)
                Mensaje = "El DNI debe tener exactamente 8 dígitos.";
            else if (string.IsNullOrWhiteSpace(obj.telefono))
                Mensaje = "El teléfono es obligatorio.";
            else if (string.IsNullOrWhiteSpace(obj.direccion))
                Mensaje = "La dirección es obligatoria.";
            else if (string.IsNullOrWhiteSpace(obj.email) || !Regex.IsMatch(obj.email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                Mensaje = "Ingrese un correo electrónico válido.";

            return Mensaje == string.Empty;
        }
    }
}