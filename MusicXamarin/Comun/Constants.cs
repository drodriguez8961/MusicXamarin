using System;
using System.Collections.Generic;
using System.Text;

namespace MusicXamarin.Comun
{
    public class Constants
    {
        public static string BaseAddress = "http://192.168.1.9:8080/api";
        
        //Géneros
        public static string GenerosListarUrl = BaseAddress + "/Generos/Listar";
        public static string GenerosMostrarUrl = BaseAddress + "/Generos/Mostrar/{0}";
        public static string GenerosCrearUrl = BaseAddress + "/Generos/Crear";

        //Artistas
        public static string ArtistasListarUrl = BaseAddress + "/Artistas/Listar";
        public static string ArtistasMostrarUrl = BaseAddress + "/Artistas/Mostrar/{0}";
        public static string ArtistasCrearUrl = BaseAddress + "/Artistas/Crear";

        //Álbumes
        public static string AlbumesListarUrl = BaseAddress + "/Albumes/Listar";
        public static string AlbumesMostrarUrl = BaseAddress + "/Albumes/Mostrar/{0}";
        public static string AlbumesCrearUrl = BaseAddress + "/Albumes/Crear";


        //Pistas
        public static string PistasListarUrl = BaseAddress + "/Pistas/Listar";
        public static string PistasListarPorAlbumUrl = BaseAddress + "/Pistas/ListarPorAlbum/{0}";
        public static string PistasMostrarUrl = BaseAddress + "/Pistas/Mostrar/{0}";
        public static string PiestasCrearUrl = BaseAddress + "/Pistas/Crear";
    }
}
