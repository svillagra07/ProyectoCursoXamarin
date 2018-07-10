using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppBancoUniversal.XAML
{
    public partial class RegistroPage : ContentPage
    {
        async void BtnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        public RegistroPage()
        {
            InitializeComponent();
            btnRegresar.Clicked += BtnRegresar_Clicked;
        }
    }
}
