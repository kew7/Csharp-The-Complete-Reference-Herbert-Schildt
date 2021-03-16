// Обмен значениями двух аргументов.
using System;
class Swap
{
    // Этот метод меняет местами значения своих аргументов.
    public void swap(ref int a, ref int b)
    {
        int t;
        t = a;
        a = b;
        b = t;
    }
}
class SwapDemo
{
    public static void Main()
    {
        Swap ob = new Swap();
        int x = 10, y = 20;
        Console.WriteLine("x и y перед вызовом: " +
        x + " " + y);
        ob.swap(ref x, ref y);
        Console.WriteLine("x и y после вызова: " +
        x + " " + y);
    }
}