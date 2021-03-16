// Перегрузка операторов "<" и ">".
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
    // Перегрузка оператора "<".
    public static bool operator <(ThreeD op1, ThreeD op2)
    {
        if ((op1.x < op2.x) && (op1.y < op2.y) &&
        (op1.z < op2.z))
            return true;
        else
            return false;
    }
    // Перегрузка оператора ">".
    public static bool operator >(ThreeD op1, ThreeD op2)
    {
        if ((op1.x > op2.x) && (op1.y > op2.y) &&
        (op1.z > op2.z))
            return true;
        else
            return false;
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
        ThreeD a = new ThreeD(5, 6, 7);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD(1, 2, 3);
        Console.Write("Координаты точки a: ");
        a.show();
        Console.Write("Координаты точки b: ");
        b.show();
        Console.Write("Координаты точки c: ");
        c.show();
        Console.WriteLine();
        if (a > c) Console.WriteLine("a > c - ИСТИНА");
        if (a < c) Console.WriteLine("a < c - ИСТИНА");
        if (a > b) Console.WriteLine("a > b - ИСТИНА");
        if (a < b) Console.WriteLine("a < b - ИСТИНА");
        Console.WriteLine();
    }
}