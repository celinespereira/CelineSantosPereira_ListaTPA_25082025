using System;

class Program
{
    static void Main()
    {
        double B2 = 0;
        int B1 = 0;

        while (B1 < 10)
        {
            Console.Write($"Digite a nota {B1 + 1}: ");
            double A1 = double.Parse(Console.ReadLine());

            if (A1 >= 0 && A1 <= 10)
            {
                B2 += A1;
                B1++;
            }
            else
            {
                Console.WriteLine("Nota inválida! Digite um valor entre 0 e 10.");
            }
        }

        double M = B2 / 10;
        Console.WriteLine($"\nA média das notas é: {M}");
    }
}
