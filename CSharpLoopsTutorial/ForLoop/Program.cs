using System;

namespace ForLoop
{
    // Link para o tutorial: https://youtu.be/oO0GXIIE56U?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=530

    internal class Program
    {
        // Este método mostra como usar um "for loop" para contar de 0 até 9
        static void LoopFor10Loop()
        {
            const int maxCount = 10;

            // Começa em 0 e vai até 9 (porque x < 10)
            for (int x = 0; x < maxCount; x++)
            {
                Console.WriteLine($"The value of 'x' is equal to {x}");
            }
        }
        static void NestedForLoop()
        {
            const int maxParentForLoopCount = 10;
            const int maxChildForLoopCount = 5;

            for (int x = 0;x < maxParentForLoopCount; x++)
            {
                Console.Write($"{x} ");
                for (int y = 0;y < maxChildForLoopCount;y++)
                {
                Console.Write($"{y} ");
                }
                Console.WriteLine();
            }

        }
       
        // Este é o ponto de entrada do programa
        static void Main(string[] args)
        {
            LoopFor10Loop(); // Chama o método que faz o loop

            Console.ReadKey(); // Espera que o utilizador pressione uma tecla
            NestedForLoop();
            Console.ReadKey ();
        }
    }
}