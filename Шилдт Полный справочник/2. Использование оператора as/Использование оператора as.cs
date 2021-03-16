﻿// Использование оператора is для предотвращения
// неверной операции приведения типов.
using System;
class A { }
class В : A { }
class CheckCast
{
    public static void Main()
    {
        A a = new A();
        В b = new В();
        // Проверяем, можно ли объект а привести к типу В.
        if (a is В) // При положительном результате выполняем
                    // операцию приведения типов.
            b = (В)a;
        else //В противном случае операция приведения
             // типов опускается.
            b = null;
        if (b == null)
            Console.WriteLine("Операция приведения типов b = (В) а НЕ РАЗРЕШЕНА.");
        else
            Console.WriteLine("Операция приведения типов b = (В) а разрешена.");
    }
}
