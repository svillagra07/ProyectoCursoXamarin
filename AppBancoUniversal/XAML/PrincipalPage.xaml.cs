using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AppBancoUniversal.XAML
{
    public partial class PrincipalPage : MasterDetailPage
    {


        public PrincipalPage()
        {
          
            ToolbarItem itemInicio = new ToolbarItem
                {
                Text = "tbiInicio",
                    Command = new Command(() => Navigation.PushAsync(new XAML.SaldosPage())),
                Icon = "IMG/ic_home_black_18dp.png"
                };

            ToolbarItem itemInformacion = new ToolbarItem
            {
                Text = "tbiInformacion",
                Command = new Command(() => Navigation.PushAsync(new XAML.DeviceInfoPage())),
                Icon = "IMG/ic_perm_device_information_black_18dp.png"
            };

            ToolbarItem itemSalir = new ToolbarItem
            {
                Text = "tbiSalir",
                Command = new Command(() => Navigation.PushAsync(new XAML.LoginPage())),
                Icon = "IMG/ic_exit_to_app_black_18dp.png"
            };

           /* ToolbarItems.Add(itemInformacion);    
            ToolbarItems.Add(itemSalir); 
            ToolbarItems.Add(itemInicio); */

            InitializeComponent();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                listView.SelectedItem = null;
                IsPresented = false;
            }
        }

        void BtnSalir_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new XAML.LoginPage();
        }


        void BtnInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XAML.DeviceInfoPage());
        }


    }
}
