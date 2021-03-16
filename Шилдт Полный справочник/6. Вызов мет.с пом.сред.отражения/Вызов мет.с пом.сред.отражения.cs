/*Зная, какие методы поддерживает тип, можно вызвать любой из них. Для этого
используется метод Invoke(), который определен в классе MethodInfo.
Формат его вызова таков:
object Invoke(object ob, object[] args)
Здесь параметр ob — это ссылка на объект, для которого вызывается нужный метод.
Для static-методов параметр ob должен содержать значение null. Любые аргументы,
которые необходимо передать вызываемому методу, указываются в массиве args. Если
метод вызывается без аргументов, параметр args должен иметь null-значение. При этом
длина массива args должна совпадать с количеством аргументов, передаваемых методу.
Следовательно, если необходимо передать два аргумента, массив args должен состоять из
двух элементов, а не, например, из трех или четырех.*/

// Вызов методов с использованием средства отражения.
using System;
using System.Reflection;

class MyClass
{
    int x; int y;
    public MyClass(int i, int j)
    {
        x = i;
        y = j;
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

class InvokeMethDemo
{
    public static void Main()
    {
        Type t = typeof(MyClass);
        MyClass reflectOb = new MyClass(10, 20);
        int val;
        Console.WriteLine("Вызов методов, определенных в " + t.Name);
        Console.WriteLine();
        MethodInfo[] mi = t.GetMethods();
        // Вызываем каждый метод.
        foreach (MethodInfo m in mi)
        {
            // Получаем параметры.
            ParameterInfo[] pi = m.GetParameters();
            if (m.Name.CompareTo("set") == 0 && pi[0].ParameterType == typeof(int))
            {
                object[] args = new object[2];
                args[0] = 9;
                args[1] = 18;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.CompareTo("set") == 0 && pi[0].ParameterType == typeof(double))
            {
                object[] args = new object[2];
                args[0] = 1.12; args[1] = 23.4;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.CompareTo("sum") == 0)
            {
                val = (int)m.Invoke(reflectOb, null);
                Console.WriteLine("Результат вызова метода sum равен " + val);
            }
            else if (m.Name.CompareTo("isBetween") == 0)
            {
                object[] args = new object[1];
                args[0] = 14;
                if ((bool)m.Invoke(reflectOb, args))
                    Console.WriteLine("14 находится между x и y.");
            }
            else if (m.Name.CompareTo("show") == 0)
            {
                m.Invoke(reflectOb, null);
            }
        }
    }
}
