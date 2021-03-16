// Демонстрация виртуального метода.
using System;
class Base
{
    // Создаем виртуальный метод в базовом классе.
    public virtual void who()
    {
        Console.WriteLine("Метод who() в классе Base.");
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
    // Снова переопределяем метод who()
    // в другом производном классе.
    public override void who()
    {
        Console.WriteLine("Метод who() в классе Derived2");
    }
}
class OverrideDemo
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
        baseRef.who();
    }
}