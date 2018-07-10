using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppBancoUniversal.XAML
{
    public partial class RecuperarClavePage : ContentPage
    {
        void BtnRecuperar_Clicked(object sender, EventArgs e)
        {
            List<string> destinatarios = new List<string>();
            destinatarios.Add(txtEmail.Text);

            SendEmail("Recuperar contraseña", "Su contraseña es 123456",destinatarios);
        }


        async void BtnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        public RecuperarClavePage()
        {
            InitializeComponent();
            btnRegresar.Clicked += BtnRegresar_Clicked;
            btnRecuperar.Clicked += BtnRecuperar_Clicked;
        }

        public async void SendEmail(string subject, string body, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients
                    //Cc = ccRecipients,
                    //Bcc = bccRecipients,
                };

                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                Debug.WriteLine("Exception:>>" + fbsEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception:>>" + ex);
            }


        }

    }
}
