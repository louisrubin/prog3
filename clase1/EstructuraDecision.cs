/* 
 * Estructuras de decisión en C# (Grupal)
Objetivo: Comprender la aplicación de las estructuras de decisión.
Ejercicio:

Cree una aplicación de consola.
Solicite el ingreso de un texto y controle que no esté vacío.
Despliegue un menú que muestre 3 opciones (Texto en mayúscula, Texto en minúscula y Texto Original).
Capture la entrada con Console.Readkey y realice la opción solicitada.
 */
namespace MiProyecto
{
    class EstructuraDecision()
    {
        public void program()
        {
            Console.WriteLine("--------------------------------------");
            Console.Write("Ingrese Texto: ");
            string texto = Console.ReadLine();
            //string texto = "Buenos diAS MUNDO";
            Console.WriteLine("--------------------------------------");

            if (string.IsNullOrWhiteSpace(texto))  // control para saber si está vacio o solo hay Espacios
            {
                return;     // matar el programa
            }

            // MENU DE OPCIONES
            Console.Write("[CTRL + Insert]\t\t Texto en Mayúscula\n[Insert]\t\t Texto en miníscula\n[Supr]\t\t\t Texto original\n --> ");
            ConsoleKeyInfo key = Console.ReadKey();     // leer código ingresado

            /*Console.WriteLine(key.Key);
            Console.WriteLine(key.KeyChar);
            Console.WriteLine(key.Modifiers); */

            ConsoleModifiers modificadores = key.Modifiers;     // obtengo los modificadores del objeto ConsoleKeyInfo

            // CTRL + INSERT (si tiene bandera -> hasFlag  y la tecla ingresada --> ConsoleKey.Insert)
            if (modificadores.HasFlag(ConsoleModifiers.Control) && key.Key == ConsoleKey.Insert ) 
            {
                Console.WriteLine(texto.ToUpper());
            }

            // unicamente INSERT (ConsoleKey.Insert  y modificador es NONE --> ConsoleModifiers.None)
            if (key.Key == ConsoleKey.Insert && modificadores == ConsoleModifiers.None)
            {
                Console.WriteLine(texto.ToLower());
            }

            // unicamente SUPRIMIR (ConsoleKey.Delete  y modificador es NONE -->  ConsoleModifiers.None)
            if (key.Key == ConsoleKey.Delete && modificadores == ConsoleModifiers.None)   
            {
                Console.WriteLine(texto);
            }

            Console.WriteLine();
        }
    }
}
