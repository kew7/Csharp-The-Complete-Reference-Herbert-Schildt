// Сортировка массива и поиск в кем заданного значения.
using System;
class SortDemo
{
    public static void Main()
    {
        int[] nums = { 5, 4, 6, 3, 14, 9, 8, 17, 1, 24, -1, 0 };
        // Отображаем исходный порядок следования
        // элементов в массиве.
        Console.Write("Исходный порядок: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();
        // Сортируем массив.
        Array.Sort(nums);
        // Отображаем отсортированный массив.
        Console.Write("Порядок после сортировки: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();
        // Выполняем поиск числа 14.
        int idx = Array.BinarySearch(nums, 14);
        Console.WriteLine("Индекс значения 14 равен " + idx);
    }
}
