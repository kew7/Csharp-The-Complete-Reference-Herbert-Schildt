// использование цикла foreach.
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
        }
        Console.WriteLine("Сумма равна: " + sum);
    }
}