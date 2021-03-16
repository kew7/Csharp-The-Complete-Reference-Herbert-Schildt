// Использование явной реализации для того, чтобы избежать
// неоднозначности.
using System;
interface IMyIF_A
{
    int meth(int x);
}
interface IMyIF_B
{
    int meth(int x);
}

// В классе MyClass реализованы оба интерфейса.
class MyClass : IMyIF_A, IMyIF_B
{
    // Явным образом реализуем два метода meth().
    int IMyIF_A.meth(int x)
    {
        return x + x;
    }
    int IMyIF_B.meth(int x)
    {
        return x * x;
    }
    // Вызываем метод meth() посредством ссылки на интерфейс.
    public int methA(int x)
    {
        IMyIF_A a_ob;
        a_ob = this;
        return a_ob.meth(x); // Имеется в виду
                             // интерфейс IMyIF_A.
    }
    public int methB(int x)
    {
        IMyIF_B b_ob;
        b_ob = this;
        return b_ob.meth(x); // Имеется в виду
                             // интерфейс IMyIF_B
    }
}

class FQIFNames
{
    public static void Main()
    {
        MyClass ob = new MyClass();
        Console.Write("Вызов метода IMyIF_A.meth(): ");
        Console.WriteLine(ob.methA(3));
        Console.Write("Вызов метода IMyIF_B.meth(): ");
        Console.WriteLine(ob.methB(3));
    }
}