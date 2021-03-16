﻿/* Если виртуальный метод не переопределен
в производном классе, используется метод
базового класса. */
using System;
class Base
{
    // Создаем виртуальный метод в базовом классе.
    public virtual void who()
    {
        Console.WriteLine("Метод who() в классе Base");
    }
}
class Derived1 : Base
{
    // Переопределяем метод who() в производном классе.
    public override void who()
    {
        Console.WriteLine("Метод who() в классе Derived1");
    }
}
class Derived2 : Base
{
    // Этот класс не переопределяет метод who().
}
class NoOverrideDemo
{
    public static void Main()
    {
        Base baseOb = new Base();
        Derived1 dOb1 = new Derived1();
        Derived2 dOb2 = new Derived2();
        Base baseRef; // Ссылка на базовый класс.
        baseRef = baseOb;
        baseRef.who();
        baseRef = dOb1;
        baseRef.who();
        baseRef = dOb2;
        baseRef.who(); // Вызывает метод who() класса Base.
    }
}