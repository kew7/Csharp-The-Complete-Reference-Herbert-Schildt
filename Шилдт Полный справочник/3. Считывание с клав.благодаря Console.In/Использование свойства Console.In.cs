// Считывание строки с клавиатуры благодаря
// непосредственному использованию свойства Console.In.
using System;
class ReadChars2
{
    public static void Main()
    {
        string str;
        Console.WriteLine("Введите несколько символов.");
        str = Console.In.ReadLine();
        Console.WriteLine("Вы ввели: " + str);
    }
}