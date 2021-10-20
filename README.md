# quadratic-solver
A simple console application written for .Net 5 that solves quadratic equations, and outputs complex roots.

## About
There is a lot to consider when you write a quadratic equations solver. Here, for most cases, the following formula is used: 

`-(b + Math.Sign(b) * Complex.Sqrt(b * b - 4 * a * c)) / 2`[^1]

because the conventional formula suffers from critical disadvantages[^2].

## Footnotes
[^1]: [Roots of a quadratic function, Rosetta Code](http://rosettacode.org/wiki/Roots_of_a_quadratic_function#C.23)
[^2]: [Methods of Design-Oriented Analysis: The quadratic equation revisited, by R.D. Middlebrook](https://www.validlab.com/goldberg/paper.pdf)
