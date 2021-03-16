// Использование модификатора доступа internal.
using System;

class InternalTest
{
    internal int x;
}

class InternalDemo
{
    public static void Main()
    {
        InternalTest ob = new InternalTest();
        ob.x = 10; // Доступ возможен: x — в том же файле.
        Console.WriteLine("Значение ob.x: " + ob.x);
    }
}