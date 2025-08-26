using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int A1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int A2 = int.Parse(Console.ReadLine());

        int C = 0;

        for (int i = A1; i <= A2; i++)
        {
            if (i % 2 != 0)
            {
                C++;
            }
        }

        Console.WriteLine($"\nQuantidade de números ímpares entre {A1} e {A2}: {C}");
    }
}
