namespace BibliotecaServicios
{
    public class PagosServicios
    {
        public int CodigoTransaccion { get; set; }
        public DateTime Fecha = DateTime.Today;
        public int DNI { get; set; }
        public int CodigoServicio { get; set; }
        public double Importe { get; set; }

    }
    
    public class Proveedores
    {
        public int CodigoUnico { get; set; }
        public string PaisOperaciones { get; set; }
        public int Saldo { get; set; }
        /*
        public ActualizarSaldoProveedor() 
        {
            Saldo += 0;
        }

        public ImprimirReporte
        */
    }

    public class Servicios
    {
        public int CodigoServicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CodigoProveedor { get; set; }

    }

    public class ServiciosElectricos : Servicios
    {
        public int PorcentajeImpuestos { get; set; }
        public enum Zona { cuyo, norte, centro, patagonia }
    }

    public class ServiciosComunicacion : Servicios
    {
        public enum Zona { cuyo = 1, norte = 2, centro = 3, patagonia= 4}

        /*public int CalcularDescuento()
        {
            //switch (Zona)
            {
                case Zona.cuyo: return 15; break;
                case Zona.centro: return 10; break;
                default: return 0; break;
            }
             
        }*/
    }
        

}
