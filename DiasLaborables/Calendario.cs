using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasLaborables
{
    static class Calendario
    {
        static void cargaFecha(out byte dia, out byte mes)
        {
            while (true)
            {
                Console.Write("Ingrese DIA: ");
                byte.TryParse(Console.ReadLine(), out dia);

                Console.Write("Ingrese MES: ");
                byte.TryParse(Console.ReadLine(), out mes);

                if (dia != 0 && mes != 0) break;
            }
        }

        public static int ObtenerDiasCalendario()
        {
            // obtener la cantidad de días que hay entre dos fechas
            byte dia1, mes1;
            byte dia2, mes2;

            Console.WriteLine("Fecha Inicial");
            cargaFecha(out dia1, out mes1);
            Console.WriteLine("\nFecha Final");
            cargaFecha(out dia2, out mes2);

            DateTime fechaInicial = new DateTime(2024, mes1, dia1);
            DateTime fechaFinal = new DateTime(2024, mes2, dia2);


            TimeSpan entreFechas = fechaFinal - fechaInicial;
            Console.WriteLine("\nTotal Dias: " + entreFechas.Days);

            return entreFechas.Days;
        }

        public static int ObtenerDiasCalendario(out DateTime fecha1, out DateTime fecha2)
        {
            // obtener la cantidad de días que hay entre dos fechas
            byte dia1, mes1;
            byte dia2, mes2;

            Console.WriteLine("Fecha Inicial");
            cargaFecha(out dia1, out mes1);
            Console.WriteLine("\nFecha Final");
            cargaFecha(out dia2, out mes2);

            fecha1 = new DateTime(2024, mes1, dia1);
            fecha2 = new DateTime(2024, mes2, dia2);

            TimeSpan entreFechas = fecha2 - fecha1;
            return entreFechas.Days;
        }

        static bool esDiaFeriado(DateTime fechaParam)
        {
            DateTime[] diasNoLaboral =
            {
                new DateTime(2024, 1,1),    // AÑO NUEVO
                new DateTime(2024, 3,24),    // DIA NACIONAL DE LA MEMORIA POR LA VERDAD Y LA JUSTICIA
                new DateTime(2024, 4,2),    // DIA DEL VETERANO Y LOS CAIDOS EN MALVINAS
                new DateTime(2024, 5,1),    // DIA DEL TRABAJADOR
                new DateTime(2024, 5,25),    // REVOLUCION DE MAYO
                new DateTime(2024, 6,20),    // PASO A LA INMORTALIDAD DEL GRAL M. BELGRANO
                new DateTime(2024, 7,9),    // DIA DE LA INDEPENDENCIA
                new DateTime(2024, 8,17),    // PASO A LA INMORTALIDAD DEL GRANL JOSE DE SAN MARTIN
                new DateTime(2024, 10,12),    // DIA RESPETO A LA DIVERSIDAD CULTURAL 
                new DateTime(2024, 12,8),    // DIA DE LA INMACULADA CONCEPCION DE MARIA
                new DateTime(2024, 12,25),    // NAVIDAD
            };

            foreach (var dia in diasNoLaboral)
            {
                if (dia == fechaParam)
                {
                    return true;    // es dia feriado
                }
            }
            return false;   // no es dia feriado
        }

        static bool esFinDeSemana(DateTime fechaParam)
        {
            if (fechaParam.DayOfWeek == DayOfWeek.Saturday || fechaParam.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;    // es fin de semana
            }
            return false;       // dia de semana
        }

        public static void ObtenerDiasLaborables()
        {
            // obtener la cantidad de días laborables entre dos fechas    

            byte dia1, mes1;
            byte dia2, mes2;

            DateTime fechaInicial;
            DateTime fechaFinal;

            int cantDias = ObtenerDiasCalendario(out fechaInicial, out fechaFinal);
            int contador = 0;
            //Console.WriteLine(cantDias);

            for (int i = 0; i < cantDias+1; i++)
            {
                if (!esDiaFeriado(fechaInicial) && !esFinDeSemana(fechaInicial))
                {
                    contador++;
                }
                fechaInicial = fechaInicial.AddDays(1);     // aumento un dia
            }
            Console.WriteLine("\nTotal dias laborables: " + contador);
        }

        public static void SumarDiasLaborables()
        {
            // obtener una fecha sumando una cantidad de dias a una fecha inicial    

            byte dia1, mes1;
            //byte dia2, mes2;

            byte cantDias;

            Console.WriteLine("Fecha Inicial");
            cargaFecha(out dia1, out mes1);
            Console.Write("Cantidad de Dias: ");
            byte.TryParse(Console.ReadLine(), out cantDias);

            DateTime fechaInicial = new DateTime(2024, mes1, dia1);

            byte contador = 0;
            while (true)
            {
                if ( ! esDiaFeriado(fechaInicial) && ! esFinDeSemana(fechaInicial) )
                {
                    contador++;
                }
                fechaInicial = fechaInicial.AddDays(1);     // aumento un dia

                if (contador == cantDias)
                {
                    fechaInicial = fechaInicial.AddDays(-1);
                    break;
                }
            }

            Console.WriteLine("\nUltimo Dia: "+ fechaInicial.ToString("dd/MM/yyyy"));

        }
    }
}
