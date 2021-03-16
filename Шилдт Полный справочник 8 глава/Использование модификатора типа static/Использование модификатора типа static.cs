// Использование модификатора типа static.
using System;
class StaticDemo
{
    // Объявление статической переменной.
    public static int val = 100;
    // Объявление статического метода.
    public static int valDiv2()
    {
        return val / 2;
    }
}
class SDemo
{
    public static void Main()
    {
        Console.WriteLine(
            "Начальное значение переменной StaticDemo.val равно " + StaticDemo.val);
        StaticDemo.val = 8;
        Console.WriteLine(
             "Значение переменной StaticDemo.val равно " + StaticDemo.val);
        Console.WriteLine("StaticDemo.valDiv2(): " + StaticDemo.valDiv2());
    }
}