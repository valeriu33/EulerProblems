using System;

namespace EulerProblems
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("Input the problem number : ");
                if (int.TryParse(Console.ReadLine(), out var n))
                {
                    try
                    {
                        Console.WriteLine("Answer: " + GetProblem(n).Solve());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Didn't solved that problem yet");    
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine("-----------------------------------\n");
            }
        }

        private static IProblem GetProblem(int n)
        {
            var program = Type.GetType("EulerProblems.Problem" + n);
            return (IProblem) Activator.CreateInstance(program ?? throw new InvalidOperationException());
        }
    }
}