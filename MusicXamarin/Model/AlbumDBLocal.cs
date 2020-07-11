using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicXamarin.Model
{
    public class AlbumDBLocal
    {
        readonly SQLiteAsyncConnection database;

        public AlbumDBLocal(string dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<Album>().Wait();
        }

        //Retorna todos los albumes (list view)
        public Task<List<Album>> GetAlbumes()
        {
            return database.Table<Album>().ToListAsync();
        }

        //Retorno de Información seleccionado de la lista
        public Task<Album> GetAlbumById(int id)
        {
            return database.Table<Album>().Where(o => o.Secuencial == id).FirstOrDefaultAsync();
        }

        //Registro de albumes
        public Task<int> SaveAlbum(Album album)
        {
            return database.InsertAsync(album);
        }

        //Update de album
        public Task<int> UpdateAlbum(Album album)
        {
            return database.UpdateAsync(album);
        }

        //delete se album
        public Task<int> DeleteAlbum(Album album)
        {
            return database.DeleteAsync(album);
        }
    }
}
