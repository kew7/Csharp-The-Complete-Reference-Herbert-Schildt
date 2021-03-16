// Анализ методов с помощью средства отражения.
using System;
using System.Reflection;

class MyClass
{
    int x;
    int y;
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
        if (x < i && i < y) return true;
        else return false;
    }
    public void set(int a, int b)
    {
        x = a;
        y = b;
    }
    public void set(double a, double b)
    {
        x = (int)a;
        y = (int)b;
    }
    public void show()
    {
        Console.WriteLine(" x: {0}, y: {1}", x, y);
    }
}

class ReflectDemo
{
    public static void Main()
    {
        Type t = typeof(MyClass); // Получаем Type-объект,
                                  // представляющий MyClass.
        Console.WriteLine("Анализ методов, определенных в " + t.Name);
        Console.WriteLine();
        Console.WriteLine("Поддерживаемые методы: ");
        MethodInfo[] mi = t.GetMethods();
        // Отображаем методы, поддерживаемые классом MyClass.
        foreach (MethodInfo m in mi)
        {
            // Отображаем тип значения, возвращаемого методом,
            // и имя метода.
            Console.Write(" " + m.ReturnType.Name + " " + m.Name + "(");
            // Отображаем параметры.
            ParameterInfo[] pi = m.GetParameters();
            for (int i = 0; i < pi.Length; i++)
            {
                Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                if (i + 1 < pi.Length) Console.Write(", ");
            }
            Console.WriteLine(")");
            Console.WriteLine();
        }
    }
}
