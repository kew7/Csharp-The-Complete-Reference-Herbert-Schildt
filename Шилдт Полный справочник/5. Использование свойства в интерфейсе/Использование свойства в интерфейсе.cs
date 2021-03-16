// Использование свойства в интерфейсе.
using System;
public interface ISeries
{
    // Интерфейсное свойство.
    int next
    {
        get; // Возвращает следующее число ряда.
        set; // Устанавливает следующее число ряда.
    }
}
// Реализация интерфейса ISeries.
class ByTwos : ISeries
{
    int val;
    public ByTwos()
    {
        val = 0;
    }
    // Получаем или устанавливаем значение ряда.
    public int next
    {
        get {
            val += 2;
            return val;
        }
        set
        {
            val = value;
        }
    }
}
// Демонстрируем использование интерфейсного свойства.
class SeriesDemo3
{
    public static void Main()
    {
        ByTwos ob = new ByTwos();
        // Получаем доступ к ряду через свойство.
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Следующее значение равно " + ob.next);
        Console.WriteLine("\nНачинаем с числа 21");
        ob.next = 21;
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Следующее значение равно " + ob.next);
    }
}