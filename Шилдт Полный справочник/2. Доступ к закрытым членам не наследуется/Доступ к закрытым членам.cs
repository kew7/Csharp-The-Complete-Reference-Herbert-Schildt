// Использование свойств для записи и чтения закрытых
// членов класса.
using System;
// Класс двумерных объектов.
class TwoDShape
{
    double pri_width; // Теперь это private-член.
    double pri_height; // Теперь это private-член.
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
    public string style; // Тип треугольника.
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

class Shapes2
{
    public static void Main()
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle();
        t1.width = 4.0;
        t1.height = 4.0;
        t1.style = "равнобедренный";
        t2.width = 8.0;
        t2.height = 12.0;
        t2.style = "прямоугольный";
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