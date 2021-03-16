// Демонстрация возможности сравнения указателей.
using System;
class PtrCompDemo
{
    unsafe public static void Main()
    {
        int[] nums = new int[11];
        int x;
        // Находим средний элемент массива.
        fixed (int* start = &nums[0])
        {
            fixed (int* end = &nums[nums.Length - 1])
            {
                for (x = 0; start + x <= end - x; x++) ;
            }
        }
        Console.WriteLine("Средний элемент массива имеет номер " + x);
    }
}
