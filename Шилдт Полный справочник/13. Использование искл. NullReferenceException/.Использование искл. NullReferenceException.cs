// Использование исключения типа NullReferenceException.
using System;
class X
{
    int x;
    public X(int a)
    {
        x = a;
    }
    public int add(X o)
    {
        return x + o.x;
    }
}

// Демонстрируем исключение типа NullReferenceException.
class NREDemo
{
    public static void Main()
    {
        X p = new X(10);
        X q = null; // Переменной q явно присваивается
                    // значение null.
        int val;
        try
        {
            val = p.add(q); // Такой вызов метода
                            // приведет к исключению.
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("NullReferenceException!");
            Console.WriteLine("Исправляем ошибку...\n");
            // Исправляем ошибку.
            q = new X(9);
            val = p.add(q);
        }
        Console.WriteLine("Значение val равно {0}", val);
    }
}