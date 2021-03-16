// Демонстрация пользовательских форматов представления
// даты и времени.
using System;
class CustomTimeAndDateFormatsDemo
{
    public static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine("Время: {0:hh:mm tt}", dt);
        Console.WriteLine(
        "Время в 24-часовом исчислении: {0:HH:mm}", dt);
        Console.WriteLine("Дата: {0:ddd МММ dd, yyyy}", dt);
        Console.WriteLine("Эра: {0:gg}", dt);
        Console.WriteLine("Время с секундами: " +
        "{0:HH:mm:ss tt}", dt);
        Console.WriteLine("Используем m для дня месяца: {0:m}",
        dt);
        Console.WriteLine("Используем m для минут: {0:%m}",
        dt);
    }
}
