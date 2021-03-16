// Перегрузка большего числа операторов.
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
        result.x = op1.x + op2.x;
        result.y = op1.y + op2.y;
        result.z = op1.z + op2.z;
        return result;
    }
    // Перегрузка бинарного оператора "-".
    public static ThreeD operator -(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        /* Обратите внимание на порядок операндов.
        op1 - левый операнд, op2 - правый. */
        result.x = op1.x - op2.x;
        result.y = op1.y - op2.y;
        result.z = op1.z - op2.z;
        return result;
    }
    // Перегрузка унарного оператора "-".
    public static ThreeD operator -(ThreeD op)
    {
        ThreeD result = new ThreeD();
        result.x = -op.x;
        result.y = -op.y;
        result.z = -op.z;
        return result;
    }
    // Перегрузка унарного оператора "++".
    public static ThreeD operator ++(ThreeD op)
    {
        // Оператор "++" модифицирует аргумент.
        op.x++;
        op.y++;
        op.z++;
        return op;
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
        c = a + b; // Сложение а и b.
        Console.Write("Результат сложения а + b: ");
        c.show();
        Console.WriteLine();
        c = a + b + c; // Сложение a, b и c.
        Console.Write("Результат сложения а + b + c: ");
        c.show();
        Console.WriteLine();
        c = c - a; // Вычитание а из c.
        Console.Write("Результат вычитания c - a: ");
        c.show();
        Console.WriteLine();
        c = c - b; // Вычитание b из c.
        Console.Write("Результат вычитания c - b: ");
        c.show();
        Console.WriteLine();
        c = -a; // Присваивание -а объекту c.
        Console.Write("Результат присваивания -a: ");
        c.show();
        Console.WriteLine();
        a++; // Инкрементирование а.
        Console.Write("Результат инкрементирования a++: ");
        a.show();
        Console.WriteLine();
    }
   
}