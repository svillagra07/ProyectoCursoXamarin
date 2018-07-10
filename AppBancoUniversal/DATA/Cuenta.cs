using System;
namespace AppBancoUniversal.DATA
{
    public enum EstadoCuenta { Activa , Inactiva, Congelada}
    public enum Moneda { Colones, Dolares}

    public class Cuenta
    {

        public int CodigoCliente { get; set; }
        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public decimal Saldo { get; set; }
        public EstadoCuenta Estado { get; set; }
        public Moneda Moneda { get; set; }


        public string DetalleCuenta
        {

            get
            {
                return string.Format("Cuenta: {0} - {1}", Numero, Descripcion);
            }
        }

        public string DetalleSaldo
        {

            get
            {
                return string.Format("Moneda: {0} | Saldo: {1:N}",Moneda, Saldo);
            }
        }

        public Cuenta()
        {
        }
    }
}
