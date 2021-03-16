// Использование класса MyClass без опоры на
// предварительные данные о нем.
using System;
using System.Reflection;
class ReflectAssemblyDemo
{
    public static void Main()
    {
        int val;
        Assembly asm = Assembly.LoadFrom("MyClasses.exe");
        Type[] alltypes = asm.GetTypes();
        Type t = alltypes[0]; // Используем первый
                              // обнаруженный класс.
        Console.WriteLine("Используем: " + t.Name);
        ConstructorInfo[] ci = t.GetConstructors();
        // Используем первый обнаруженный конструктор.
        ParameterInfo[] cpi = ci[0].GetParameters();
        object reflectOb;
        if (cpi.Length > 0)
        {
            object[] consargs = new object[cpi.Length];
            // Инициализируем аргументы.
            for (int n = 0; n < cpi.Length; n++)
                consargs[n] = 10 + n * 20;
            // Создаем объект.
            reflectOb = ci[0].Invoke(consargs);
        }
        else
            reflectOb = ci[0].Invoke(null);
        Console.WriteLine("\nВызываем методы для объекта reflectOb.");
        Console.WriteLine();
        // Игнорируем унаследованные методы.
        MethodInfo[] mi = t.GetMethods(
                                        BindingFlags.DeclaredOnly |
                                        BindingFlags.Instance |
                                        BindingFlags.Public);
        // Вызываем каждый метод.
        foreach (MethodInfo m in mi)
        {
            Console.WriteLine("Вызов метода {0} ", m.Name);
            // Получаем параметры.
            ParameterInfo[] pi = m.GetParameters();
            // Выполняем методы.
            switch (pi.Length)
            {
                case 0: // без аргументов
                    if (m.ReturnType == typeof(int))
                    {
                        val = (int)m.Invoke(reflectOb, null);
                        Console.WriteLine("Результат равен " + val);
                    }
                    else if (m.ReturnType == typeof(void))
                    {
                        m.Invoke(reflectOb, null);
                    }
                    break;
                case 1: // один аргумент
                    if (pi[0].ParameterType == typeof(int))
                    {
                        object[] args = new object[1];
                        args[0] = 14;
                        if ((bool)m.Invoke(reflectOb, args))
                            Console.WriteLine("14 находится между x и y.");
                        else
                            Console.WriteLine("14 не находится между x и y.");
                    }
                    break;
                case 2: // два аргумента
                    if ((pi[0].ParameterType == typeof(int)) &&
                        (pi[1].ParameterType == typeof(int)))
                    {
                        object[] args = new object[2];
                        args[0] = 9;
                        args[1] = 18;
                        m.Invoke(reflectOb, args);
                    }
                    else if ((pi[0].ParameterType == typeof(double)) &&
                    (pi[1].ParameterType == typeof(double)))
                    {
                        object[] args = new object[2];
                        args[0] = 1.12;
                        args[1] = 23.4;
                        m.Invoke(reflectOb, args);
                    }
                    break;
            }
            Console.WriteLine();
        }
    }
}
