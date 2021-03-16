// Демонстрация использования Hashtable-коллекции.
using System;
using System.Collections;
class HashtableDemo
{
    public static void Main()
    { // Создаем хеш-таблицу.
        Hashtable ht = new Hashtable();
        // Добавляем элементы в хеш-таблицу.
        ht.Add("здание", "жилое помещение");
        ht.Add("автомобиль", "транспортное средство");
        ht.Add("книга", "набор печатных слов");
        ht.Add("яблоко", "съедобный фрукт");
        // Добавлять элементы можно также С помощью индексатора.
        ht["трактор"] = "сельскохозяйственная машина";
        // Получаем коллекцию ключей.
        ICollection c = ht.Keys;
        // Используем ключи для получения значений.
        foreach (string str in c)
            Console.WriteLine(str + ": " + ht[str]);
    }
}