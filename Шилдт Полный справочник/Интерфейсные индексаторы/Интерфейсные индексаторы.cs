// Добавление в интерфейс индексатора.
using System;
public interface ISeries
{
    // Интерфейсное свойство.
    int next
    {
        get; // Возвращает следующее число ряда.
        set; // Устанавливает следующее число ряда.
    }
    // Интерфейсный индексатор.
    int this[int index]
    {
        get; // Возвращает заданный член ряда.
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
    // Получаем или устанавливаем значение с помощью
    // свойства.
    public int next
    {
        get
        {
            val += 2;
            return val;
        }
        set
        {
            val = value;
        }
    }
    // Получаем значение с помощью индексатора.
    public int this[int index]
    {
        get
        {
            val = 0;
            for (int i = 0; i < index; i++)
                val += 2;
            return val;
        }
    }
}

// Демонстрируем использование интерфейсного индексатора.
class SeriesDemo4
{
    public static void Main()
    {
        ByTwos ob = new ByTwos();
        // Получаем доступ к ряду посредством свойства.
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Следующее значение равно " + ob.next);
        Console.WriteLine("\nНaчинaeм с числа 21");
        ob.next = 21;
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Следующее значение равно " + ob.next);
        Console.WriteLine("\nПереход в исходное состояние.");
        ob.next = 0;
        // Получаем доступ к ряду посредством индексатора.
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Следующее значение равно " + ob[i]);
    }
}