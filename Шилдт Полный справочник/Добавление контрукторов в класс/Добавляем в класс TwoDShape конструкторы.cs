// Добавляем в класс TwoDShape конструкторы.
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
    // Конструктор класса TwoDShape с параметрами.
    public TwoDShape(double w, double h)
    {
        width = w;
        height = h;
    }
    // Создаем объект, у которого ширина равна высоте.
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
// Класс треугольников, производный от TwoDShape.
class Triangle : TwoDShape
{
    string style; // Закрытый член.

    /* Конструктор по умолчанию. Он автоматически вызывает
    конструктор по умолчанию класса TwoDShape. */
    public Triangle()
    {
        style = "null";
    }
    // Конструктор, который принимает три аргумента.
    public Triangle(string s, double w, double h) : base(w, h)
    {
        style = s;
    }
    // Создаем равнобедренный треугольник.
    public Triangle(double x) : base(x)
    {
        style = "равнобедренный";
    }
    // Метод возвращает площадь треугольника.
    public double area()
    {
        return width * height / 2;
    }
    // Отображаем тип треугольника.
    public void showStyle()
    {
        Console.WriteLine("Треугольник " + style);
    }
}
class Shapes5
{
    public static void Main()
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);
        Triangle t3 = new Triangle(4.0);
        t1 = t2;
        Console.WriteLine("Информация о t1: ");
        t1.showStyle();
        Console.WriteLine("Площадь равна " + t1.area());
        Console.WriteLine();
        Console.WriteLine("Информация о t2: ");
        t2.showStyle();
        t2.showDim();
        Console.WriteLine("Площадь равна " + t2.area());
        Console.WriteLine();
        Console.WriteLine("Информация о t3: ");
        t3.showStyle();
        t3.showDim();
        Console.WriteLine("Площадь равна " + t3.area());
        Console.WriteLine();
    }
}