// Использование инструкции break в цикле foreach.
using System;
class ForeachDemo
{
    public static void Main()
    {
        int sum = 0;
        int[] nums = new int[10];
        // Присваиваем элементам массива nums значения.
        for (int i = 0; i < 10; i++)
            nums[i] = i;
        // Используем цикл foreach для отображения значений
        // элементов массива и их суммирования.
        foreach (int x in nums)
        {
            Console.WriteLine("Значение элемента равно: " + x);
            sum += x;
            if (x == 4) break; // Останов цикла, когда x равен 4.
        }
        Console.WriteLine("Сумма первых 5 элементов: " + sum);
    }
}