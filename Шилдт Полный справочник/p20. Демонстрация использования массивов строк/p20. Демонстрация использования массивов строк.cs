// Демонстрация использования массивов строк.
using System;
class StringArrays
{
    public static void Main()
    {
        string[] str = { "Это", "очень", "простой", "тест." };
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
        Console.WriteLine("\n");
        // Изменяем строку.
        str[1] = "тоже";
        str[3] = "тест, не правда ли?";
        Console.WriteLine("Модифицированный массив: ");
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
    }
}