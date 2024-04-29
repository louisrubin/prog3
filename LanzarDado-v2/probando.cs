using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzarDado
{
    static class probando
    {
        static List<char> alfabeto = new List<char> { 'a','á', 'b', 'c', 
            'd', 'e', 'é', 'f', 'g', 'h', 
            'i', 'í', 'j', 'k','l','m','n','ñ',
            'o','ó','p','q','r','s','t','u','ú','ü','v','w','x','y','z'};
        static char[] datos;
        static int a = 0;

        public static int clave = 3;

        public static void Main()
        {
            Console.Write("ingrese texto cifrado: ");
            string texCifrado = Console.ReadLine();

            datos = new char[texCifrado.Length];

            while (true)
            {
                foreach (var caracter in texCifrado)
                {
                    if (caracter.ToString() == " ")
                    {
                        datos[a] = ' ';
                        a++;
                        continue;
                    }
                    if (alfabeto.Contains(caracter))
                    {
                        int posic = alfabeto.IndexOf(caracter);
                        // DEBE VOLVER AL INICIO DEL ARREGLO UNA VEZ QUE LLEGO AL FINAL
                        datos[a] = alfabeto[posic + clave];
                        a++;
                    }
                }

                foreach (var caracter in datos)
                {

                    Console.Write(caracter);
                }

                Console.Write("mensaje correcto? (1: SI): ");
                int opc;
                int.TryParse(Console.ReadLine(), out opc);

                if(opc == 1)
                {
                    Console.WriteLine("clave: " + clave);
                    break;
                }

                clave++;
            }
            
        }
    }
}
