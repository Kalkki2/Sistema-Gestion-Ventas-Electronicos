using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNPerfil
    {
        private CDPerfil objDato = new CDPerfil();

        public List<EPerfil> Listar()
        {
            return objDato.Listar();
        }
    }
}
