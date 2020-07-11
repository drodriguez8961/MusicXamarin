using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicXamarin.Data
{
    public class AlbumManager
    {
        IAlbumRestServices _albumRestServices;

        public AlbumManager(IAlbumRestServices services)
        {
            _albumRestServices = services;

        }

        public Task<List<Album>> GetAlbumes()
        {
            return _albumRestServices.GetAlbumes();
        }

        public Task<Album> GetAlbum(int secuencial)
        {
            return _albumRestServices.GetAlbum(secuencial);
        }


    }
}
