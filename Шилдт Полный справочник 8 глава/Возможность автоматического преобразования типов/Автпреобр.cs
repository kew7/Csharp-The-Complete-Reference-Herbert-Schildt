/* Возможность автоматического преобразования типов может повлиять
на решение о перегрузке методов. */
using System;
class Overload2
{
    public void f(int x)
    {
        Console.WriteLine("Внутри метода f(int): " + x);
    }
    public void f(double x)
    {
        Console.WriteLine("Внутри метода f(double): " + x);
    }
}
class TypeConv
{
    public static void Main()
    {
        Overload2 ob = new Overload2();
        int i = 10;
        double d = 10.1;
        byte b = 99;
        short s = 10;
        float f = 11.5F;
        ob.f(i); // Вызов метода ob.f(int).
        ob.f(d); // Вызов метода ob.f(double).
        ob.f(b); // Вызов метода ob.f(int) — выполняется
        // преобразование типов.
        ob.f(s); // Вызов метода ob.f(int) — выполняется
        // преобразование типов.
        ob.f(f); // Вызов метода ob.f(double) — выполняется
        // преобразование типов.
    }
}

