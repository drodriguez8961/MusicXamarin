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
    public class PistaRestServices : IPistaRestServices
    {
        HttpClient _client;
        public PistaRestServices()
        {
            _client = new HttpClient();

        }

        public List<Pista> ListaPistas { get; set; }
        public Pista Pista { get; set; }

        public async Task<List<Pista>> GetPistas()
        {
            ListaPistas = new List<Pista>();
            var uri = new Uri(string.Format(Constants.PistasListarUrl, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    ListaPistas = JsonConvert.DeserializeObject<List<Pista>>(content);
                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return ListaPistas;

        }

        public async Task<Pista> GetPista(int secuencial)
        {
            Pista = new Pista();
            var uri = new Uri(string.Format(Constants.PistasMostrarUrl, secuencial));
            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    Pista = JsonConvert.DeserializeObject<Pista>(content);
                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return Pista;

        }

        public async Task<List<Pista>> GetPistasByAlbum(int secuencialAlbum)
        {
            ListaPistas = new List<Pista>();
            var uri = new Uri(string.Format(Constants.PistasListarPorAlbumUrl, secuencialAlbum));
            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    ListaPistas = JsonConvert.DeserializeObject<List<Pista>>(content);
                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return ListaPistas;

        }
    }
}
