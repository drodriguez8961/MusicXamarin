using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.LocalNotifications;

namespace MusicXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComprarPage : ContentPage
    {
        List<Album> listaAlbumesLocal;
        public ComprarPage()
        {
            InitializeComponent();
            //Consulta Local
            
           
        }

       

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listaAlbumesLocal = await App.Database.GetAlbumes();
            this.lstCompras.ItemsSource = listaAlbumesLocal;
        }

        private async void BtnComprar_Clicked(object sender, EventArgs e)
        {
            try
            {
              bool comprar =  await DisplayAlert("Exito", string.Format("El valor total de la compra es de:\n{0} USD", listaAlbumesLocal.Sum(o=>o.Precio)), "De Acuerdo", "Cancelar");

                if (comprar)
                {
                    foreach (var item in listaAlbumesLocal)
                    {
                        await App.Database.DeleteAlbum(item);
                    }

                    this.lstCompras.ItemsSource = new List<Album>();
                    await Navigation.PushAsync(new Home()
                    {
                    });

                    decimal precio = listaAlbumesLocal.Sum(o => o.Precio);

                    CrossLocalNotifications.Current.Show("TIENDA MÚSICA", string.Format("Realizó una compra por {0} Dólares\n" +
                        "GRACIAS POR SU COMPRA", precio), 0, DateTime.Now.AddSeconds(2));
                }
               
            }
            catch (Exception)
            {

                throw;
            }
           

        }
    }
}