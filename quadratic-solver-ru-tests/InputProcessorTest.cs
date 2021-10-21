using static quadratic_solver_ru.QuadraticSolver;
using System;
using Xunit;
using System.IO;

namespace quadratic_solver_ru_tests
{
    public class InputProcessorTest
    {
        [Fact]
        public void TestUserInputInt()
        {
            InputData id = new();
            string paramName = "t";
            double parsed = 9;
            var input = new StringReader("9");
            Console.SetIn(input);
            InputProcessor(id, paramName);
            Assert.Equal(id.parsedInput, parsed);
        }

        [Fact]
        public void TestUserInputDouble()
        {
            InputData id = new();
            string paramName = "t";
            double parsed = 9.9;
            var input = new StringReader("9.9");
            Console.SetIn(input);
            InputProcessor(id, paramName);
            Assert.Equal(id.parsedInput, parsed);
        }

        [Fact]
        public void TestUserInputIntNeg()
        {
            InputData id = new();
            string paramName = "t";
            double parsed = -9;
            var input = new StringReader("-9");
            Console.SetIn(input);
            InputProcessor(id, paramName);
            Assert.Equal(id.parsedInput, parsed);
        }

        [Fact]
        public void TestUserInputDoubleNeg()
        {
            InputData id = new();
            string paramName = "t";
            double parsed = -9.9;
            var input = new StringReader("-9.9");
            Console.SetIn(input);
            InputProcessor(id, paramName);
            Assert.Equal(id.parsedInput, parsed);
        }

        [Fact]
        public void TestUserInputZero()
        {
            InputData id = new();
            string paramName = "t";
            double parsed = 0;
            var input = new StringReader("0");
            Console.SetIn(input);
            InputProcessor(id, paramName);
            Assert.Equal(id.parsedInput, parsed);
        }
    }
}
