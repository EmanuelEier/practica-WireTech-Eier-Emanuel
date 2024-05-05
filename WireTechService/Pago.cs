using System.Diagnostics.CodeAnalysis;

namespace WireTechService
{
    public class Pago : Logica
    {
        public int CodigoTransaccion { get; set; }
        public DateTime Fecha = DateTime.Today;
        public int DNI { get; set; }
        public int CodigoServicio { get; set; }
        public double Importe { get; set; }

    }
}
