# quadratic-solver-ru
Простое консльное приложение, написанное для .Net 5, для решения квадратных уравнений, выводит корни в виде комплексных чисел.

## О программе
В большинстве случаев используется формула: 

`-(b + Math.Sign(b) * Complex.Sqrt(b * b - 4 * a * c)) / 2`[^1]

потому что классическая формула страдает от критических недостатков при использовании чисел с плавающей запятой[^2].

## For English speakers
Consider checking out a sister repo [quadratic-solver](https://github.com/st0chast/quadratic-solver)

## Примечания
[^1]: [Roots of a quadratic function, Rosetta Code](http://rosettacode.org/wiki/Roots_of_a_quadratic_function#C.23)
[^2]: [Methods of Design-Oriented Analysis: The quadratic equation revisited, by R.D. Middlebrook](https://authors.library.caltech.edu/63245/1/00683365.pdf)
