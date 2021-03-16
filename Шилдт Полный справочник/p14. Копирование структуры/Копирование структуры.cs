// Копирование структуры.
using System;
// Определяем структуру.
struct MyStruct
{
    public int x;
}
// Демонстрируем присваивание структуры.
class StructAssignment
{
    public static void Main()
    {
        MyStruct a;
        MyStruct b;
        a.x = 10;
        b.x = 20;
        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
        a = b;
        b.x = 30;
        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
    }
}