using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LanzarDadoV2;

namespace LanzarDadoV2
{
    public static class Game
    {
        private static Dado dado1 = new Dado(), dado2 = new Dado();

        private static byte resultDado1, resultDado2;

        private static List<Jugador> jugadores = new List<Jugador> {
            new Jugador(), new Jugador(),
        };

        private static List<ModoJuego> modosJuegos = new List<ModoJuego> {      // lista de modos de juego
            new ModoJuego("conservador", 2, 3),
            new ModoJuego("arriesgado", 3, 6),
            new ModoJuego("desesperado", 5, 16),
        };


        public static void Jugar()
        {
            while(true)
            {
                foreach (var item in jugadores)
                {
                    // verifica si todos los jugadores tienen dinero para jugar minimo el modo mas económico
                    if (item.tieneSaldo(modosJuegos[0].getPorcentPierde(0.2)))
                    {
                        continue;
                    } else if (Casino.getPozo() < (modosJuegos[0].getPorcentPierde(0.2) ) )
                    {
                        Console.WriteLine("\nEl CASINO no tiene más dinero.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nAl menos un jugador no tiene más dinero.\n");
                        Environment.Exit(0);
                    }
                }
                Apostar();
                EmpezarJuego();
                Console.WriteLine("\n\nContinuar.");
                Console.ReadLine();
            }
        }

        private static void Apostar()
        {
            foreach (var jugador in jugadores)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Pozo casino: $" + Casino.getPozo());
                    Console.WriteLine($"Jugador {jugador.Id}");
                    Console.Write("Ingrese Dado (1-6): ");
                    byte.TryParse(Console.ReadLine(), out jugador.dadoElegido);

                    if (jugador.dadoElegido > 0 && jugador.dadoElegido < 7) break;
                }


                while (true)
                {
                    byte opc;
                    Console.Clear();
                    Console.Write("MODO DE JUEGO\n[1] Conservador (P: x1 - G: x2)\n[2] Arriesgado (P: x2 - G: x5)\n[3] Desesperado (P: x4 - G: x15)\n  --> ");
                    byte.TryParse(Console.ReadLine(), out opc);

                    if (opc > 0 && opc <= modosJuegos.Count)
                    {
                        jugador.modoElegido = modosJuegos[opc - 1];
                        break;
                    };
                }


                byte vuelta = 0;
                while (true)
                {
                    if (vuelta >= 1) Console.WriteLine($"DADO: {jugador.dadoElegido}\nModo de Juego: " + jugador.modoElegido.getName());

                    Console.WriteLine("\nSaldo: $" + jugador.getBilletera());
                    Console.Write("Ingrese apuesta: $");
                    double.TryParse(Console.ReadLine(), out jugador.montoApostado);

                    if (jugador.montoApostado <= 0) continue;

                    if (jugador.tieneSaldo(jugador.montoApostado + jugador.modoElegido.getPorcentPierde(jugador.montoApostado)))
                    {
                        jugador.setBilletera(jugador.montoApostado * (-1));    // resta el monto apostado
                        Casino.setApuesta(jugador.montoApostado);     // aumenta el pozo del casino
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente.\n\nContinuar.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    vuelta += 1;
                }
            }
        }


        private static void EmpezarJuego()
        {
            lanzarDados();      // lanzamiento de dados
            Console.WriteLine("Pozo casino: $" + Casino.getPozo());
            foreach (var jugador in jugadores)
            {
                Console.Write($"Jugador {jugador.Id} ");
                if (jugador.dadoElegido == resultDado1 || jugador.dadoElegido == resultDado2)
                {
                    double montoGanado = jugador.modoElegido.gano(jugador.montoApostado);
                    jugador.setBilletera(montoGanado);      // actualiza la billetera del jugador
                    Casino.setApuesta(montoGanado * (-1) );                // desminuye el pozo del casino

                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($" ¡Ganaste! (+${jugador.modoElegido.getPorcentGana(jugador.montoApostado)}) ");
                    Console.ResetColor();
                }
                else
                {
                    double montoTotalPerdido = jugador.modoElegido.perdio(jugador.montoApostado);
                    jugador.setBilletera(montoTotalPerdido);      // actualiza la billetera del jugador
                    Casino.setApuesta(jugador.modoElegido.getPorcentPierde(jugador.montoApostado) );
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write($" Perdiste (-${jugador.modoElegido.getPorcentPierde(jugador.montoApostado) + jugador.montoApostado}) ");
                    Console.ResetColor();
                }

                Console.WriteLine($"  Saldo: ${jugador.getBilletera()} - Dado: {jugador.dadoElegido} - Apuesta: ${jugador.montoApostado} - Modo: {jugador.modoElegido.getName()}");
                Console.WriteLine("Pozo casino: $" + Casino.getPozo());
            }
        }


        private static void lanzarDados()
        {
            resultDado1 = dado1.getNumero;    // se guarda el numero random
            resultDado2 = dado2.getNumero;    // se guarda el numero random

            Console.WriteLine();
            Console.WriteLine("\nResultados: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\t{resultDado1} - {resultDado2}\n");
            Console.ResetColor();

        }

    }
}
