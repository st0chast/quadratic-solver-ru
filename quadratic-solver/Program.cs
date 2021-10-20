using System;
using System.Numerics;

namespace QuadraticExploration
{
    class Program
    {
        static Solution Solve(double a, double b, double c, Solution _output)
        {
            if (b != 0)
            {
                var q = -(b + Math.Sign(b) * Complex.Sqrt(b * b - 4 * a * c)) / 2;
                _output.x1 = q / a;
                _output.x2 = c / q;
                return _output;
            }
            else
            {
                _output.x1 = Complex.Sqrt(-c / a);
                _output.x2 = -Complex.Sqrt(-c / a);
                return _output;
            }
        }

        private class Solution
        {
            public Complex x1 { get; set; }
            public Complex x2 { get; set; }
        }

        private class InputData
        {
            public string userInput { get; set; }
            public bool isParsed { get; set; }
            public double parsedInput { get; set; }
            public string paramName { get; set; }
        }

        private static void InputProcessor(InputData id, string paramName)
        {
            id.isParsed = false;
            id.paramName = paramName;
            while (!id.isParsed)
            {
                Console.WriteLine($"Enter parameter: {id.paramName}");
                id.userInput = Console.ReadLine();
                if (double.TryParse(id.userInput, out double parsed))
                {
                    id.parsedInput = parsed;
                    id.isParsed = true;
                }
                if (!id.isParsed)
                {
                    Console.WriteLine("Make sure you enter an integer!");
                }
            }
        }

        static void Main()
        {
            var nl = System.Environment.NewLine;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool done = false;
            while (!done)
            {
                Solution output = new();
                Console.WriteLine("Quadratic equation solver, tentative version");
                InputData aIn = new();
                InputProcessor(aIn, "a");
                if (aIn.parsedInput == 0)
                {
                    Console.WriteLine($"Equations with parameter a equal to zero are not quadratic!{nl}" +
                        $"Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                InputData bIn = new();
                InputProcessor(bIn, "b");
                InputData cIn = new();
                InputProcessor(cIn, "c");
                output = Solve(aIn.parsedInput, bIn.parsedInput, cIn.parsedInput, output);
                Console.WriteLine($"{nl}Roots found: x₁={output.x1}, x₂={output.x2}");
                Console.WriteLine($"{nl}Press q to quit or any other key to continue");
                char q = Console.ReadKey().KeyChar;
                Console.Clear();
                if (q == 'q')
                {
                    done = true;
                }
            }

        }
    }
}
