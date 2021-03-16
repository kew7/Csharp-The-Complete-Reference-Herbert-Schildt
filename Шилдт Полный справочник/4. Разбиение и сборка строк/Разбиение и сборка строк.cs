// Демонстрация разбиения и сборки строк.
using System;
class SplitAndJoinDemo
{
    public static void Main()
    {
        string str =
        "Какое слово ты скажешь, такое в ответ и услышишь.";
        char[] seps = { ' ', '.', ',', };
        // Разбиваем строку на части.
        string[] parts = str.Split(seps);
        Console.WriteLine("Результат разбиения строки на части: ");
        for (int i = 0; i < parts.Length; i++)
            Console.WriteLine(parts[i]);
        // Теперь собираем эти части в одну строку.
        string whole = String.Join(" | ", parts);
        Console.WriteLine("Результат сборки: ");
        Console.WriteLine(whole);
    }
}
