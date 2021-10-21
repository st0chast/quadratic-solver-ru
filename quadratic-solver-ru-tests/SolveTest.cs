using static quadratic_solver_ru.QuadraticSolver;
using System.Numerics;
using Xunit;

namespace quadratic_solver_ru_tests
{
    public class SolveTest
    {
        [Fact]
        public void Test1()
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
    }
}
