using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicXamarin.Data
{
    public interface IAlbumRestServices
    {
        Task<List<Album>> GetAlbumes();
        Task<Album> GetAlbum(int secuencial);
        //Task SaveAlbum(Album album, bool isNew);
    }
}
