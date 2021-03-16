// Демонстрация использования свойства Length при
// работе с рваными массивами.
using System;
class Jagged
{
    public static void Main()
    {
        int[][] network_nodes = new int[4][];
        network_nodes[0] = new int[3];
        network_nodes[1] = new int[7];
        network_nodes[2] = new int[2];
        network_nodes[3] = new int[5];
        int i, j;
        // Создаем фиктивные данные по
        // использованию ЦП.
        for (i = 0; i < network_nodes.Length; i++)
            for (j = 0; j < network_nodes[i].Length; j++)
                network_nodes[i][j] = i * j + 70;
        Console.WriteLine("Общее количество сетевых узлов: " +
        network_nodes.Length + "\n");
        for (i = 0; i < network_nodes.Length; i++)
        {
            for (j = 0; j < network_nodes[i].Length; j++) {
                Console.Write("Использование ЦП на узле " + i +
                              " для ЦП " + j + ": ");
                Console.Write(network_nodes[i][j] + "% ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}