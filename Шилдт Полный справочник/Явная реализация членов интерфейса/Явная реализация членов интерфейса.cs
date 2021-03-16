// Явная реализация члена интерфейса.
using System;
interface IEven
{
    bool isOdd(int x);
    bool isEven(int x);
}
class MyClass : IEven
{
    // Явная реализация.
    bool IEven.isOdd(int x)
    {
        if ((x % 2) != 0) return true;
        else return false;
    }
    // Обычная реализация.
    public bool isEven(int x)
    {
        IEven o = this; // Ссылка на вызывающий объект.
        return !o.isOdd(x);
    }
}
class Demo
{
    public static void Main()
    {
        MyClass ob = new MyClass();
        bool result;
        result = ob.isEven(4);
        if (result) Console.WriteLine("4 - четное число.");
        else Console.WriteLine("3 - нечетное число.");
        // result = ob.isOdd(); // Ошибка, член не виден.
    }
}