using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDPerfil
    {
        public List<EPerfil> Listar()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.perfil.Select(p => new EPerfil
                {
                    perfil_id = p.perfil_id,
                    nombre = p.nombre
                }).ToList();
            }
        }
    }
}
