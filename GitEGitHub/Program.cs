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

        Console.WriteLine($"\n O resultado dessa multiplicação é : {resultado} ");

        Console.ReadKey();
    }
}
