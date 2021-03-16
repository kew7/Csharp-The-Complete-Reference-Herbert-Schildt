// Демонстрация порядка выполнения конструкторов.
using System;
// Создаем базовый класс.
class A
{
    public A()
    {
        Console.WriteLine("Создание класса A.");
    }
}
// Создаем класс, производный от A.
class B : A
{
    public B()
    {
        Console.WriteLine("Создание класса B.");
    }
}
// Создаем класс, производный от B.
class C : B
{
    public C()
    {
        Console.WriteLine("Создание класса C.");
    }
}
class OrderOfConstruction
{
    public static void Main()
    {
        C c = new C();
    }
}