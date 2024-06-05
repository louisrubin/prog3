using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Archivos
{    
    public class Musica
    {
        string nombre, album, artista;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Album { get { return album; } set { album = value; } }
        public string Artista { get { return artista; } set { artista = value; } }

        public Musica()
        {
            
        }
        public Musica(string nam, string art, string alb)
        {
            this.nombre = nam;
            this.artista = art;
            this.album = alb;
        }

        public override string ToString()
        {
            return $"Canción: '{nombre}', Artista: {artista}, Album: '{album}'";
        }
    }
}
