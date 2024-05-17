// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Parcial_1;


//static void Main(string[] args)
//{
//    SistemaCorreo.EnviarCorreo();
//}

while (true)
{
    byte opc;
    Console.Write("[1] - Enviar Correo\n[2] - Eliminar Correo\n[3] - Salir\n --> ");
    byte.TryParse(Console.ReadLine(), out opc);


    if (opc == 1) SistemaCorreo.EnviarCorreo();
    if (opc == 2) SistemaCorreo.EliminarCorreo();
    if (opc == 3) break;


}

