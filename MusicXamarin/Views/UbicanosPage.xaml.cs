using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace MusicXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UbicanosPage : ContentPage
    {
        public UbicanosPage()
        {
            InitializeComponent();
            MostrarMapa(0.3658589, -78.1289871);
        }

        public void MostrarMapa(double latitud, double longitud)
        {
            base.OnAppearing();

            MapaGeo.MoveToRegion(

                MapSpan.FromCenterAndRadius
                (
                    new Position(latitud, longitud),
                    Distance.FromKilometers(0.5)
                 )

                );
            var pos = new Position(latitud, longitud);

            //puntitos rojos sobre los mapas
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = pos,
                Label = "MUSIC CD",
                Address= "Calle Macas 21-58 y Ambato"
                
            };

            pin.MarkerClicked += async (s, args) =>
            {
                args.HideInfoWindow = true;
                string pinName = ((Pin)s).Label;
                await DisplayAlert("Music CD", $"Tienda de CD's de Música.\n" +
                    $"Estamos Ubicados en la Calle Macas 21-58 y Ambato, sector Azaya \n" +
                    $"IBARRA - IMBABURA - ECUADOR", "Ok");
            };

            this.MapaGeo.Pins.Add(pin);
        }
    }
}