using System;
using System.Diagnostics;

MeasureTime(()=>CountInfinity());

Console.WriteLine($"the result is {MeasureTimeFunc(()=>CalculateSomeResult())}");

// delegate void angthing()= action
static void MeasureTime(Action a)
{
    var watch = Stopwatch.StartNew();
    a();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
}

static int MeasureTimeFunc(Func<int> f)
{
    var watch = Stopwatch.StartNew();
    var result = f();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
    return result;
}

static void CountInfinity()
{
    for (var i = 0; i < 1000000000; i++) ;
}
static int CalculateSomeResult()
{
    for (var i = 0; i < 1000000000; i++) ;
    return 42;
}