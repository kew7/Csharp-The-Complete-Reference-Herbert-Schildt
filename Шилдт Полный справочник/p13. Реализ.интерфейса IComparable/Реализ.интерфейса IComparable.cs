// Реализация интерфейса IComparable.
using System;
using System.Text;
using System.Collections;

class Inventory : IComparable
{
    string name;
    double cost;
    int onhand;
    public Inventory(string n, double c, int h)
    {
        name = n;
        cost = c;
        onhand = h;
    }
    public override string ToString()
    {
        return
        String.Format("{0,-16}Цена: {1,8:C} В наличии: {2}", name, cost, onhand);
    }
    // Реализуем интерфейс IComparable. 
    public int CompareTo(object obj)
    {
        Inventory b;
        b = (Inventory)obj;
        return name.CompareTo(b.name);
    }
}

class IComparableDemo
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        ArrayList inv = new ArrayList();
        // Добавляем элементы в список.
        inv.Add(new Inventory("Плоскогубцы", 5.95, 3));
        inv.Add(new Inventory("Гаечные ключи", 8.29, 2));
        inv.Add(new Inventory("Молотки", 3.50, 4));
        inv.Add(new Inventory("Сверла", 19.88, 8));
        Console.WriteLine("Информация о запасах на складе до сортировки:");
        foreach (Inventory i in inv)
        {
            Console.WriteLine(" " + i);
        }
        Console.WriteLine();
        // Сортируем список.
        inv.Sort();
        Console.WriteLine("Информация о запасах на складе после сортировки:");
        foreach (Inventory i in inv)
        {
            Console.WriteLine(" " + i);
        }
    }
}
