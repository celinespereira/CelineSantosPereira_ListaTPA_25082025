using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o 1º número: ");
        int A1 = int.Parse(Console.ReadLine());

        for (int i = 2; i <= 15; i++)
        {
            Console.Write($"Digite o {i} número: ");
            int A2 = int.Parse(Console.ReadLine());
            if (A2 > A1) A1 = A2;
        }

        Console.WriteLine($"\nO maior número digitado foi: {A1}");
    }
}
