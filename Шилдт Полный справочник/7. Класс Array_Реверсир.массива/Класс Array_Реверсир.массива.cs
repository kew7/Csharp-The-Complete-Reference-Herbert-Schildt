// Реверсирование массива.
using System;
class ReverseDemo
{
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        // Отображаем исходный порядок.
        Console.Write("Исходный порядок: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();
        // Реверсируем весь массив.
        Array.Reverse(nums);
        // Отображаем обратный порядок.
        Console.Write("Обратный порядок: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();
        // Реверсируем часть массива.
        Array.Reverse(nums, 1, 3);
        // Отображаем порядок при частичном
        // реверсировании массива.
        Console.Write("После частичного реверсирования: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
