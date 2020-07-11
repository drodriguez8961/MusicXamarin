using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicXamarin.Data
{
    public class GeneroManager
    {
        IGeneroRestServices _generoRestServices;

        public GeneroManager(IGeneroRestServices services)
        {
            _generoRestServices = services;

        }

        public Task<List<Genero>> GetGeneros()
        {
            return _generoRestServices.GetGeneros();
        }

        public Task<Genero> GetGenero(int secuencial)
        {
            return _generoRestServices.GetGenero(secuencial);
        }


    }
}
