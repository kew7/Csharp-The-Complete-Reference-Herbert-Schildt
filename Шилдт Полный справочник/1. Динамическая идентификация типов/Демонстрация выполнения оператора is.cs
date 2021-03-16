// Демонстрация выполнения оператора is.
using System;
class A { }
class B : A { }
class UseIs
{
    public static void Main()
    {
        A a = new A();
        B b = new B();
        if (a is A) Console.WriteLine("Объект а имеет тип А.");
        if (b is A)
            Console.WriteLine("Объект b совместим с типом А, " + "поскольку его тип выведен из типа А.");
        if (a is B)
            Console.WriteLine("Этот текст не будет отображен, " + "поскольку объект а не выведен из класса B.");
        if (b is B)
            Console.WriteLine("Объект b имеет тип B.");
        if (a is object) Console.WriteLine("a -- это объект.");
    }
}
