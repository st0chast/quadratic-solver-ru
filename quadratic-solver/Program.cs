using System;
using System.Numerics;

namespace QuadraticExploration
{
    class Program
    {
        // All the maths happen in this method
        // Note: users can't provide zero as the value of parameter a
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
            // Used for the input loop, stays false while TryParse fails
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
                Console.Write($"Enter parameter {id.paramName}: ");
                id.userInput = Console.ReadLine();
                if (double.TryParse(id.userInput, out double parsed))
                {
                    id.parsedInput = parsed;
                    id.isParsed = true;
                }
                if (!id.isParsed)
                {
                    Console.WriteLine("Make sure you enter a real number!");
                }
            }
        }

        static void Main()
        {
            var nl = System.Environment.NewLine;
            // Used to output superscript and subscript numbers
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Game loop pattern
            // done is set to false and the application exits, if the user presses q after an equation is solved
            bool done = false;
            while (!done)
            {
                Console.WriteLine($"Welcome to this simple quadratic equation solver.{nl}" +
                    $"Only real numbers are accepted for parameters a, b, and c.{nl}" +
                    $"The roots are presented as complex numbers: (real part, imaginary part){nl}");
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
                Solution output = new();
                output = Solve(aIn.parsedInput, bIn.parsedInput, cIn.parsedInput, output);
                Console.WriteLine($"{nl}Roots found:{nl}x₁={output.x1},{nl}x₂={output.x2}");
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