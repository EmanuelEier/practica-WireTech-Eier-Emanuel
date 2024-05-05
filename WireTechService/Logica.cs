using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static WireTechService.Servicio;

namespace WireTechService
{
    public class Logica
    {
        public List<Proveedor> Proveedores { get; set; }

        public List<Servicio> Servicios { get; set; }

        public List<Pago> Pagos { get; set; }

        public void CargarProveedores()
        { 
           
            Proveedor Raclo = new Proveedor() { CodigoUnico = Proveedores.Max(x => x.CodigoUnico) + 1, PaisOperaciones = "Argentina", Saldo = 0, Nombre = "Raclo" };
            Proveedores.Add(Raclo);
            Proveedor Chobb = new Proveedor() { CodigoUnico = Proveedores.Max(x => x.CodigoUnico) + 1, PaisOperaciones = "Mexico", Saldo = 0, Nombre = "Chobb" };
            Proveedores.Add(Chobb);
            Proveedor Curibita = new Proveedor() { CodigoUnico = Proveedores.Max(x => x.CodigoUnico) + 1, PaisOperaciones = "Brasil", Saldo = 0, Nombre = "Curibita" };
            Proveedores.Add(Curibita);
        }


        public void CargarProveedor(string nom, string pais)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = nom;
            proveedor.PaisOperaciones = pais;
            proveedor.Saldo = 0;
            proveedor.CodigoUnico = Proveedores.Max(x=>x.CodigoUnico)+1;

            Proveedores.Add(proveedor);
      
        }

        public (bool, int) RetirarSaldoProveedor(int Importe, int CodProveedor)
        {
            int indice = Proveedores.FindIndex(x => x.CodigoUnico == CodProveedor);

            if ((Proveedores[indice].Saldo - Importe) < 0)
            {
                return (false, Proveedores[indice].Saldo);

            }
            else
            {
                Proveedores[indice].Saldo += Importe;
                return (true, 0);
            }

        }

        public void NuevaTransaccion(int doc, int codserv, int imp)
        {
            Pago pago = new Pago();

            if (Pagos.Count == 0) pago.CodigoTransaccion = 1;
            else pago.CodigoTransaccion = Pagos.Max(x => x.CodigoTransaccion) + 1;

            pago.DNI = doc;
            pago.CodigoServicio = codserv;
            pago.Importe = imp;

            Pagos.Add(pago);
            int indice = Servicios.FindIndex(x => x.Equals(pago.CodigoServicio));

            Servicios[indice].Saldo += imp;
        }

        public void CargarServicio(string nombre, string descripcion, int codproveedor, int z, bool tipo, double imp)
        {
            int CodUnico;
            if (Servicios.Count == 0) CodUnico = 1;
            else CodUnico = Servicios.Max(x => x.CodigoUnico) + 1;

            if (tipo)
            {
                Electrico electrico = new Electrico() { Nombre = nombre, Descripcion = descripcion, CodProveedor = codproveedor, CodigoUnico = CodUnico, zona = (Zona)z, PorcentajeImpuestos = imp  };
            }
            else
            {
                Comunicacion comunicacion = new Comunicacion() { Nombre = nombre, Descripcion = descripcion, CodProveedor = codproveedor, zona = (Zona)z };
                comunicacion.CalcularDescuento();
            }
            
        }
    }
}
