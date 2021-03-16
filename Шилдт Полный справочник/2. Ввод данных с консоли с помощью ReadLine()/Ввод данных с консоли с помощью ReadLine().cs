// Ввод данных с консоли с помощью метода ReadLine().
using System;
class ReadString
{
    public static void Main()
    {
        string str;
        Console.WriteLine("Введите несколько символов.");
        str = Console.ReadLine();
        Console.WriteLine("Вы ввели: " + str);
    }
}