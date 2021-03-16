// Демонстрация обработки исключений.
using System;
class ExcDemo1
{
    public static void Main()
    {
        int[] nums = new int[4];
        try
        {
            // Console.WriteLine("В феврале {0,10} или {1,10} дней.", 28, 29);
            Console.WriteLine("Перед генерированием исключения.");
            // Генерируем исключение, связанное с попаданием
            // индекса вне диапазона.
            for (int i = 0; i < 10; i++)
            // for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[ {0}] : {1}", i, nums[i]);
            }
            Console.WriteLine("Этот текст не отображается.");
        }
        catch (IndexOutOfRangeException)
        {
            // Перехватываем исключение-
            Console.WriteLine("Индекс вне диапазона!");
        }
        Console.WriteLine("После catch-инструкции.");
    }
}