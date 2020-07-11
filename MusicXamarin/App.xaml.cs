using MusicXamarin.Data;
using MusicXamarin.Interface;
using MusicXamarin.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicXamarin
{
    public partial class App : Application
    {
        public static GeneroManager generoManager { get; set; }
        public static AlbumManager albumManager { get; set; }

        public static PistaManager pistaManager { get; set; }

        static AlbumDBLocal database;

        public static AlbumDBLocal Database
        {
            get
            {

                if (database == null)
                {
                    database = new AlbumDBLocal(DependencyService.Get<IStdLocHelper>().GetLocalFilePath("musicadb.db"));

                }

                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            generoManager = new GeneroManager(new GeneroRestServices());
            albumManager = new AlbumManager(new AlbumRestServices());
            pistaManager = new PistaManager(new PistaRestServices());

             MainPage = new MainPage();
          //  MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
