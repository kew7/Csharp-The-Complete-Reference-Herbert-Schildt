// Демонстрация использования перечисления.
using System;
class EnumDemo {
    enum apple
    {
        Jonathan, GoldenDel, RedDel, Winsap,
        Cortland, McIntosh
    };
    public static void Main()
    {
        string[] color = {
                        "красный",
                        "желтый",
                        "красный",
                        "красный",
                        "красный",
                        "красно-зеленый"
        };
        apple i; // Объявляем переменную перечислимого типа.
                 // Используем переменную i для обхода всех
                 // членов перечисления.
        for (i = apple.Jonathan; i <= apple.McIntosh; i++)
            Console.WriteLine(i + " имеет значение " + (int)i);
        Console.WriteLine();
        // Используем перечисление для индексации массива.
        for (i = apple.Jonathan; i <= apple.McIntosh; i++)
            Console.WriteLine("Цвет сорта " + i + " - " + color[(int)i]);
    }
}