// Этот файл содержит три класса.
// Назовите его MyClasses.cs.
using System;

class MyClass
{
    int x;
    int y;
    public MyClass(int i)
    {
        Console.WriteLine(
        "Создание объекта по формату MyClass(int). ");
        x = y = i;
        show();
    }
    public MyClass(int i, int j)
    {
        Console.WriteLine(
        "Создание объекта по формату MyClassdnt, int). ");
        x = i;
        y = j;
        show();
    }
    public int sum()
    {
        return x + y;
    }
    public bool isBetween(int i)
    {
        if ((x < i) && (i < y)) return true;
        else return false;
    }
    public void set(int a, int b)
    {
        Console.Write("Внутри метода set(int, int). ");
        x = a;
        y = b;
        show();
    }
    // Перегруженный метод set.
    public void set(double a, double b)
    {
        Console.Write("Внутри метода set(double, double). ");
        x = (int)a;
        y = (int)b;
        show();
    }
    public void show()
    {
        Console.WriteLine(
        "Значение x: {0}, значение y: {1}", x, y);
    }
}

class AnotherClass
{
    string remark;
    public AnotherClass(string str)
    {
        remark = str;
    }
    public void show()
    {
        Console.WriteLine(remark);
    }
}

// чтобы скомпилировать и получить MyClasses.exe, активируйте код ниже.

class Demo
{
    public static void Main()
    {
        Console.WriteLine("Это заглушка.");
    }
}
