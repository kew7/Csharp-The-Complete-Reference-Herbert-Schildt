/* Исключение может сгенерировать один метод,
а перехватить его — другой. */
using System;
class ExcTest
{
    // Генерируем исключение.
    public static void genException()
    {
        int[] nums = new int[4];
        Console.WriteLine("Перед генерированием исключения.");
        // Генерируем исключение, связанное с попаданием
        // индекса вне диапазона.
        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
            Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
        }
        Console.WriteLine("Этот текст не будет отображаться.");
    }
}

/*Поскольку метод genException() вызывается из блока try, исключение, которое
он генерирует (и не перехватывает), перехватывается инструкцией catch в методе
Main(). Но если бы метод genException() перехватывал это исключение, оно бы
никогда не вернулось в метод Main().*/
class ExcDemo2
{
    public static void Main()
    {
        try
        {
            ExcTest.genException();
        }
        catch (IndexOutOfRangeException)
        {
            // Перехватываем исключение.
            Console.WriteLine("Индекс вне диапазона!");
        }
        Console.WriteLine("После catch-инструкции.");
    }
}