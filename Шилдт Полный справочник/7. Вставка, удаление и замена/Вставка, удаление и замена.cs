// Вставка, замена и удаление строк.
using System;
class InsRepRevDemo
{
    public static void Main()
    {
        string str = "Это тест";
        Console.WriteLine("Исходная строка: " + str);
        // Вставляем строку.
        str = str.Insert(4, "простой ");
        Console.WriteLine(str);
        // Заменяем строку.
        str = str.Replace("простой", "сложный");
        Console.WriteLine(str);
        // Заменяем символы.
        str = str.Replace('т', 'X');
        Console.WriteLine(str);
        // Удаляем подстроку.
        str = str.Remove(4, 5);
        Console.WriteLine(str);
    }
}
