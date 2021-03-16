// Пример использования implicit-оператора преобразования.
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
    // Перегружаем бинарный оператор "+".
    public static ThreeD operator +(ThreeD op1, ThreeD op2)
    {
        ThreeD result = new ThreeD();
        result.x = op1.x + op2.x;
        result.y = op1.y + op2.y;
        result.z = op1.z + op2.z;
        return result;
    }
    // Неявное преобразование из типа ThreeD в тип int.
    public static implicit operator int(ThreeD op1)
    {
        return op1.x * op1.y * op1.z;
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
        int i;
        Console.Write("Координаты точки a: ");
        a.show();
        Console.WriteLine();
        Console.Write("Координаты точки b: ");
        b.show();
        Console.WriteLine();
        c = a + b; // Суммируем координаты точек а и b.
        Console.Write("Результат сложения а + b: ");
        c.show();
        Console.WriteLine();
        i = a; // Преобразуем в значение типа int.
        Console.WriteLine(
        "Результат присваивания i = a: " + i);
        Console.WriteLine();
        i = a * 2 - b; // Преобразуем в значение типа int.
        Console.WriteLine(
        "Результат вычисления выражения а * 2 - b: " + i);
        Console.WriteLine();
    }
}