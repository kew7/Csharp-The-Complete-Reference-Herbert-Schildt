// Ссылка на базовый класс может указывать на
// объект производного класса.
using System;
class X
{
    public int a;
    public X(int i)
    {
        a = i;
    }
}
class Y : X
{
    public int b;
    public Y(int i, int j) : base(j)
    {
        b = i;
    }
}
class BaseRef
{
    public static void Main()
    {
        X x = new X(10);
        X x2;
        Y y = new Y(5, 6);
        x2 = x; // OK, обе переменные имеют одинаковый тип.
        Console.WriteLine("x2.a: " + x2.a);
        x2 = y; // Все равно ok, поскольку класс Y
                // выведен из класса X.
        Console.WriteLine("x2.a: " + x2.a);
        // Х-ссылки "знают" только о членах класса X.
        x2.a = 19; // ОК
        //x2.b = 27; // Ошибка, в классе X нет члена b.
    }
}