// запись данных в потоки Console.Out и Console.Error.
using System;
class ErrOut
{
    public static void Main()
    {
        int a = 10, b = 0;
        int result;
        Console.Out.WriteLine("Деление на нуль сгенерирует исключение.");
        try
        {
            result = a / b; // Генерируем исключение.
        }
        catch (DivideByZeroException exc)
        {
            Console.Error.WriteLine(exc.Message);
        }
    }
}