using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PistasListPage : ContentPage
    {
        private int _secuencialAlbum;
        public PistasListPage(List<Pista>listaPistas)
        {
            InitializeComponent();
            this._secuencialAlbum = listaPistas[0].SecuencialAlbum;
            this.lstPistas.ItemsSource = listaPistas;
        }

        private void lstPistas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Album albumRest = await App.albumManager.GetAlbum(this._secuencialAlbum);

                bool agregar = await DisplayAlert("Exito", string.Format("Desea agregar el CD {0} para la compra?", albumRest.Nombre), "De Acuerdo", "Cancelar");

                if (agregar)
                {
                    

                    List<Album> listaAlbumesLocal = await App.Database.GetAlbumes();


                    if (!listaAlbumesLocal.Exists(o => o.Secuencial == albumRest.Secuencial))
                    {

                        albumRest.Agregado = true;
                        await App.Database.SaveAlbum(albumRest);


                        //await App.Database.DeleteAlbum(albumRest);

                        //retorna a la pantalla más reciente, sería a la pantalla de donde se llamó a esta

                    }
                    else
                    {
                        await DisplayAlert("Advertencia", string.Format("El CD {0} ya fue agregado ala lista", albumRest.Nombre), "De Acuerdo");
                    }

                   
                }
                await Navigation.PopAsync();

            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", ex.Message, "Aceptar");
            }

        }
    }
}