// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("ingrese mes: ");
int numIngr = int.Parse(Console.ReadLine());
Console.WriteLine("-------------");

// PROGRAMA PARA OBTENER EL FACTORIAL DE UN NUMERO INGRESADO POR CONSOLA


int factorial(int num)
{
    if (num == 1)
    {
        return num;
    }
    return num * factorial(num - 1);
}
Console.Write(factorial(numIngr));