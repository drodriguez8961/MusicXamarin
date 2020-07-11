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
    public class AlbumRestServices : IAlbumRestServices
    {
        HttpClient _client;
        public AlbumRestServices()
        {
            _client = new HttpClient();

        }

        public List<Album> ListaAlbumes { get; set; }
        public Album Album { get; set; }

        public async Task<List<Album>> GetAlbumes()
        {
            ListaAlbumes = new List<Album>();
            var uri = new Uri(string.Format(Constants.AlbumesListarUrl, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    ListaAlbumes = JsonConvert.DeserializeObject<List<Album>>(content);
                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return ListaAlbumes;

        }

        public async Task<Album> GetAlbum(int secuencial)
        {
            Album = new Album();
            var uri = new Uri(string.Format(Constants.AlbumesMostrarUrl, secuencial));
            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    Album = JsonConvert.DeserializeObject<Album>(content);
                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return Album;

        }
    }
}
