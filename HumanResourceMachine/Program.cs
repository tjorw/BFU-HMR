using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace HumanResourceMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                start(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
                //Skriv dina instruktioner här.

                start(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

        }




















        static void start(params int[] inSequence)
        {
            IN = new Stack<int>(inSequence);
        }

        static void stop(params int[] rightSequence)
        {
            if (rightSequence.Length != OUT.Count)
            {
                throw new Exception($"FEL! OUT innehåller {OUT.Count} saker och rätt svar innehåller {rightSequence.Length}.");
            }

            for (var index = 0; index < rightSequence.Length; index++)
            {
                if (rightSequence[index] != OUT[index])
                {
                    throw new Exception($"FEL på position {index}! OUT innehåller {rightSequence[index]}  och rätt svar innehåller {OUT[index]}.");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PROGRAMMET GJORDE RÄTT! BRA JOBBAT!");
            Console.ResetColor();
        }

        static Stack<int> IN = new Stack<int>();

        static List<int> OUT = new List<int>();

        static int? holding = null;

        static void inbox()
        {
            if (IN.Count == 0)
            {
                throw new Exception("Det finns inga fler saker i IN");
            }

            holding = IN.Pop();

            Console.WriteLine($"Hämtar {holding.Value}");
        }

        static void outbox()
        {
            if (!holding.HasValue)
            {
                throw new Exception("Du måste hämta något från IN");
            }

            OUT.Add(holding.Value);

            Console.WriteLine($"Leverar {holding.Value}");
        }

    }
}
