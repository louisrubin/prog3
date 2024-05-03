using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// RUBIN AZAS M. Luis - 2024

namespace AlgoritmoCesar
{
    public static class Cesar
    {
        static char[] alfabeto = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz".ToCharArray();  // alfabeto transformado a Array
        
        public static void Descifrar(string fraseCifrada, byte clave)
        {
            foreach (var item in fraseCifrada)
            {
                char caract = ' ';   // si no encuentra imprime un espacio
                for (int i = 0; i < alfabeto.Length; i++)
                {
                    if (item == alfabeto[i])
                    {
                        int posicionEncontrada = Array.IndexOf(alfabeto, alfabeto[i]);
                        int indiceRetrocedido = (posicionEncontrada - clave) % alfabeto.Length;

                        if (indiceRetrocedido < 0) indiceRetrocedido += alfabeto.Length;

                        caract = alfabeto[indiceRetrocedido];
                        break;
                    }
                }
                Console.Write(caract);
            }
        }

        public static string Cifrar(string textoToCifrar, byte clave)
        {
            string fraseCifrada = "";

            foreach (var item in textoToCifrar)
            {
                if (item == ' ')
                {
                    fraseCifrada += " ";
                    continue;
                }
                for (int i = 0; i < alfabeto.Length; i++)
                {
                    if (alfabeto[i] == item)
                    {
                        int posicionEncontrada = Array.IndexOf(alfabeto, alfabeto[i]);
                        int indiceAdelanto = (posicionEncontrada + clave) % alfabeto.Length;

                        if (indiceAdelanto >= alfabeto.Length) indiceAdelanto -= alfabeto.Length;

                        fraseCifrada += alfabeto[indiceAdelanto];
                    }
                }
            }
            //Console.WriteLine(fraseCifrada);
            return fraseCifrada;
        }
    }
}
