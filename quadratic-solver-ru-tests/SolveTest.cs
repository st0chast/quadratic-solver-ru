using static quadratic_solver_ru.QuadraticSolver;
using System.Numerics;
using Xunit;

namespace quadratic_solver_ru_tests
{
    public class SolveTest
    {
        [Fact]
        public void TestIntABC()
        {
            double a = 9;
            double b = 9;
            double c = 9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0.5, -0.8660254037844387);
            output.x2 = new Complex(-0.5, 0.8660254037844386);
            _output = Solve(a, b, c , _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntACZeroB()
        {
            double a = 9;
            double b = 0;
            double c = 9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(0, 1);
            output.x2 = new Complex(-0, -1);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntABZeroC()
        {
            double a = 9;
            double b = 9;
            double c = 0;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-1, -0);
            output.x2 = new Complex(-0, 0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntAZeroBC()
        {
            double a = 9;
            double b = 0;
            double c = 0;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0, 0);
            output.x2 = new Complex(0, -0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntABCNegA()
        {
            double a = -9;
            double b = 9;
            double c = 9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(1.618033988749895, 0);
            output.x2 = new Complex(-0.6180339887498948, 0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntABCNegB()
        {
            double a = 9;
            double b = -9;
            double c = 9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(0.5, 0.8660254037844387);
            output.x2 = new Complex(0.5, -0.8660254037844386);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntABCNegC()
        {
            double a = 9;
            double b = 9;
            double c = -9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-1.618033988749895, -0);
            output.x2 = new Complex(0.6180339887498948, -0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntACZeroBNegA()
        {
            double a = -9;
            double b = 0;
            double c = 9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(1, 0);
            output.x2 = new Complex(-1, -0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntACZeroBNegC()
        {
            double a = 9;
            double b = 0;
            double c = -9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(1, 0);
            output.x2 = new Complex(-1, -0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntABZeroCNegA()
        {
            double a = -9;
            double b = 9;
            double c = 0;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(1, 0);
            output.x2 = new Complex(-0, 0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntABZeroCNegB()
        {
            double a = 9;
            double b = -9;
            double c = 0;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(1, 0);
            output.x2 = new Complex(0, -0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestIntAZeroBCNegA()
        {
            double a = -9;
            double b = 0;
            double c = 0;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(0, 0);
            output.x2 = new Complex(-0, -0);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestDoubleAIntBC()
        {
            double a = 9.9;
            double b = 9;
            double c = 9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0.45454545454545453, -0.8381404052084444);
            output.x2 = new Complex(-0.45454545454545453, 0.8381404052084442);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestDoubleBIntAC()
        {
            double a = 9;
            double b = 9.9;
            double c = 9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0.55, -0.8351646544245033);
            output.x2 = new Complex(-0.5499999999999999, 0.8351646544245033);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestDoubleCIntAB()
        {
            double a = 9;
            double b = 9;
            double c = 9.9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0.5, -0.9219544457292889);
            output.x2 = new Complex(-0.5, 0.9219544457292888);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestDoubleABIntC()
        {
            double a = 9.9;
            double b = 9.9;
            double c = 9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0.5, -0.8118441408859888);
            output.x2 = new Complex(-0.5, 0.8118441408859887);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestDoubleACIntB()
        {
            double a = 9.9;
            double b = 9;
            double c = 9.9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0.45454545454545453, -0.8907235428302466);
            output.x2 = new Complex(-0.45454545454545453, 0.8907235428302466);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestDoubleBCIntA()
        {
            double a = 9;
            double b = 9.9;
            double c = 9.9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0.55, -0.8930285549745877);
            output.x2 = new Complex(-0.55, 0.8930285549745876);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }

        [Fact]
        public void TestDoubleABC()
        {
            double a = 9.9;
            double b = 9.9;
            double c = 9.9;
            Solution _output = new();
            Solution output = new();
            output.x1 = new Complex(-0.5, -0.8660254037844387);
            output.x2 = new Complex(-0.49999999999999994, 0.8660254037844386);
            _output = Solve(a, b, c, _output);
            Assert.Equal(output.x1, _output.x1);
            Assert.Equal(output.x2, _output.x2);
        }
        //TODO: Negative parameters of type double
        //TODO: Negative parameters of type int and double
    }
}
