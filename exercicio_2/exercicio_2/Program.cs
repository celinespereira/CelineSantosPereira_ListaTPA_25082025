using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número: \n");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: \n");
        int b = int.Parse(Console.ReadLine());

        for (int i = b; i >= a; i--)
        {
            if (i % 2 != 0) 
            { 
                Console.WriteLine(i); 
            }
        }
            
    }
}
