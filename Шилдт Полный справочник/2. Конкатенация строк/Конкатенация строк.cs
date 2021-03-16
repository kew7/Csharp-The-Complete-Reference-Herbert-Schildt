// Демонстрация использования метода Concat().
using System;
class ConcatDemo
{
    public static void Main()
    {
        string result = String.Concat(
        "Мы ", "тестируем ",
        "один ", "из ", "методов ",
        "конкатенации ", "класса ",
        "String.");
        Console.WriteLine("Результат 1: " + result);

        result = String.Concat("Привет ", 10, " ",
                                        20.0, " ",
                                        false, " ",
                                        23.45M);
        Console.WriteLine("Результат 2: " + result);
    }
}
