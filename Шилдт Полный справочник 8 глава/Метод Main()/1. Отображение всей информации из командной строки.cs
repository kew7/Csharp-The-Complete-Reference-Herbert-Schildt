// Отображение всей информации из командной строки.
using System;
class CLDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Командная строка содержит " +
        args.Length + " аргументов.");
        Console.WriteLine("Вот они: ");
        for (int i = 0; i < args.Length; i++)
            Console.WriteLine(args[i]);
        Console.ReadLine();
    }
}
