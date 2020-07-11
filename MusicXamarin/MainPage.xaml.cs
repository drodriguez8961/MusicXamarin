using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MusicXamarin.Views;
using MusicXamarin.Model;

namespace MusicXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            //LimpiarLista();
            InitializeComponent();
            //Consulta Local
            
            MyMenu();
        }

        //public async void LimpiarLista()
        //{
        //    List<Album> listaAlbumesLocal = await App.Database.GetAlbumes();

        //    foreach (var item in listaAlbumesLocal)
        //    {
        //        await App.Database.DeleteAlbum(item);
        //    }
        //}

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    //Consulta Local
        //    List<Album> listaAlbumesLocal = await App.Database.GetAlbumes();

        //    foreach (var item in listaAlbumesLocal)
        //    {
        //        await App.Database.DeleteAlbum(item);
        //    }

            
        //}

        public void MyMenu()
        {
           

            Detail = new NavigationPage(new Home());
            List<Menu> menu = new List<Menu>
            {
                new Menu { Page = new Home(), MenuTitle = "Home" },
                new Menu { Page = new UbicanosPage(), MenuTitle = "Ubícanos" },
                new Menu { Page = new ComprarPage(), MenuTitle = "Comprar" }


            };

            ListMenu.ItemsSource = menu;

        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
        }

        public class Menu
        {
            public string MenuTitle { get; set; }
            public Page Page { get; set; }
        }
      
    }
}
