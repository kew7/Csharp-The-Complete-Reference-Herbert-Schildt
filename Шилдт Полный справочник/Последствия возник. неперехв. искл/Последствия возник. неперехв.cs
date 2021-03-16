// Предоставим возможность обработать ошибку
// C#-системе динамического управления.
using System;
class NotHandled
{
    public static void Main()
    {
        int[] nums = new int[4];
        Console.WriteLine("Перед генерированием исключения.");
        // Генерируем исключение, связанное с попаданием
        // индекса вне диапазона.
        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
            Console.WriteLine("nums[{0} ] : {1}", i, nums[i]);
        }
    }
}