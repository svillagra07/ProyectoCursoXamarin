using System;
namespace AppBancoUniversal.DATA
{
    public class Pago
    {
        public int IdComprobantePago { get; set; }
        public DateTime FechaHora { get; set; }
        public int CodigoCliente { get; set; }
        public int NumeroCuenta { get; set; }
        public int NombreServicio { get; set; }
        public decimal Monto { get; set; }


        public Pago()
        {
        }
    }
}
