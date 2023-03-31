using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Modelo
{
    internal class Trabajador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string FechaNcimiento { get; set; }
        public string FechaContratacion { get; set; }
        public string Estatus { get; set; }
    }
}
