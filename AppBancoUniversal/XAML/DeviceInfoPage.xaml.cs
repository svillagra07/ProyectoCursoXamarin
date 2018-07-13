using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AppBancoUniversal.DATA;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppBancoUniversal.XAML
{
    public partial class DeviceInfoPage : ContentPage
    {
        readonly IList<Dispositivo> dispositivos = new ObservableCollection<Dispositivo>();
     
        private Dispositivo ObtenerInfoDispositivo()
        {
           
            Dispositivo dispositivo = new Dispositivo();

            dispositivo.Model = DeviceInfo.Model;
            dispositivo.Manufacturer = DeviceInfo.Manufacturer;
            dispositivo.DeviceName = DeviceInfo.Name;
            dispositivo.Version = DeviceInfo.Version.ToString();
            dispositivo.Platform = DeviceInfo.Platform;
            dispositivo.Idiom = DeviceInfo.Idiom;
            dispositivo.DeviceType = DeviceInfo.DeviceType.ToString();

            return dispositivo;
        }

        public DeviceInfoPage()
        {
            dispositivos.Add(ObtenerInfoDispositivo());
            BindingContext = dispositivos;
            InitializeComponent();
        }
    }
}
