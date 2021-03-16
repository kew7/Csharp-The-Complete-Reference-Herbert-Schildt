// Поиск значения в массиве с помощью цикла foreach.
using System;
class Search
{
    public static void Main()
    {
        int[] nums = new int[10];
        int val;
        bool found = false;
        // Присваиваем элементам массива nums значения.
        for (int i = 0; i < 10; i++)
            nums[i] = i;
        val = 5;
        // Используем цикл foreach для поиска в массиве nums
        // заданного значения.
        foreach (int x in nums)
        {
            if (x == val)
            {
                found = true; break;
            }
        }
        if (found)
            Console.WriteLine("Значение найдено!");
    }
}