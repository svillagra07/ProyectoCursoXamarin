using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppBancoUniversal.XAML
{
    public partial class LoginPage : ContentPage
    {
        async void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrincipalPage());
        }


        async void BtnOlvidoClave_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XAML.RecuperarClavePage());
        }


        async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new XAML.RegistroPage());
        }


        public LoginPage()
        {
            InitializeComponent();
            btnRegistrar.Clicked += BtnRegistrar_Clicked;
            btnOlvidoClave.Clicked += BtnOlvidoClave_Clicked;
            btnIniciarSesion.Clicked += BtnIniciarSesion_Clicked;
        }
    }
}
