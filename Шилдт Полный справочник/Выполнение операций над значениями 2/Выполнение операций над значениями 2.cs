/* Перегрузка оператора "+" для следующих вариантов:
объект + объект, объект + int-значение и int-значение + объект. */
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
    // Перегружаем бинарный оператор "+" для варианта
    // "объект + объект".
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
    // Перегружаем бинарный оператор "+" для варианта
    // "объект + int-значение".
    public static ThreeD operator +(ThreeD op1, int op2)
    {
        ThreeD result = new ThreeD();
        result.x = op1.x + op2;
        result.y = op1.y + op2;
        result.z = op1.z + op2;
        return result;
    }
    // Перегружаем бинарный оператор "+" для варианта
    // "int-значение + объект".
    public static ThreeD operator +(int op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        result.x = op2.x + op1;
        result.y = op2.y + op1;
        result.z = op2.z + op1;
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
        c = a + b; // объект + объект
        Console.Write("Результат сложения а + b: ");
        c.show();
        Console.WriteLine();
        c = b + 10; // объект + int-значение
        Console.Write("Результат сложения b + 10: ");
        c.show();
        Console.WriteLine();
        c = 15 + b; // int-значение + объект
        Console.Write("Результат сложения 15 + b: ");
        c.show();
        Console.WriteLine();
    }
}