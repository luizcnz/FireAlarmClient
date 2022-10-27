using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmClient.Models
{
    internal class DispositivosModel
    {
        public int Id { get; set; }
        public string codigo { get; set; }
        public int ubicacion_id { get; set; }
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }

    internal class CrearDispositivos
    {
        public string codigo { get; set; }
        public int ubicacion_id { get; set; }
        public bool estado { get; set; }
    }

    internal class ActualizarDispositivos
    {
        public int Id { get; set; }
        public string codigo { get; set; }
        public int ubicacion_id { get; set; }
        public bool estado { get; set; }
    }
}
