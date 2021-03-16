// Пример использования свойства.
using System;
class SimpProp
{
    int prop; // Это поле управляется свойством myprop.
    public SimpProp()
    {
        prop = 0;
    }
    /* Это свойство поддерживает доступ к закрытой
    переменной экземпляра prop. Оно позволяет
    присваивать ей только положительные числа. */
    public int myprop
    {
        get
        {
            return prop;
        }
        set
        {
            if (value >= 0)
                prop = value;
        }
    }
}

// Демонстрируем использование свойства.
class PropertyDemo
{
    public static void Main()
    {
        SimpProp ob = new SimpProp();
        Console.WriteLine("Исходное значение ob.myprop: " + ob.myprop);
        ob.myprop = 100; // Присваиваем значение.
        Console.WriteLine("Значение ob.myprop: " + ob.myprop);
        // Переменной prop невозможно присвоить
        // отрицательное значение.
        Console.WriteLine(
        "Попытка присвоить -10 свойству ob.myprop");
        ob.myprop = -10;
        Console.WriteLine("Значение ob.myprop: " + ob.myprop);
    }
}