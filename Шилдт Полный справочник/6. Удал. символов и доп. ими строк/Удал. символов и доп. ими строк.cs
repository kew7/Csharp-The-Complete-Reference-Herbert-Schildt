// Демонстрация операций удаления символов
//и дополнения ими строк.
using System;
class TrimPadDemo
{
    public static void Main()
    {
        string str = "тест";
        Console.WriteLine("Исходная строка: " + str);
        // Дополнение пробелами с левой стороны строки.
        str = str.PadLeft(10);
        Console.WriteLine("|" + str + "|");
        // Дополнение пробелами с правой стороны строки.
        str = str.PadRight(20);
        Console.WriteLine("|" + str + "|");
        // Удаление начальных и концевых пробелов.
        str = str.Trim();
        Console.WriteLine("|" + str + "|");
        // "Левостороннее" дополнение строки символами "#".
        str = str.PadLeft(10, '#');
        Console.WriteLine("|" + str + " |");
        // "Правостороннее" дополнение строки символами "#".
        str = str.PadRight(20, '#');
        Console.WriteLine("|" + str + "|");
        // Удаление начальных и концевых символов "#".
        str = str.Trim('#');
        Console.WriteLine("|" + str + "|");
    }
}
