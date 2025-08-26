using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int A1 = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do número {A1}:\n");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{A1} x {i} = {A1 * i}");
        }
    }
}
