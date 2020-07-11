using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicXamarin.Data
{
    public interface IGeneroRestServices
    {
        Task<List<Genero>> GetGeneros();
        Task<Genero> GetGenero(int secuencial);
        //Task SaveGenero(Genero genero, bool isNew);
    }
}
