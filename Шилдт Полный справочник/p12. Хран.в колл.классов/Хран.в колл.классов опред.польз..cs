// Простой пример на тему инвентаризации.
using System;
using System.Collections;
using System.Text;

class Inventory
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
        return String.Format("{0,-16}Цена: {1,8:C} В наличии: {2}", name, cost, onhand);
    }
}

class InventoryList
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
        Console.WriteLine("Информация о запасах на складе:");
        foreach (Inventory i in inv)
        {
            Console.WriteLine(" " + i);
        }
    }
}
