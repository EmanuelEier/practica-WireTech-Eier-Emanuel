using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireTechService
{
    public class Proveedor
    {
        public string Nombre { get; set; }
        public int CodigoUnico { get; set; }
        public string PaisOperaciones { get; set; }
        public int Saldo { get; set; }
        /*
        public string Reporte()
        {
            return $"La entidad {Nombre} está gestionada por [nombre del proveedor] y tuvo [cantidad de pagos] realizados en total.”;
        }
        */


    }
}
