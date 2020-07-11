using MusicXamarin.Comun;
using MusicXamarin.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;

namespace MusicXamarin.Data
{
    public class GeneroRestServices : IGeneroRestServices
    {
        HttpClient _client;
        public GeneroRestServices()
        {
            _client = new HttpClient();

        }

        public List<Genero> ListaGeneros { get; set; }
        public Genero Genero { get; set; }

        public async Task<List<Genero>> GetGeneros()
        {
            ListaGeneros = new List<Genero>();
            var uri = new Uri(string.Format(Constants.GenerosListarUrl, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    ListaGeneros = JsonConvert.DeserializeObject<List<Genero>>(content);
                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return ListaGeneros;

        }

        public async Task<Genero> GetGenero(int secuencial)
        {
            Genero = new Genero();
            var uri = new Uri(string.Format(Constants.GenerosMostrarUrl, secuencial));
            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    Genero = JsonConvert.DeserializeObject<Genero>(content);
                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return Genero;

        }
    }
}
