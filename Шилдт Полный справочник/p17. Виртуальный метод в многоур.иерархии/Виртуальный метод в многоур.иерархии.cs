/* Если производный класс не переопределяет виртуальный
метод в случае многоуровневой иерархии, будет выполнен
первый переопределенный метод, который обнаружится
при просмотре иерархической лестницы в направлении
снизу вверх. */
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
class Derived2 : Derived1
{
    // Этот класс не переопределяет метод who().
}
class Derived3 : Derived2
{
    // Этот класс также не переопределяет метод who().
}
class NoOverrideDemo2 {
    public static void Main()
    {
        Derived3 dOb = new Derived3();
        Base baseRef; // Ссылка на базовый класс.
        baseRef = dOb;
        baseRef.who(); // Вызывает метод who()
                       //из класса Derived1.
    }
}