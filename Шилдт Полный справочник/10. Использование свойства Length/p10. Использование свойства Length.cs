// Использование свойства Length.
using System;
class LengthDemo
{
    public static void Main()
    {
        int[] nums = new int[10];
        Console.WriteLine("Длина массива nums равна " +
        nums.Length);
        // Используем Length для инициализации массива nums.
        for (int i = 0; i < nums.Length; i++)
            nums[i] = i * i;
        // Теперь используем Length для отображения nums.
        Console.Write("Содержимое массива nums: ");
        for (int i = 0; i < nums.Length; i++)
            Console.Write(nums[i] + " ");
        Console.WriteLine();
    }
}