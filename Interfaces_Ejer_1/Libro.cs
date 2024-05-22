using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Ejer_1
{
    public class Libro : IColeccionable, IComparable<Libro>     // IComparable<Type Object>
    {
        private string autor, titulo;

        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }

        public Libro(string autor, string titulo) {
            this.autor = autor;
            this.titulo = titulo;
        }

        public void Describir()
        {
            Console.WriteLine($"Autor: {autor}, Titulo: {titulo}");
        }


        public int CompareTo(Libro libro)   // comparar dos objetos del mismo tipo (<Libro> en este caso) 
        {
            if (libro == null) return 1;
            return this.Titulo.CompareTo(libro.Titulo);
        }


        // invalidacion de ToString
        public override string ToString()
        {
            return $"'{titulo}' por {autor}";
        }
    }
}
