using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicXamarin.Data
{
    public class PistaManager
    {
        IPistaRestServices _pistaRestServices;

        public PistaManager(IPistaRestServices services)
        {
            _pistaRestServices = services;

        }

        public Task<List<Pista>> GetPistas()
        {
            return _pistaRestServices.GetPistas();
        }

        public Task<Pista> GetPista(int secuencial)
        {
            return _pistaRestServices.GetPista(secuencial);
        }

        public Task<List<Pista>> GetPistasByAlbum(int secuencialAlbum)
        {
            return _pistaRestServices.GetPistasByAlbum(secuencialAlbum);
        }


    }
}
