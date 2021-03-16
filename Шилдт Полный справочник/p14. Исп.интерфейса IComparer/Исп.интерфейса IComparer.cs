// Использование интерфейса IComparer.
using System;
using System.Collections;
// Создаем класс CompInv.
// для объектов класса Inventory.
class CompInv : IComparer
{
    // Реализуем интерфейс IComparer.
    public int Compare(object obj1, object obj2)
    {
        Inventory a, b;
        a = (Inventory)obj1;
        b = (Inventory)obj2;
        return a.name.CompareTo(b.name);
    }
}

class Inventory
{
    public string name;
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
        String.Format("{0,-16}Цена: {1,8:С} В наличии: {2}",
        name, cost, onhand);
    }
}

class MailList
{
    public static void Main()
    {
        CompInv comp = new CompInv();
        ArrayList inv = new ArrayList();
        // Добавляем элементы в список.
        inv.Add(new Inventory("Плоскогубцы", 5.95, 3));
        inv.Add(new Inventory("Гаечные ключи", 8.29, 2));
        inv.Add(new Inventory("Молотки", 3.50, 4));
        inv.Add(new Inventory("Сверла", 19.88, 8));
        Console.WriteLine(
        "Информация о запасах на складе до сортировки:");
        foreach (Inventory i in inv)
        {
            Console.WriteLine(" " + i);
        }
        Console.WriteLine();
        // Сортируем список, используя интерфейс IComparer.
        inv.Sort(comp);
        Console.WriteLine(
        "Информация о запасах на складе после сортировки:");
        foreach (Inventory i in inv)
        {
            Console.WriteLine(" " + i);
        }
    }
}
