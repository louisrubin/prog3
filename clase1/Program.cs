using MiProyecto; 
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Console.Write("ingrese mes: ");
int numIngr = int.Parse(Console.ReadLine());
Console.WriteLine("-------------");
*/

// PROGRAMA PARA OBTENER EL FACTORIAL DE UN NUMERO INGRESADO POR CONSOLA


int factorial(int num)
{
    if (num == 1)
    {
        return num;
    }
    return num * factorial(num - 1);
}

int tablaMult(int num, int mult = 1)
{
    //int mult = num2;
    if (mult == 11)
    {
        return mult;
    }
    Console.WriteLine($"{num}x{mult} = {num * mult}");

    return tablaMult(num, mult + 1);
} 

//tablaMult(numIngr);

void operacBasicas()
{
    Console.WriteLine("-------------------");
    Console.Write("ingrese 1er num: ");
    int numIngr = int.Parse(Console.ReadLine());
    Console.WriteLine("-------------------");

    Console.Write("ingrese 2do num: ");
    int numIngr2 = int.Parse(Console.ReadLine());
    Console.WriteLine("-------------------");

    Console.WriteLine($"SUMA: {numIngr}+{numIngr2}={numIngr + numIngr2}\n" +
        $"RESTA: {numIngr}-{numIngr2}={numIngr - numIngr2}\n" +
        $"MULT: {numIngr}x{numIngr2}={numIngr * numIngr2}");

    Console.WriteLine($"DIV: {numIngr}/{numIngr2}={  (numIngr / (double)numIngr2)  }");

    // verifico si el divisor es cero
    if (numIngr2 != 0) Console.WriteLine($"DIV: {numIngr}/{numIngr2}={Math.Round(((double)numIngr / (double)numIngr2), 2)}");
    else Console.WriteLine("No se puede dividir por cero.");

}

// operacBasicas();

int mensaje(int x)
{
    int a = x + 2;
    Console.WriteLine("hola "+a);
    return a;
}

void probando()
{
    Object[] a = { 6553500000 };
    int[] arr = new int[] {1,2,3,4,5};

    switch (0)
    {
        case 0:
        case 1:
            Console.WriteLine("holaaaaaaaaaa");
            break;
    }

    // LLAMADA A UNA FUNCION DENTRO DEL 'ITERADOR' DEL for
    for (int i = 5, b = mensaje(i); i < 1; b+=3, i++)
    {
        Console.WriteLine("que tal " + i);
        if (b >= 6) Console.WriteLine(b);
        if (b >= 6) break;
    }
}
//probando();

EstructuraDecision estructuraDecision = new EstructuraDecision();
estructuraDecision.program();
