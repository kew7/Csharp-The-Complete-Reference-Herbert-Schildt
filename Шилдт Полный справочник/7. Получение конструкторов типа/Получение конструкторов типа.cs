// Создание объекта с помощью средства отражения.
using System;
using System.Reflection;

class MyClass
{
    int x;
    int y;
    public MyClass(int i)
    {
        Console.WriteLine("Создание объекта по формату MyClass(int). ");
        x = y = i;
    }
    public MyClass(int i, int j)
    {
        Console.WriteLine("Создание объекта по формату MyClass(int, int). ");
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
    // Перегруженный метод set().
    public void set(double a, double b)
    {
        Console.Write("Внутри метода set(double, double). ");
        x = (int)a;
        y = (int)b;
        show();
    }
    public void show()
    {
        Console.WriteLine("Значение x: {0}, значение y: {1}", x, y);
    }
}

class InvokeConsDemo
{
    public static void Main()
    {
        Type t = typeof(MyClass);
        int val;
        // Получаем информацию о конструкторах.
        ConstructorInfo[] ci = t.GetConstructors();
        Console.WriteLine("Имеются следующие конструкторы: ");
        foreach (ConstructorInfo c in ci)
        {
            // Отображаем тип возвращаемого значения и имя.
            Console.Write(" " + t.Name + "(");
            // Отображаем параметры.
            ParameterInfo[] pi = c.GetParameters();
            for (int i = 0; i < pi.Length; i++)
            {
                Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                if (i + 1 < pi.Length) Console.Write(", ");
            }
            Console.WriteLine(")");
        }
        Console.WriteLine();
        // Находим подходящий конструктор.
        int x;
        for (x = 0; x < ci.Length; x++)
        {
            ParameterInfo[] pi = ci[x].GetParameters();
            if (pi.Length == 2) break;
        }
        if (x == ci.Length)
        {
            Console.WriteLine("Подходящий конструктор не найден.");
            return;
        }
        else
            Console.WriteLine("Найден конструктор с двумя параметрами.\n");
        // Создаем объект.
        object[] consargs = new object[2];
        consargs[0] = 10;
        consargs[1] = 20;
        object reflectOb = ci[x].Invoke(consargs);
        Console.WriteLine("\nВызов методов для объекта reflectOb.");
        Console.WriteLine();
        MethodInfo[] mi = t.GetMethods();
        // Вызываем каждый метод.
        foreach (MethodInfo m in mi)
        {
            // Получаем параметры.
            ParameterInfo[] pi = m.GetParameters();
            if (m.Name.CompareTo("set") == 0 &&
            pi[0].ParameterType == typeof(int))
            {
                // Это метод set(int, int).
                object[] args = new object[2];
                args[0] = 9;
                args[1] = 13;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.CompareTo("set") == 0 && pi[0].ParameterType == typeof(double))
            {
                // Это метод set(double, double).
                object[] args = new object[2];
                args[0] = 1.12;
                args[1] = 23.4;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.CompareTo("sum") == 0)
            {
                val = (int)m.Invoke(reflectOb, null);
                Console.WriteLine("Результат выполнения метода sum() равен " + val);
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