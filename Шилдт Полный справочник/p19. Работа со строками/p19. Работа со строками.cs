// Демонстрация выполнения некоторых операций над строками.
using System;
class StrOps
{
    public static void Main()
    {
        string str1 =
        "В .NET-программировании без C# не обойтись.";
        string str2 = string.Copy(str1);
        string str3 = "C#-строки — могучая сила.";
        string strUp, strLow; int result, idx;
        Console.WriteLine("str1: " + str1);
        Console.WriteLine("Длина строки str1: " + str1.Length);
        // Создаем прописную и строчную версии строки str1.
        strLow = str1.ToLower();
        strUp = str1.ToUpper();
        Console.WriteLine("Строчная версия строки str1:\n " +
        strLow);
        Console.WriteLine("Прописная версия строки str1:\n " +
        strUp);
        Console.WriteLine();
        // Отображаем str1 в символьном режиме.
        Console.WriteLine("Отображаем str1 посимвольно.");
        for (int i = 0; i < str1.Length; i++)
            Console.Write(str1[i]);
        Console.WriteLine("\n");
        // Сравниваем строки.
        if (str1 == str2)
            Console.WriteLine("str1 == str2");
        else
            Console.WriteLine("str1 != str2");
        if (str1 == str3)
            Console.WriteLine("str1 == str3");
        else
            Console.WriteLine("str1 != str3");
        result = str1.CompareTo(str3);
        if (result == 0)
            Console.WriteLine("str1 и str3 равны.");
        else if (result < 0)
            Console.WriteLine("str1 меньше, чем str3");
        else
            Console.WriteLine("str1 больше, чем str3");
        Console.WriteLine();
        // Присваиваем str2 новую строку.
        str2 = "Один Два Три Один";
        // Поиск строк.
        idx = str2.IndexOf("Один");
        Console.WriteLine(
        "Индекс первого вхождения подстроки Один: " + idx);
        idx = str2.LastIndexOf("Один");
        Console.WriteLine(
        "Индекс последнего вхождения подстроки Один: " + idx);
    }
}