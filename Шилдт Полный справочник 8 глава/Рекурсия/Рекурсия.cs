// Простой пример рекурсии.
using System;
class Factorial
{
    // Это рекурсивный метод.
    public int factR(int n)
    {
        int result;
        Console.Write("Вызов n=" + n+" ");
        if (n == 1) {Console.WriteLine(); return 1;}
        result = factR(n - 1) * n;   
        Console.WriteLine("Результат =" + result);
        return result;
    }
    // А это его итеративный эквивалент.
    public int factI(int n)
    {
        int t, result;
        result = 1;
        for (t = 1; t <= n; t++)
            result *= t;
        return result;
    }
}
class Recursion
{
    public static void Main()
    {
        Factorial f = new Factorial();
        Console.WriteLine(
        "Факториалы, вычисленные с " +
        "использованием рекурсивного метода.");
//        Console.WriteLine("Факториал числа 3 равен " +
//        f.factR(3));
        Console.WriteLine("Факториал числа 4 равен " +
        f.factR(4));
        Console.WriteLine("Факториал числа 5 равен " +
        f.factR(5));
        Console.WriteLine();
        Console.WriteLine(
        "Факториалы, вычисленные с " +
        "использованием итеративного метода.");
        Console.WriteLine("Факториал числа 3 равен " +
        f.factI(3));
        Console.WriteLine("Факториал числа 4 равен " +
        f.factI(4));
        Console.WriteLine("Факториал числа 5 равен " +
        f.factI(5));
    }
}