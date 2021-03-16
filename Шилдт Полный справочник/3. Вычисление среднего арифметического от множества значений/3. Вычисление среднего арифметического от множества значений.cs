// Вычисление среднего арифметического от
// множества значений.
using System;
class Average
{
    public static void Main()
    {
        int[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };
        int avg = 0;
        for (int i = 0; i < 10; i++)
            avg = avg + nums[i];
        avg /= 10;
        Console.WriteLine("Среднее: " + avg);
    }
}