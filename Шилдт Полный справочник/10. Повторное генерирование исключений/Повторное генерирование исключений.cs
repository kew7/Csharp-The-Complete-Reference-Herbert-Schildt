// Повторное генерирование исключения.
using System;

class Rethrow
{
    public static void genException()
    {
        // Здесь массив numer длиннее массива denom.
        int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
        int[] denom = { 2, 0, 4, 4, 0, 8 };
        for (int i = 0; i < numer.Length; i++)
        {
            try
            {
                Console.WriteLine(numer[i] + " / " +
                denom[i] + " равно " + numer[i] / denom[i]);
            }
            catch (DivideByZeroException)
            {
                // Перехватываем исключение.
                Console.WriteLine("Делить на нуль нельзя!");
            }
            catch (IndexOutOfRangeException)
            {
                // Перехватываем исключение.
                Console.WriteLine(
                "Нет соответствующего элемента.");
                throw; // Генерируем исключение повторно.
            }
        }
    }
}

class RethrowDemo
{
    public static void Main()
    {
        try
        {
            Rethrow.genException();
        }
        catch (IndexOutOfRangeException)
        {
            // Перехватываем повторно
            // сгенерированное исключение.
            Console.WriteLine("Неисправимая ошибка — " +
            "программа завершена.");
        }
    }
}