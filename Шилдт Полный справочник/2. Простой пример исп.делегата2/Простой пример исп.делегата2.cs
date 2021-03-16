// Делегаты могут ссылаться также на методы экземпляров класса.

using System;

// Объявляем делегат.
delegate string strMod(string str);

class StringOps
{
    // Метод заменяет пробелы дефисами.
    public string replaceSpaces(string a)
    {
        Console.WriteLine("Замена пробелов дефисами.");
        return a.Replace(' ', '-');
    }
    // Метод удаляет пробелы.
    public string removeSpaces(string a)
    {
        string temp = "";
        int i;
        Console.WriteLine("Удаление пробелов.");
        for (i = 0; i < a.Length; i++)
            if (a[i] != ' ') temp += a[i];
        return temp;
    }
    // Метод реверсирует строку.
    public string reverse(string a)
    {
        string temp = "";
        int i, j;
        Console.WriteLine("Реверсирование строки.");
        for (j = 0, i = a.Length - 1; i >= 0; i--, j++)
            temp += a[i];
        return temp;
    }
}

class DelegateTest
{
    public static void Main()
    {
        string str;
        StringOps so = new StringOps(); // Создаем экземпляр
                                        // класса StringOps.
        // Создаем делегат.
        strMod strOp = new strMod(so.replaceSpaces);
        // Вызываем методы с использованием делегатов.
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();

        strOp = new strMod(so.removeSpaces);
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();

        strOp = new strMod(so.reverse);
        str = strOp("Это простой тест.");
        Console.WriteLine("Результирующая строка: " + str);
        Console.WriteLine();
    }
}
