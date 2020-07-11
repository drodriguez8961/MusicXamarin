using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicXamarin.Data
{
    public interface IPistaRestServices
    {
        Task<List<Pista>> GetPistas();
        Task<Pista> GetPista(int secuencial);

        Task<List<Pista>> GetPistasByAlbum(int secuencialAlbum);
        //Task SavePista(Pista pista, bool isNew);
    }
}
