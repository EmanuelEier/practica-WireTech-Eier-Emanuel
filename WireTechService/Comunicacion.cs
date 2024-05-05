using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireTechService
{
    public class Comunicacion : Servicio
    {
        public double Descuento { get; set; }  

        public void CalcularDescuento()
        {
            switch (zona)
            {
                case Zona.cuyo: Descuento = 0.15; 
                    break;
                case Zona.centro: Descuento = 0.10; 
                    break;
                default: Descuento = 0; 
                    break;

            }
        }

    }

}
