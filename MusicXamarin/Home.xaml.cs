using MusicXamarin.Model;
using MusicXamarin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
       
        public Home()
        {
            InitializeComponent();
        }

        List<int> listaSecuencialAlbumesSeleccionados = new List<int>();

        protected async override void OnAppearing()
        {
            base.OnAppearing();


            //Consulta Local
            List<Album> listaAlbumesLocal = await App.Database.GetAlbumes();

            //Todos
            List<Album> allAlbumes = await App.albumManager.GetAlbumes();

            foreach (var item in allAlbumes)
            {
                item.Agregado = false;
                if (listaAlbumesLocal.FindAll(o => o.Secuencial == item.Secuencial).Count > 0)
                {
                    item.Agregado = true;
                    
                }
            }
            this.CLAlbumes.ItemsSource = allAlbumes;

            //Electronica
            List<Album> allAlbumesElectronica = await App.albumManager.GetAlbumes();
            allAlbumesElectronica = allAlbumesElectronica.FindAll(o => o.SecuencialGenero == 1);
            foreach (var item in allAlbumesElectronica)
            {
                item.Agregado = false;
                if (listaAlbumesLocal.FindAll(o => o.Secuencial == item.Secuencial).Count > 0)
                {
                    item.Agregado = true;

                }
            }
            this.CLAlbumesElectronica.ItemsSource = allAlbumesElectronica;

            //Balada
            List<Album> allAlbumesBalada = await App.albumManager.GetAlbumes();
            allAlbumesBalada = allAlbumesBalada.FindAll(o => o.SecuencialGenero == 2);
            foreach (var item in allAlbumesBalada)
            {
                item.Agregado = false;
                if (listaAlbumesLocal.FindAll(o => o.Secuencial == item.Secuencial).Count > 0)
                {
                    item.Agregado = true;

                }
            }
            this.CLAlbumesBalada.ItemsSource = allAlbumesBalada;

            //Rock
            List<Album> allAlbumesRock = await App.albumManager.GetAlbumes();
            allAlbumesRock = allAlbumesRock.FindAll(o => o.SecuencialGenero == 3);
            foreach (var item in allAlbumesRock)
            {
                item.Agregado = false;
                if (listaAlbumesLocal.FindAll(o => o.Secuencial == item.Secuencial).Count > 0)
                {
                    item.Agregado = true;

                }
            }
            this.CLAlbumesRock.ItemsSource = allAlbumesRock;

            //Vallenato
            List<Album> allAlbumesVallenato = await App.albumManager.GetAlbumes();
            allAlbumesVallenato = allAlbumesVallenato.FindAll(o => o.SecuencialGenero == 4);
            foreach (var item in allAlbumesVallenato)
            {
                item.Agregado = false;
                if (listaAlbumesLocal.FindAll(o => o.Secuencial == item.Secuencial).Count > 0)
                {
                    item.Agregado = true;

                }
            }
            this.CLAlbumesVallenato.ItemsSource = allAlbumesVallenato;

            //Salsa
            List<Album> allAlbumesSalsa = await App.albumManager.GetAlbumes();
            allAlbumesSalsa = allAlbumesSalsa.FindAll(o => o.SecuencialGenero == 5);
            foreach (var item in allAlbumesSalsa)
            {
                item.Agregado = false;
                if (listaAlbumesLocal.FindAll(o => o.Secuencial == item.Secuencial).Count > 0)
                {
                    item.Agregado = true;

                }
            }
            this.CLAlbumesSalsa.ItemsSource = allAlbumesSalsa;




        }

        

        private async void CLAlbumes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {
               

                //también puedo usar
                //List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum( (e.CurrentSelection.FirstOrDefault() as Album).Secuencial);
                List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum( (this.CLAlbumes.SelectedItem as Album).Secuencial);



                await Navigation.PushAsync(new PistasListPage(allPistasByAlbum)
                {
                   // BindingContext = allPistasByAlbum
                });

                CLAlbumes.SelectedItem = null;

                //DisplayAlert("Collection View", "Selección", "Cerrar");
            }

        }

        private async void CLAlbumesElectronica_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {


                //también puedo usar
                //List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum( (e.CurrentSelection.FirstOrDefault() as Album).Secuencial);
                List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum((this.CLAlbumesElectronica.SelectedItem as Album).Secuencial);



                await Navigation.PushAsync(new PistasListPage(allPistasByAlbum)
                {
                    // BindingContext = allPistasByAlbum
                });

                CLAlbumesElectronica.SelectedItem = null;

                //DisplayAlert("Collection View", "Selección", "Cerrar");
            }
        }

        private async void CLAlbumesBalada_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {


                //también puedo usar
                //List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum( (e.CurrentSelection.FirstOrDefault() as Album).Secuencial);
                List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum((this.CLAlbumesBalada.SelectedItem as Album).Secuencial);



                await Navigation.PushAsync(new PistasListPage(allPistasByAlbum)
                {
                    // BindingContext = allPistasByAlbum
                });

                CLAlbumesBalada.SelectedItem = null;

                //DisplayAlert("Collection View", "Selección", "Cerrar");
            }
        }



        private async void CLAlbumesRock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {


                //también puedo usar
                //List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum( (e.CurrentSelection.FirstOrDefault() as Album).Secuencial);
                List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum((this.CLAlbumesRock.SelectedItem as Album).Secuencial);



                await Navigation.PushAsync(new PistasListPage(allPistasByAlbum)
                {
                    // BindingContext = allPistasByAlbum
                });

                CLAlbumesRock.SelectedItem = null;

                //DisplayAlert("Collection View", "Selección", "Cerrar");
            }
        }

        private async void CLAlbumesVallenato_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {


                //también puedo usar
                //List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum( (e.CurrentSelection.FirstOrDefault() as Album).Secuencial);
                List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum((this.CLAlbumesVallenato.SelectedItem as Album).Secuencial);



                await Navigation.PushAsync(new PistasListPage(allPistasByAlbum)
                {
                    // BindingContext = allPistasByAlbum
                });

                CLAlbumesVallenato.SelectedItem = null;

                //DisplayAlert("Collection View", "Selección", "Cerrar");
            }
        }

        private async void CLAlbumesSalsa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {


                //también puedo usar
                //List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum( (e.CurrentSelection.FirstOrDefault() as Album).Secuencial);
                List<Pista> allPistasByAlbum = await App.pistaManager.GetPistasByAlbum((this.CLAlbumesSalsa.SelectedItem as Album).Secuencial);



                await Navigation.PushAsync(new PistasListPage(allPistasByAlbum)
                {
                    // BindingContext = allPistasByAlbum
                });

                CLAlbumesSalsa.SelectedItem = null;

                //DisplayAlert("Collection View", "Selección", "Cerrar");
            }
        }

        private async void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {


            try
            {
              
                var album = (Album)BindingContext;
               // await App.Database.SaveAlbum(album);
                //await DisplayAlert("Exito", "Datos registrados en la base de datos", "De Acuerdo");
                
                //retorna a la pantalla más reciente, sería a la pantalla de donde se llamó a esta
                //await Navigation.PopAsync();
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", ex.Message, "Aceptar");
            }




        }

        
    }
}