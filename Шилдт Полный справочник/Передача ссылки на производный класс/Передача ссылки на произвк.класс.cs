// Передача ссылки на производный класс
// ссылке на базовый класс.
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
    // Создаем объект, в котором ширина равна высоте.
    public TwoDShape(double x)
    {
        width = height = x;
    }
    // Создаем объект из объекта.
    public TwoDShape(TwoDShape ob)
    {
        width = ob.width;
        height = ob.height;
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
    // Конструктор по умолчанию.
    public Triangle()
    {
        style = "null";
    }
    // Конструктор класса Triangle.
    public Triangle(string s,
                    double w,
                    double h) : base(w, h) {
        style = s;
    }
    // Создаем равнобедренный треугольник.
    public Triangle(double x) : base(x)
    {
        style = "равнобедренный";
    }
    // Создаем объект из объекта.
    public Triangle(Triangle ob) : base(ob)
    {
        style = ob.style;
    }
    // Метод возвращает площадь треугольника.
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
class Shapes7
{
    public static void Main()
    {
        Triangle t1 = new Triangle("прямоугольный", 8.0, 12.0);
        // Создаем копию объекта t1.
        Triangle t2 = new Triangle(t1);
        Console.WriteLine("Информация о t1: ");
        t1.showStyle();
        t1.showDim();
        Console.WriteLine("Площадь равна " + t1.area());
        Console.WriteLine();
        Console.WriteLine("Информация о t2: ");
        t2.showStyle();
        t2.showDim();
        Console.WriteLine("Площадь равна " + t2.area());
    }
}