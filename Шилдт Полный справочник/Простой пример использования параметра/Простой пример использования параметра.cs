// Простой пример использования параметра.
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
}
class ParmDemo
{
    public static void Main()
    {
        ChkNum ob = new ChkNum();
        for (int i = 1; i < 10; i++)
            if (ob.isPrime(i)) Console.WriteLine(i +
             " простое число.");
            else Console.WriteLine(i + " не простое число.");
    }
}