using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Suscripcion
{
    internal class suscripcionModel
    {
        public int SuscripcionID { get; set; }
        public int ClienteID { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public double Precio { get; set; }
    }
}
