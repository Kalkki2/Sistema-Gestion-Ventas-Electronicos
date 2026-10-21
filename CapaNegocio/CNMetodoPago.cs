using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNMetodoPago
    {
        private CDMetodoPago objCD = new CDMetodoPago();

        public List<EMetodoPago> Listar()
        {
            return objCD.Listar();
        }

        public List<ETipoAjuste> ListarTiposAjuste()
        {
            return objCD.ListarTiposAjuste();
        }

        public bool Actualizar(int metodoPagoId, decimal porcentaje, int tipoAjusteId, out string mensaje)
        {
            mensaje = string.Empty;

            if (porcentaje < 0)
            {
                mensaje = "El porcentaje no puede ser negativo.";
                return false;
            }

            return objCD.Actualizar(metodoPagoId, porcentaje, tipoAjusteId, out mensaje);
        }
    }
}

