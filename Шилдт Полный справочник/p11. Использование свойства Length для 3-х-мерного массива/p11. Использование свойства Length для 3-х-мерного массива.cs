// Использование свойства Length для 3-х-мерного массива.
using System;
class LengthDemo3D
{
    public static void Main()
    {
        int[,,] nums = new int[10, 5, 6];
        Console.WriteLine("Длина массива равна " +
        nums.Length);
    }
}