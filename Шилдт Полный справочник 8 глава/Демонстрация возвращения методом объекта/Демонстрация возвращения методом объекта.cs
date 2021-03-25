// Демонстрация возвращения методом объекта.
using System;
class Rect {
       int width;
       int height;
        public Rect(int w, int h) {
        width = w;
        height = h;
        }
        public int area() {
        return width * height;
        }
        public void show(){
            Console.WriteLine(width + " " + height);
        }
         /* Метод возвращает прямоугольник, который увеличен по
            сравнению с вызывающим объектом прямоугольника с
            использованием заданного коэффициента увеличения. */
            public Rect enlarge(int factor)
            {
                return new Rect(width * factor, height * factor);
            }
}

class RetObj
{
    public static void Main()
    {
        Rect r1 = new Rect(4, 5);
        Console.Write("Размеры прямоугольника r1: ");
        r1.show();
        Console.WriteLine("Площадь прямоугольника r1: " +
        r1.area());
        Console.WriteLine();
        // Создаем прямоугольник, который вдвое больше
        // прямоугольника r1 .
        Rect r2 = r1.enlarge(2);
        Console.Write("Размеры прямоугольника r2: ");
        r2.show();
        Console.WriteLine("Площадь прямоугольника r2: " +
        r2.area());
    }
}