using System.Xml.Linq;
using AlgoritmoCesar;

// RUBIN AZAS M. Luis - 2024

string fraseCifrada = "kd wiqd géuúi tédbbúnq kdq wiqd iúígédíqsybyuqu";


//Cesar.Cifrar("un gran poder conlleva una gran responsabilidad", 21);

//if (fraseCifrada == cifrar("un gran poder conlleva una gran responsabilidad", 21))
//{
//    Console.WriteLine("son iguales");
//}


//                  MENU
while (true)
{
    byte opc;
    Console.Write("1- Descifrar\n2- Cifrar\n --> ");
    byte.TryParse(Console.ReadLine(), out opc);

    if (opc == 1)
    {
        descifrar();
        break;
    }
    if (opc == 2) 
    {
        byte claveIngresada;
        Console.Write("Ingrese frase: ");
        string frase = Console.ReadLine();
        Console.Write("Ingrese clave: ");
        byte.TryParse(Console.ReadLine(), out claveIngresada);

        Console.WriteLine("\nCifrado: " + Cesar.Cifrar(frase, claveIngresada));
        break;
    }
    Console.WriteLine();
}


void descifrar()
{
    byte clave = 3;

    while (true)
    {
        Cesar.Descifrar(fraseCifrada, clave);       // método estático Cesar.Descifrar

        Console.Write("\nMensaje correcto? (si/no): ");
        string resp = Console.ReadLine();
        Console.WriteLine();

        if (resp.ToLower().Equals("si"))
        {
            Console.WriteLine("La clave era: " + clave);
            break;
        }

        clave += 3;
    }
}

//string cifrar(string fraseToCifrar, byte clave)
//{
//    return Cesar.Cifrar(fraseToCifrar, clave);
//}