// Пример перегрузки операторов.
using System;
// Класс трехмерных координат.
class ThreeD
{
    int x, y, z; // 3-х-мерные координаты.
    public ThreeD()
    {
        x = y = z = 0;
    }
    public ThreeD(int i, int j, int k)
    {
        x = i;
        y = j;
        z = k;
    }
    // Перегрузка бинарного оператора "+".
    public static ThreeD operator +(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        /* Суммирование координат двух точек
        и возврат результата. */
        result.x = op1.x + op2.x; // Эти операторы выполняют
        result.y = op1.y + op2.y; // целочисленное сложение.
        result.z = op1.z + op2.z;
        return result;
    }
    // Перегрузка бинарного оператора "-".
    public static ThreeD operator -(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        /* Обратите внимание на порядок операндов.
        op1 - левый операнд, op2 - правый. */
        result.x = op1.x - op2.x; // Эти операторы выполняют
        result.y = op1.y - op2.y; // целочисленное вычитание.
        result.z = op1.z - op2.z;
        return result;
    }
    // Отображаем координаты X, Y, Z.
    public void show()
    {
        Console.WriteLine(x + ", " + y + ", " + z);
    }
}

class ThreeDDemo
{
    public static void Main()
    {
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD();
        Console.Write("Координаты точки a: ");
        a.show();
        Console.WriteLine();
        Console.Write("Координаты точки b: ");
        b.show();
        Console.WriteLine();
        c = a + b; // Складываем а и b.
        Console.Write("Результат сложения а + b: ");
        c.show();
        Console.WriteLine();
        c = a + b + c; // Складываем а, b и c.
        Console.Write("Результат сложения а + b + c: ");
        c.show();
        Console.WriteLine();
        c = c - a; // Вычитаем а из c.
        Console.Write("Результат вычитания c - a: ");
        c.show();
        Console.WriteLine();
        c = c - b; // Вычитаем b из c.
        Console.Write("Результат вычитания c - b: ");
        c.show();
        Console.WriteLine();
    }
}