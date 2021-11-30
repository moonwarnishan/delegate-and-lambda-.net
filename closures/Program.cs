using System;

//closures
int CalculateSomething(int n)
{
    if (n == 0) return 0;
    var factor = 42;
    return factor * CalculateSomething(n-1);
}

Func<int, int> Calculator = CreateCalculator();
Console.WriteLine(Calculator(10));


Func<int, int> CreateCalculator()
{
    var factor = 42;
    return n => n * factor;
}