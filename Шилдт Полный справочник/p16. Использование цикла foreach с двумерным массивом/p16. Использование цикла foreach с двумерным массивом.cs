// Использование цикла foreach с двумерным массивом.
using System;
class ForeachDemo2
{
    public static void Main()
    {
        int sum = 0;
        int[,] nums = new int[3, 5];
        // Присваиваем элементам массива nums значения.
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
                nums[i, j] = (i + 1) * (j + 1);
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