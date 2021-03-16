// Добавление конструктора в класс Triangle.
using System;
// Класс двумерных объектов.
class TwoDShape
{
    double pri_width; // Закрытый член.
    double pri_height; // Закрытый член.
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
// Класс треугольников - производный от класса TwoDShape.
class Triangle : TwoDShape
{
    string style; // Закрытый член.
    // Конструктор.
    public Triangle(string s, double w, double h)
    {
        width = w; // Инициализирует член базового класса.
        height = h; // Инициализирует член базового класса.
        style = s; // Инициализирует член своего класса.
    }
    // Метод возвращает значение площади треугольника.
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

    class Shapes3
    {
        public static void Main()
        {
            Triangle t1 = new Triangle("равнобедренный", 4.0, 4.0);
            Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);
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