using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public static class SistemaCorreo
    {
        private static Correo[] correosEnviados = new Correo[10];
        private static Usuario userMain = new Usuario("Luis", "Rubin", "Av. Buendia, 934", "080025521");
        private static Usuario user2 = new Usuario("Pepe", "Gonzales", "Riesco, 450", "080125151");
        private static Usuario user3 = new Usuario("Juan", "Perez", "Diagonal 9, 239", "085158402");

        public static Correo[] CorreosEnviados { get { return correosEnviados; } }

        public static byte cantCorrEnviados = 0;

        public static void EnviarCorreo()
        {
            Correo newCorreo;
            Usuario userDestino = null;
            byte cantCorrEnvi;      // cantidad a enviar

            while (true)
            {
                if (cantCorrEnviados == correosEnviados.Length)
                {
                    Console.WriteLine("Superó la cantidad de correos permitidos.");
                    break;
                }
                Console.WriteLine($"Correo [{cantCorrEnviados + 1}]\n");
                byte opcDest;
                Console.Write($"Destinatario:\n[1]- {user2.ToString()}" +
                $"\n[2]- {user3.ToString()}\n --> ");
                byte.TryParse(Console.ReadLine(), out opcDest);

                if (opcDest == 1)
                {
                    userDestino = user2;
                    break;
                }
                if (opcDest == 2)
                {
                    userDestino = user3;
                    break;
                }
            }
            Console.Write("Asunto: ");
            string asuntoMessage = Console.ReadLine();
            Console.Write("Cuerpo: ");
            string cuerpoMessage = Console.ReadLine();

            newCorreo = new Correo(userMain, userDestino, asuntoMessage, cuerpoMessage);

            correosEnviados[cantCorrEnviados] = newCorreo; ;
            cantCorrEnviados++;

            Console.WriteLine("\nCorreo enviado.\n");

        }

        public static void EliminarCorreo()
        {
            if (correosEnviados.Length < 1)
            {
                Console.WriteLine("Vacio");
                return;
            }

            byte numCorreo;
            Console.WriteLine("\nELIMINAR CORREO\n");
            for (int x = 0; x < cantCorrEnviados; x++)
            {
                Console.WriteLine($"[{x + 1}] - {correosEnviados[x].ToString()}");
            }
            Console.Write(" --> ");
            byte.TryParse(Console.ReadLine(), out numCorreo);

            if (numCorreo > 0 && numCorreo <= cantCorrEnviados)
            {
                correosEnviados[numCorreo - 1] = null;

            }

        }

    }
}
