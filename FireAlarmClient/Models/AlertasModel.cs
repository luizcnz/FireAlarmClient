using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarmClient.Models
{
    internal class AlertasModel
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public bool alerta_fuego { get; set; }
        public bool alerta_humo { get; set; }
        public bool alerta_calor { get; set; }
        public int temperatura { get; set; }
        public DateTime? fecha_creacion { get; set; }
        public DateTime? fecha_respuesta { get; set; }
        public bool estado_alerta { get; set; }
        public string ubicacion { get; set; }
    }

    internal class ApagarAlerta
    {
        public int id { get; set; }
        public DateTime? fecha_respuesta { get; set; }
    }
}
