// Поиск строк.
using System;
class StringSearchDemo
{
    public static void Main()
    {
        string str = "C# обладает мощными средствами обработки строк.";
        int idx;
        Console.WriteLine("str: " + str);
        idx = str.IndexOf('с');
        Console.WriteLine("Индекс первого вхождения буквы 'с': " + idx);
        idx = str.LastIndexOf('с');
        Console.WriteLine("Индекс последнего вхождения буквы 'с': " + idx);
        idx = str.IndexOf("ми");
        Console.WriteLine("Индекс первого вхождения подстроки \"ми\": " + idx);
        idx = str.LastIndexOf("ми");
        Console.WriteLine("Индекс последнего вхождения подстроки \"ми\": " + idx);
        char[] chrs = { 'а', 'б', 'в' };
        idx = str.IndexOfAny(chrs);
        Console.WriteLine("Индекс первой из букв 'а', 'б' или 'в': " + idx);
        if (str.StartsWith("C# обладает"))
            Console.WriteLine("str начинается с подстроки \"C# обладает\"");
        if (str.EndsWith("строк."))
            Console.WriteLine("str оканчивается подстрокой \"строк.\"");
    }
}
