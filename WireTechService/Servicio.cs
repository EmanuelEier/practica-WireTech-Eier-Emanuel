using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireTechService
{
    public abstract class Servicio : Proveedor
    {
        public int CodigoUnico { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CodProveedor { get; set; }

        public enum Zona { cuyo = 1, norte = 2, centro = 3, patagonia = 4 }

        public Zona zona { get; set; }

    }
}
