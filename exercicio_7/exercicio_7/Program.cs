using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i);

            if (i % 10 == 0)
            {
                Console.Write(" - MÚLTIPLO DE 10");
            }

            Console.WriteLine();
        }
    }
}
