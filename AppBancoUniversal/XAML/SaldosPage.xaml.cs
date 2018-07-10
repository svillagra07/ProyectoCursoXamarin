using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AppBancoUniversal.DATA;
using Xamarin.Forms;

namespace AppBancoUniversal.XAML
{
    public partial class SaldosPage : ContentPage
    {
        readonly IList<Cliente> clientes = new ObservableCollection<Cliente>();
        readonly IList<Cuenta> cuentas = new ObservableCollection<Cuenta>();

        Cliente cliente = new Cliente { CodigoCliente = 1, Nombre = "Samuel Villagra", 
            FechaNacimiento = Convert.ToDateTime("1984/06/27"), Estado = EstadoCliente.Activo,  ListaCuentas = null };


        public SaldosPage()
        {

            clientes.Add(cliente);

            cuentas.Add(new Cuenta { CodigoCliente = 1, Numero = 100001, Descripcion = "Personal", Saldo = 100000, Estado = EstadoCuenta.Activa, Moneda= Moneda.Colones });
            cuentas.Add(new Cuenta { CodigoCliente = 2, Numero = 100002, Descripcion = "Negocio", Saldo = 500000, Estado = EstadoCuenta.Activa,Moneda = Moneda.Colones});
            cuentas.Add(new Cuenta { CodigoCliente = 3, Numero = 100003, Descripcion = "Casa", Saldo = 20000, Estado = EstadoCuenta.Activa, Moneda =Moneda.Dolares });
            cuentas.Add(new Cuenta { CodigoCliente = 4, Numero = 100004, Descripcion = "Negocio2", Saldo = 10000, Estado = EstadoCuenta.Activa, Moneda = Moneda.Dolares });
            BindingContext = cuentas;

            InitializeComponent();
        }
    }
}
