// Демонстрация использования интерфейса,
// реализованного классом ByTwos.
using System;
class SeriesDemo
{
    public static void Main()
    {
        ByTwos ob = new ByTwos();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Следующее значение равно " + ob.getNext());
        Console.WriteLine("\nПереход в исходное состояние.");
        ob.reset();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Следующее значение равно " + ob.getNext());
        Console.WriteLine("\nНачинаем с числа 100.");
        ob.setStart(100);
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Следующее значение равно " + ob.getNext());
    }
}