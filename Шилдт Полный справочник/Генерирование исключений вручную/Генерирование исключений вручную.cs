// Генерирование исключения вручную.
using System;
class ThrowDemo
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("До генерирования исключения.");
            throw new DivideByZeroException();
        }
        catch (DivideByZeroException)
        {
            // Перехватываем исключение.
            Console.WriteLine("Исключение перехвачено.");
        }
        Console.WriteLine("После try/catch-блока.");
    }
}