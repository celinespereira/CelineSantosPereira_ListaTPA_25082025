using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: \n");
        int A1 = int.Parse(Console.ReadLine());

        long F = 1;

        for (int i = 1; i <= A1; i++)
        {
            F *= i;
        }

        Console.WriteLine($"\nO fatorial de {A1} é: {F}");
    }
}
