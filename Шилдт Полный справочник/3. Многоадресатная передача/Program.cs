// Демонстрация использования многоадресатной передачи.
using System;

// Объявляем делегат.
delegate void strMod(ref string str);

class StringOps
{
    // Метод заменяет пробелы дефисами.
    static void replaceSpaces(ref string a)
    {
        Console.WriteLine("Замена пробелов дефисами.");
        a = a.Replace(' ', '-');
    }
    // Метод удаляет пробелы.
    static void removeSpaces(ref string a)
    {
        string temp = "";
        int i;
        Console.WriteLine("Удаление пробелов.");
        for (i = 0; i < a.Length; i++)
            if (a[i] != ' ') temp += a[i];
        a = temp;
    }
    // Метод реверсирует строку.
    static void reverse(ref string a)
    {
        string temp = "";
        int i, j;
        Console.WriteLine("Реверсирование строки.");
        for (j = 0, i = a.Length - 1; i >= 0; i--, j++)
            temp += a[i];
        a = temp;
    }

    public static void Main()
    {
        // Создаем экземпляры делегатов.
        strMod strOp;
        strMod replaceSp = new strMod(replaceSpaces);
        strMod removeSp = new strMod(removeSpaces);
        strMod reverseStr = new strMod(reverse);

        string str = "Это простой тест.";
        // Организация многоадресатной передачи,
        strOp = replaceSp;
        strOp += reverseStr;

        // Вызов делегата с многоадресатной передачей.
        strOp(ref str);
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();

        // Удаляем метод замены пробелов и
        // добавляем метод их удаления.
        strOp -= replaceSp;
        strOp += removeSp;
        str = "Это простой тест."; // Восстановление
                                   // исходной строки.
                                   // Вызов делегата с многоадресатной передачей.
        strOp(ref str);
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();
    }
}