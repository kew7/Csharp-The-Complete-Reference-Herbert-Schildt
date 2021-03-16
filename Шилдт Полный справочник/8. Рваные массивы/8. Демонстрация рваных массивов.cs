// Демонстрация рваных массивов.
using System;
class Jagged
{
    public static void Main()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        int i;
        // Сохраняем значения в первом массиве.
        for (i = 0; i < 4; i++)
            jagged[0][i] = i;
        // Сохраняем значения во втором массиве.
        for (i = 0; i < 3; i++)
            jagged[1][i] = i;
        // Сохраняем значения в третьем массиве.
        for (i = 0; i < 5; i++)
            jagged[2][i] = i;
        // Отображаем значения первого массива.
        for (i = 0; i < 4; i++)
            Console.Write(jagged[0][i] + " ");
        Console.WriteLine();
        // Отображаем значения второго массива.
        for (i = 0; i < 3; i++)
            Console.Write(jagged[1][i] + " ");
        Console.WriteLine();
        // Отображаем значения третьего массива.
        for (i = 0; i < 5; i++)
            Console.Write(jagged[2][i] + " ");
        Console.WriteLine();
    }
}