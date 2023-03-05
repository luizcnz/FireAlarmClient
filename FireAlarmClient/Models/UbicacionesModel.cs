using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmClient.Models
{
    internal class UbicacionesModel
    {
        public int id { get; set; }
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }

    internal class CrearUbicacion
    {
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }
    internal class ActualizarUbicacion
    {
        public int id { get; set; }
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }
}
