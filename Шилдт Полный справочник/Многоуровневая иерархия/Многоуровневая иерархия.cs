/*Благодаря наследованию класс ColorTriangle может использовать ранее
определенные классы Triangle и TwoDShape, добавляя только ту информацию, которая
необходима для собственного (специального) применения. В этом и состоит ценность
наследования: оно позволяет использовать код многократно.
Этот пример иллюстрирует еще один важный момент: base всегда ссылается на
конструктор “ближайшего” производного класса. Так, в классе ColorTriangle ссылка
base вызывает конструктор, определенный в классе Triangle. В классе Triangle
ссылка base вызывает конструктор, определенный в классе TwoDShape. Если в иерархии
классов конструктору базового класса требуются параметры, все производные классы
должны передавать эти параметры, независимо от того, нужны ли эти параметры самому
производному классу.*/

// Многоуровневая иерархия.
using System;
class TwoDShape
{
    double pri_width; // Закрытый член.
    double pri_height; // Закрытый член.
    // Конструктор по умолчанию.
    public TwoDShape()
    {
        width = height = 0.0;
    }
    // Конструктор класса TwoDShape.
    public TwoDShape(double w, double h)
    {
        width = w;
        height = h;
    }
    // Конструктор, создающий объекты, у которых
    // ширина равна высоте.
    public TwoDShape(double x)
    {
        width = height = x;
    }
    // Свойства width и height.
    public double width
    {
        get { return pri_width; }
        set { pri_width = value; }
    }
    public double height
    {
        get { return pri_height; }
        set { pri_height = value; }
    }
    public void showDim()
    {
        Console.WriteLine("Ширина и высота равны " +
        width + " и " + height);
    }
}
// Класс треугольников, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    string style; // Закрытый член.
    /* Конструктор по умолчанию. Он вызывает конструктор
    по умолчании класса TwoDShape. */
    public Triangle()
    {
        style = "null";
    }
    // Конструктор с параметрами.
    public Triangle(string s, double w, double h) : base(w, h)
    {
        style = s;
    }
    // Создаем равнобедренный треугольник.
    public Triangle(double x) : base(x)
    {
        style = "равнобедренный";
    }
    // Метод возвращает значение площади треугольника.
    public double area()
    {
        return width * height / 2;
    }
    // Метод отображает тип треугольника.
    public void showStyle()
    {
        Console.WriteLine("Треугольник " + style);
    }
}
// Продолжаем иерархию классов треугольников.
class ColorTriangle : Triangle
{
    string color;
    public ColorTriangle(
    string c, string s,
    double w, double h) : base(s, w, h)
    {
        color = c;
    }
    // Метод отображает цвет треугольника.
    public void showColor()
    {
        Console.WriteLine("Цвет " + color);
    }
}
class Shapes6
{
    public static void Main()
    {
        ColorTriangle t1 =
        new ColorTriangle("синий", "прямоугольный",
        8.0, 12.0);
        ColorTriangle t2 =
        new ColorTriangle("красный", "равнобедренный",
        2.0, 2.0);
        Console.WriteLine("Информация о t1: ");
        t1.showStyle();
        t1.showDim();
        t1.showColor();
        Console.WriteLine("Площадь равна " + t1.area());
        Console.WriteLine();
        Console.WriteLine("Информация о t2: ");
        t2.showStyle();
        t2.showDim();
        t2.showColor();
        Console.WriteLine("Площадь равна " + t2.area());
    }
}