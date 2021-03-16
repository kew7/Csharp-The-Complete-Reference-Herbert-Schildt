// Демонстрация SortedList-коллекции.
using System;
using System.Collections;
class SLDemo
{
    public static void Main()
    {
        // Создаем упорядоченную коллекцию типа SortedList.
        SortedList sl = new SortedList();
        // Добавляем в список элементы.
        sl.Add("здание", "жилое помещение");
        sl.Add("автомобиль", "транспортное средство");
        sl.Add("книга", "набор печатных слов");
        sl.Add("яблоко", "съедобный фрукт");
        // Добавлять элементы можно также с помощью индексатора.
        sl["трактор"] = "сельскохозяйственная машина";
        // Получаем коллекцию ключей.
        ICollection c = sl.Keys;
        // Используем ключи для получения значений.
        Console.WriteLine("Содержимое списка, полученное с помощью " + "индексатора.");
        foreach (string str in c)
            Console.WriteLine(str + ": " + sl[str]);
        Console.WriteLine();
        // Отображаем список, используя целочисленные индексы.
        Console.WriteLine("Содержимое списка, полученное с помощью " + "целочисленных индексов.");
        for (int i = 0; i < sl.Count; i++)
            Console.WriteLine(sl.GetByIndex(i));
        Console.WriteLine();
        // Отображаем целочисленные индексы элементов списка.
        Console.WriteLine("Целочисленные индексы элементов списка.");
        foreach (string str in c)
            Console.WriteLine(str + ": " + sl.IndexOfKey(str));
    }
}
