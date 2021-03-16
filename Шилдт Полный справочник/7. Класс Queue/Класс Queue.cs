// Демонстрация класса Queue.
using System;
using System.Collections;

class QueueDemo
{
    static void showEnq(Queue q, int a)
    {
        q.Enqueue(a);
        Console.WriteLine(
        "Помещаем элемент в очередь: Enqueue(" + a + ")");
        Console.Write("Содержимое очереди: ");
        foreach (int i in q)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    static void showDeq(Queue q)
    {
        Console.Write(
        "Извлекаем элемент из очереди: Dequeue -> ");
        int a = (int)q.Dequeue();
        Console.WriteLine(a);
        Console.Write("Содержимое очереди: ");
        foreach (int i in q)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    public static void Main()
    {
        Queue q = new Queue();
        foreach (int i in q)
            Console.Write(i + " ");
        Console.WriteLine();
        showEnq(q, 22);
        showEnq(q, 65);
        showEnq(q, 91);
        showDeq(q);
        showDeq(q);
        showDeq(q);
        try
        {
            showDeq(q);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Очередь пуста.");
        }
    }
}
