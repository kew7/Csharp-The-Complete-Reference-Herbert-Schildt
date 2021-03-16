// Реализация теоремы Пифагора.
using System;

class Pythagorean
{
    public static void Main()
    {
        double s1; double s2;
        double hypot;
        string str;
        Console.WriteLine("Введите длину первого катета: ");
        str = Console.ReadLine();
        s1 = Double.Parse(str);
        Console.WriteLine("Введите длину второго катета: ");
        str = Console.ReadLine();
        s2 = Double.Parse(str);
        hypot = Math.Sqrt(s1 * s1 + s2 * s2);
        Console.WriteLine("Гипотенуза равна " + hypot);
    }
}