// Демонстрация выхода за границу массива.
using System;
class ArrayErr
{
    public static void Main()
    {
        int[] sample = new int[10];
        int i;
        // Организуем нарушение границы массива.
        for (i = 0; i < 100; i = i + 1)
            sample[i] = i;
    }
}