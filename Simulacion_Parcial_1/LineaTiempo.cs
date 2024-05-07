using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Parcial_1
{
    public static class LineaTiempo
    {
        // perdiodos de tiempo fijados
        static DateTime[,] periodosTiempo = {
            { new DateTime(2024, 2, 3, 16, 23, 54), new DateTime(2024, 3, 1, 18, 15, 31) },
            { new DateTime(2024, 5, 3, 15, 25 , 41), new DateTime(2024, 5, 5, 13, 13 , 56) },
            { new DateTime(2024, 2, 17, 13, 00, 00), new DateTime(2024, 3, 18, 01, 05, 48) },
            { new DateTime(2024, 3, 20, 13, 32, 12),  new DateTime(2024, 4, 25, 13, 5, 40)},
            { new DateTime(2024, 4, 11, 15, 25 , 41), new DateTime(2024, 5, 1, 13, 13 , 56) },
            { new DateTime(2024, 5, 6, 3, 12 , 40), DateTime.Now }
        };


        public static void toString(DateTime[,] uniones)
        {
            Console.WriteLine("Cantidad de uniones de tiempo: " + uniones.GetLength(0) + "\n");
            for (int x = 0; x < uniones.GetLength(0); x++)
            {
                Console.WriteLine($" {x+1}- ({uniones[x, 0]} - {uniones[x, 1]})");
            }
            Console.WriteLine("\n\n");
        }

        public static void reordenarMatriz()
        {
            DateTime[,] unionesTiempo = new DateTime[periodosTiempo.Length, 2];

            unionesTiempo[0, 0] = periodosTiempo[0, 0];
            unionesTiempo[0, 1] = periodosTiempo[0, 1];

            for (int j = 1; j < periodosTiempo.GetLength(0); j++)
            {
                if (periodosTiempo[j, 0] < periodosTiempo[j - 1, 0])
                {
                    /*
                     * VIENDO COMO ACTUA y reordena la matriz

                     act = new DateTime(2024, 5, 17), new DateTime(2024, 5, 18)

                { new DateTime(2024, 5, 17), new DateTime(2024, 5, 18) },
                { new DateTime(2024, 3, 20),  new DateTime(2024, 4, 25)},

                { new DateTime(2024, 2, 3, 16, 23, 54), new DateTime(2024, 3, 1, 18, 15, 31) },
                { new DateTime(2024, 2, 17, 13, 00, 00), new DateTime(2024, 3, 18, 01, 05, 48) },
                { new DateTime(2024, 3, 20, 13, 32, 12),  new DateTime(2024, 4, 25, 13, 5, 40)},
                { new DateTime(2024, 4, 11, 15, 25 , 41), new DateTime(2024, 5, 1, 13, 13 , 56) },
                { new DateTime(2024, 5, 3, 15, 25 , 41), new DateTime(2024, 5, 5, 13, 13 , 56) },
                { new DateTime(2024, 5, 6, 3, 12 , 40), DateTime.Now }

                    */
                    DateTime dt1 = periodosTiempo[j, 0];
                    DateTime dt2 = periodosTiempo[j, 1];

                    periodosTiempo[j, 0] = periodosTiempo[j - 1, 0];
                    periodosTiempo[j, 1] = periodosTiempo[j - 1, 1];

                    periodosTiempo[j - 1, 0] = dt1;
                    periodosTiempo[j - 1, 1] = dt2;

                    //unionesTiempo[0, 1] =

                    j=1;        // vuelve a iterar en esta vuelta
                }
                //x--;
            }
            //toString(periodosTiempo);
        }

        public static DateTime[,] Union()   // retorna una matriz
        {
            reordenarMatriz();
            DateTime[,] unionesTiempo = new DateTime[periodosTiempo.Length, 2];

            unionesTiempo[0,0] = periodosTiempo[0, 0];
            unionesTiempo[0, 1] = periodosTiempo[0, 1];

            DateTime[,] unionesReturn;      // matriz que será retornada

            int cantUniones = 0;
            for (int x = 1; x < periodosTiempo.GetLength(0); x++)
            {
                TimeSpan difColapso = periodosTiempo[x, 0] - unionesTiempo[cantUniones, 1];
                
                if (difColapso <= TimeSpan.Zero)
                {
                    // si es negativo los tiempos SI colapsan
                    unionesTiempo[cantUniones, 1] = periodosTiempo[x, 1];
                } else
                {
                    // si es positivo NO se colapsan
                    cantUniones++;
                    unionesTiempo[cantUniones, 0] = periodosTiempo[x, 0];
                    unionesTiempo[cantUniones, 1] = periodosTiempo[x, 1];
                }
            }

            // matriz nueva que será retornada
            unionesReturn = new DateTime[cantUniones + 1, 2];

            for (int x = 0; x < unionesTiempo.GetLength(0); x++)
            {
                if (unionesTiempo[x,0].Year != 0001)
                {
                    unionesReturn[x, 0] = unionesTiempo[x, 0];
                    unionesReturn[x, 1] = unionesTiempo[x, 1];
                }
            }

            //toString(periodosTiempo);
            return unionesReturn;

            // BORRADOR:

            //for (int x = 0; x < unionesTiempo.GetLength(0); x++)
            //{
            //    Console.WriteLine($"{unionesTiempo[x, 0]} - {unionesTiempo[x, 1]}");

            //}

            //for (int x = 4; x < 5; x++)      // periodosTiempo.GetLength(0)
            //{
            //    TimeSpan duracionActual = periodosTiempo[x, 1] - periodosTiempo[x, 0];
            //    TimeSpan duracionElemAnterior = unionesTiempo[x-1, 1] - unionesTiempo[x-1, 0];

            //    TimeSpan diferencia = duracionElemAnterior - duracionActual;

            //    Console.WriteLine($"{diferencia.Hours} - {diferencia.Minutes} - {diferencia.Seconds}");
            //    //if (duracion.Seconds > 0 || duracion.Minutes > 0 || duracion.Hours > 0)
            //    //{

            //    //}
            //}
        }

        //bool seColapsan(DateTime[,] fecha1, DateTime[,] fecha2)
        //{
        //    if (fecha1[0,0] )
        //    {
                
        //    }
        //}
    }
}


/* new DateTime[] = { new DateTime[](2024, 5, 25, 14, 43, 20), },


            new DateTime(2024, 5, 25, 13, 00, 00), new DateTime(2024, 5, 27, 00, 00, 00),

            new DateTime[](2024, 5, 25, 14, 43, 20),      // 25/5/24 - 14:43:20
            new DateTime(2024, 6, 18, 2, 55, 35),      // 18/6/24 - 02:55:35
            new DateTime(2024, 4, 22, 2, 55, 35),      // 23/5/24 - 14:43:20

*/