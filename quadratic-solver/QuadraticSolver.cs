using System;
using System.Numerics;

namespace quadratic_solver_ru
{
    public class QuadraticSolver
    {
        // Вся математика осуществляется в этом методе
        // Замечание: введение ноля для переменной a не допускается
        public static Solution Solve(double a, double b, double c, Solution _output)
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

        public class Solution
        {
            public Complex x1 { get; set; }
            public Complex x2 { get; set; }
        }

        public class InputData
        {
            public string userInput { get; set; }
            // Используется для цикла ввода, остаётся ложью пока TryParse не рабатывает
            public bool isParsed { get; set; }
            public double parsedInput { get; set; }
            public string paramName { get; set; }
        }

        public static void InputProcessor(InputData id, string paramName)
        {
            id.isParsed = false;
            id.paramName = paramName;
            while (!id.isParsed)
            {
                Console.Write($"Введите параметр {id.paramName}: ");
                id.userInput = Console.ReadLine();
                if (double.TryParse(id.userInput, out double parsed))
                {
                    id.parsedInput = parsed;
                    id.isParsed = true;
                }
                if (!id.isParsed)
                {
                    Console.WriteLine("Убедитесь, что вводите вещественное число!");
                }
            }
        }

        static void Main()
        {
            var nl = System.Environment.NewLine;
            // Используется для подстрочных цифр
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Шаблон game loop
            // done становится правдой и приложение закрывается, если пользователь нажимает q после решения уравнения
            bool done = false;
            while (!done)
            {
                Console.WriteLine($"Простой решатель квадратных уравнений приветствует вас.{nl}" +
                    $"Только вещественные числа принимаются для параметров  a, b и c.{nl}" +
                    $"Корни представляются в виде комплексных чисел: (вещественная часть, мнимая часть){nl}");
                InputData aIn = new();
                InputProcessor(aIn, "a");
                if (aIn.parsedInput == 0)
                {
                    Console.WriteLine($"Уравнения с параметром a равным нулю не являются квадратными!{nl}" +
                        $"Нажмите любую клавишу, чтобы продолжить.");
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
                Console.WriteLine($"{nl}Найдены корни:{nl}x₁={output.x1},{nl}x₂={output.x2}");
                Console.WriteLine($"{nl}Нажмите q, чтобы выйти или любую другую клавишу, чтобы продолжить.");
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
