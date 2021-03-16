// Эта программа работать не будет!
using System;
class ExcTypeMismatch
{
    public static void Main()
    {
        int[] nums = new int[4];
        try
        {
            Console.WriteLine("Перед генерированием исключения.");
            // Генерируем исключение, связанное с попаданием
            // индекса вне диапазона.
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
            }
            Console.WriteLine("Этот текст не отображается.");
        }
        /* Если в catch-инструкции указан тип исключения
        DivideByZeroException, то с ее помощью невозможно
        перехватить ошибку нарушения границ массива. */
        catch (DivideByZeroException)
        {
            // Перехватываем исключение.
            Console.WriteLine("Индекс вне границ диапазона!");
        }
        Console.WriteLine("После catch-инструкции.");
    }
}