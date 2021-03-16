/* Находим компоновочный файл, определяем типы и
создаем объект, используя средство отражения. */
using System;
using System.Reflection;

class ReflectAssemblyDemo
{
    public static void Main()
    {
        int val;
        // Загружаем компоновочный файл MyClasses.exe.
        Assembly asm = Assembly.LoadFrom("MyClasses.exe");
        // Узнаем, какие типы содержит файл MyClasses.exe.
        Type[] alltypes = asm.GetTypes();
        foreach (Type temp in alltypes)
            Console.WriteLine("Обнаружено: " + temp.Name);
        Console.WriteLine();
        // Используем первый тип,
        // которым в данном случае является MyClass,
        Type t = alltypes[0]; // Анализируем первый
                              // обнаруженный класс.
        Console.WriteLine("Используем: " + t.Name);
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
                Console.Write(pi[i].ParameterType.Name +
                    " " + pi[i].Name);
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
            Console.WriteLine(
            "Подходящий конструктор не найден.");
            return;
        }
        else
            Console.WriteLine(
            "Найден конструктор с двумя параметрами.\n");
        // Создаем объект.
        object[] consargs = new object[2];
        consargs[0] = 10;
        consargs[1] = 20;
        object reflectOb = ci[x].Invoke(consargs);
        Console.WriteLine(
        "\nВызов методов для объекта reflectOb.");
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
                args[1] = 18;
                m.Invoke(reflectOb, args);
            }
            else if (m.Name.CompareTo("set") == 0 &&
            pi[0].ParameterType == typeof(double))
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
                Console.WriteLine(
                "Результат выполнения метода sum() равен " + val);
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
