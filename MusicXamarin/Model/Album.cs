using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicXamarin.Model
{
    public class Album
    {
        [PrimaryKey]
        public int Secuencial { get; set; }
        public int SecuencialArtista { get; set; }

        public string NombreArtista { get; set; }

        public int SecuencialGenero { get; set; }

        public string NombreGenero { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaLanzamiento { get; set; }

        public string Etiqueta { get; set; }

        public decimal Precio { get; set; }

        public bool Agregado { get; set; }
    }
}
