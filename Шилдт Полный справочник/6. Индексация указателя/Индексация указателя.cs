// Индексирование указателя подобно массиву.
using System;
class PtrIndexDemo
{
    unsafe public static void Main()
    {
        int[] nums = new int[10];
        // Индексируем указатель.
        Console.WriteLine("Индексируем указатель подобно массиву.");
        fixed (int* p = nums)
        {
            for (int i = 0; i < 10; i++)
                p[i] = i; // Индексируем указатель подобно массиву.
            for (int i = 0; i < 10; i++)
                Console.WriteLine("p[{0}]: {1}     {2}", i, p[i], nums[i]);
        }
        // Используем арифметические операции над указателями.
        Console.WriteLine("\nИспользуем арифметические операции над указателями.");
        fixed (int* p = nums)
        {
            for (int i = 0; i < 10; i++)
                *(p + i) = i; // Используем арифметические
                              // операции над указателями.
            for (int i = 0; i < 10; i++)
                Console.WriteLine("*(p+{0}): {1}     {2}", i, *(p + i), nums[i]);
        }
    }
}
