using System;
using System.Collections.Generic;

namespace AppBancoUniversal.DATA
{
    public enum EstadoCliente { Activo, Inactivo}

    public class Cliente
    {
        public int CodigoCliente { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public EstadoCliente Estado { get; set; }
        public List<Cuenta> ListaCuentas { get; set; }


        public Cliente()
        {
        }
    }
}
