// Демонстрация использования одномерного массива.
using System;
class ArrayDemo
{
    public static void Main()
    {
        int[] sample = new int[10];
        int i;
        for (i = 0; i < 10; i = i + 1)
            sample[i] = i;
        for (i = 0; i < 10; i = i + 1)
            Console.WriteLine("sample[" + i + "]: " +
            sample[i]);
    }
}
