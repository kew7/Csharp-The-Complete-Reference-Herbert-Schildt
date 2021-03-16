// Использование метода Substring().
using System;
class SubStr
{
    public static void Main()
    {
        string orgstr = "C# упрощает работу со строками.";
        // Создание подстроки.
        string substr = orgstr.Substring(4, 14);
        Console.WriteLine("orgstr: " + orgstr);
        Console.WriteLine("substr: " + substr);
    }
}