// Демонстрация использования нумератора
// типа IDictionaryEnumerator.
using System;
using System.Collections;
class IDicEnumDemo
{
    public static void Main()
    {
        // Создаем хеш-таблицу.
        Hashtable ht = new Hashtable();
        // Добавляем элементы в хеш-таблицу.
        ht.Add("Анатолий", "555-3456");
        ht.Add("Марина", "555-9876");
        ht.Add("Александр", "555-3452");
        ht.Add("Кирилл", "555-7756");
        // Демонстрируем работу нумератора.
        IDictionaryEnumerator etr = ht.GetEnumerator();
        Console.WriteLine("Отображаем информацию с помощью свойства Entry.");
        while (etr.MoveNext())
            Console.WriteLine(etr.Entry.Key + ": " + etr.Entry.Value);
        Console.WriteLine();
        Console.WriteLine("Отображаем информацию с помощью " + "свойств Key и Value.");
        etr.Reset();
        while (etr.MoveNext())
            Console.WriteLine(etr.Key + ": " + etr.Value);
    }
}