using System;
class Rect
{
    public int width;
    public int height;
    public Rect(int w, int h)
    {
        this.width = w;
        this.height = h;
    }
    public int area()
    {
        return this.width * this.height;
    }
}
class UseRect
{
    public static void Main()
    {
        Rect r1 = new Rect(4, 5);
        Rect r2 = new Rect(7, 9);
        Console.WriteLine(
        "Площадь прямоугольника r1: " + r1.area());
        Console.WriteLine(
        "Площадь прямоугольника r2: " + r2.area());
    }
}