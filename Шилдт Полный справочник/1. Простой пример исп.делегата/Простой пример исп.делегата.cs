// Простой пример использования делегата.

using System;

// Объявляем делегат.
delegate string strMod(string str);

class DelegateTest
{
    static string replaceSpaces(string a)
    {
        Console.WriteLine("Замена пробелов дефисами.");
        return a.Replace(' ', '-');
    }

    // Метод удаляет пробелы.
    static string removeSpaces(string a)
    {
        string temp = "";
        int i;
        Console.WriteLine("Удаление пробелов.");
        for (i = 0; i < a.Length; i++)
            if (a[i] != ' ') temp += a[i];
        return temp;
    }

    // Метод реверсирует строку.
    static string reverse(string a)
    {
        string temp = "";
        int i, j;
        Console.WriteLine("Реверсирование строки.");
        for (j = 0, i = a.Length - 1; i >= 0; i--, j++)
            temp += a[i];
        return temp;
    }

    public static void Main() // Основная функция программы
    {
        string str;

        // Создание делегата.
        strMod strOp = new strMod(replaceSpaces);
        // Вызываем методы посредством делегата.
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();

        strOp = new strMod(removeSpaces);
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();

        strOp = new strMod(reverse);
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
    }
}