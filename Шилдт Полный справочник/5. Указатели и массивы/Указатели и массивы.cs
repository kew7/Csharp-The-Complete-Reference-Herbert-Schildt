/* Имя массива без индекса образует указатель на начало
этого массива. */
using System;
class PtrArray
{
    unsafe public static void Main()
    {
        int[] nums = new int[10];
        fixed (int* p = &nums[0], p2 = nums)
        {
            if (p == p2)
                Console.WriteLine("Указатели p и p2 содержат один и тот же адрес.");
        }
    }
}
