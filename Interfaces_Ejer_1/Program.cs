
using Interfaces_Ejer_1;

void Main()
{
    Libro[] catalogo = { new Libro("Sergio Aguirre", "Los vecinos mueren en las novelas"),
                         new Libro("Gabriel García Márquez", "Crónica de una muerte anunciada"),
    };

    Array.Sort(catalogo);   // CompareTo(Libro libro)

    foreach (var libro in catalogo)
    {
        Console.WriteLine(libro);
    }
}

// ejecucion Main
Main();
