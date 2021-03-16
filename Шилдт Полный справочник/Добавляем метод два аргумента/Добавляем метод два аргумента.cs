// Добавляем метод, который принимает два аргумента.
using System;
class ChkNum
{
    // Метод возвращает true, если x - простое число.
    public bool isPrime(int x)
    {
        for (int i = 2; i < x / 2 + 1; i++)
            if ((x % i) == 0) return false;
        return true;
    }
    // Метод возвращает наименьший общий знаменатель.
    public int lcd(int a, int b)
    {
        int max;
        if (isPrime(a) | isPrime(b)) return 1;
        max = a < b ? a : b;
        for (int i = 2; i < max / 2 + 1; i++)
            if (((a % i) == 0) & ((b % i) == 0)) return i;
        return 1;
    }
}
class ParmDemo
{
    public static void Main()
    {
        ChkNum ob = new ChkNum();
        int a, b;
        for (int i = 1; i < 10; i++)
            if (ob.isPrime(i)) Console.WriteLine(i +
            " простое число.");
            else Console.WriteLine(i + " не простое число.");
        a = 7;
        b = 8;
        Console.WriteLine("Наименьший общий знаменатель для " +
        a + " и " + b + " равен " +
        ob.lcd(a, b));
        a = 100;
        b = 8;
        Console.WriteLine("Наименьший общий знаменатель для " +
        a + " и " + b + " равен " +
        ob.lcd(a, b));
        a = 100;
        b = 75;
        Console.WriteLine("Наименьший общий знаменатель для " +
        a + " и " + b + " равен " +
        ob.lcd(a, b));
    }
}