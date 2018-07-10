using System;
namespace AppBancoUniversal.DATA
{
    public enum EstadoTransferencia { Pendiente = 1, Autorizada = 2, Rechazada = 3 }

    public class Transferencia
    {
        public int CodigoCliente { get; set; }
        public DateTime FechaHora { get; set; }
        public int NumeroCuentaOrigen { get; set; }
        public int NumeroCuentaDestino { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public EstadoTransferencia Estado { get; set; }

        public Transferencia()
        {
        }
    }
}
