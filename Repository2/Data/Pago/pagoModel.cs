using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Pago
{
    internal class pagoModel
    {
        public int PagoID { get; set; }
        public int SuscripcionID { get; set; }
        public DateTime FechaPago {  get; set; }
        public double Monto { get; set; }
        public string MetodoPago { get; set; }
    }
}
