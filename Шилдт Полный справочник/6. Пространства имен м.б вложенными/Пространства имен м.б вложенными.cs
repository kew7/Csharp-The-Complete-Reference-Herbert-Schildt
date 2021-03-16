// Демонстрация вложенных пространств имен.
using System;
namespace NS1
{
    class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("Создание класса ClassA.");
        }
    }
    namespace NS2
    { // Вложенное пространство имен.
        class ClassB
        {
            public ClassB()
            {
                Console.WriteLine("Создание класса ClassB.");
            }
        }
    }
}
class NestedNSDemo
{
    public static void Main()
    {
        NS1.ClassA a = new NS1.ClassA();
        // NS2.ClassB b = new NS2.ClassB(); // Ошибка!!!
        // Пространство имен NS2 не находится в зоне видимости.
        NS1.NS2.ClassB b = new NS1.NS2.ClassB(); // Здесь все
                                                 // правильно.
    }
}