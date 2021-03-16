// Использование ключевых слов checked и unchecked.
using System;
class CheckedDemo
{
    public static void Main()
    {
        byte a, b;
        byte result;
        a = 127;
        b = 127;
        try
        {
            result = unchecked((byte)(a * b));
            Console.WriteLine("Unchecked-результат: " + result);
            result = checked((byte)(a * b)); // Эта инструкция
                                             // вызывает исключение.
            Console.WriteLine("Checked-реэультат: " +
            result); // Инструкция не будет
                     // выполнена.
        }
        catch (OverflowException exc)
        {
            // Перехватываем исключение.
            Console.WriteLine(exc);
        }
    }
}