// Управление основным потоком.
using System;
using System.Threading;
class UseMain
{
    public static void Main()
    {
        Thread thrd;
        // Получаем ссылку на объект основного потока.
        thrd = Thread.CurrentThread;
        // Отображаем имя основного потока.
        if (thrd.Name == null)
            Console.WriteLine("Основной поток не имеет имени.");
        else
            Console.WriteLine("Имя основного потока: " + thrd.Name);
        // Отображаем приоритет основного потока.
        Console.WriteLine("Приоритет: " + thrd.Priority);
        Console.WriteLine();
        // Задаем имя и приоритет.
        Console.WriteLine("Установка имени и приоритета.\n");
        thrd.Name = "Основной поток";
        thrd.Priority = ThreadPriority.AboveNormal;
        Console.WriteLine("У основного потока теперь есть имя: " + thrd.Name);
        Console.WriteLine("Приоритет теперь таков: " + thrd.Priority);
    }
}
