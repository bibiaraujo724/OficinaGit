using System;

class Programa
{
    static void Main()
    {
        Console.Write("\n Digite um número : ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.Write("\n Digite outro número : ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num * num2;

        if(resultado == 0) { Console.WriteLine("Número Inválido"); }
        if (resultado == 1) { Console.WriteLine("Número Inválido"); }
        if (resultado == 2) { Console.WriteLine("Número Inválido"); }
        if (resultado == 3) { Console.WriteLine("Número Inválido"); }

        Console.WriteLine($"\n O resultado dessa multiplicação é : {resultado} ");

        Console.ReadKey();
    }
}
