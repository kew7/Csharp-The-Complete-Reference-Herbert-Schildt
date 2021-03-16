// Демонстрация использования оператора typeof.
using System;
using System.IO;

class UseTypeof
{
    public static void Main()
    {
        Type t = typeof(StreamReader);
        Console.WriteLine(t.FullName);
        if (t.IsClass) Console.WriteLine("Это класс.");
        if (t.IsAbstract) Console.WriteLine("Это абстрактный класс");
            else Console.WriteLine("Это конкретный класс.");
    }
}