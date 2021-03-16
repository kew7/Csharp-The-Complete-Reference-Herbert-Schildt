// Использование членов класса Exception.
using System;
class ExcTest
{
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
        Console.WriteLine("Этот текст не отображается.");
    }
}

class UseExcept
{
    public static void Main()
    {
        try
        {
            ExcTest.genException();
        }
        catch (IndexOutOfRangeException exc)
        {
            // Перехватываем исключение.
            Console.WriteLine("Стандартное сообщение таково: ");
            Console.WriteLine(exc); // Вызов метода ToString().
            Console.WriteLine();
            Console.WriteLine("Свойство StackTrace: " + exc.StackTrace);
            Console.WriteLine();
            Console.WriteLine("Свойство Message: " + exc.Message);
            Console.WriteLine();
            Console.WriteLine("Свойство TargetSite: " + exc.TargetSite);
            Console.WriteLine();
        }
        Console.WriteLine("После catch-инструкции.");
    }
}