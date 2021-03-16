// Демонстрация использования оператора as.
using System;
class A { }
class B : A { }
class CheckCast
{
    public static void Main()
    {
        A a = new A();
        B b = new B();
        b = a as B; // Выполняем операцию приведения типов,
                    // если она возможна.
        if (b == null)
            Console.WriteLine("Операция приведения типов " + "b - (B) а НЕ РАЗРЕШЕНА.");
        else
            Console.WriteLine("Операция приведения типов b - (B) а разрешена.");
    }
}
