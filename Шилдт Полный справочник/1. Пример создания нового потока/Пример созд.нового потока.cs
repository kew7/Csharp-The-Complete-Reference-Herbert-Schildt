// Создаем поток управления.
using System;
using System.Threading;

class MyThread
{
    public int count;
    string thrdName;
    public MyThread(string name)
    {
        count = 0;
        thrdName = name;
    }
    // Начало (входная точка) потока.
    public void run()
    {
        Console.WriteLine(thrdName + " стартовал.");
        do
        {
            Thread.Sleep(500);
            Console.WriteLine("В потоке " + thrdName + ", count = " + count);
            count++;
        } while (count < 10);
        Console.WriteLine(thrdName + " завершен.");
    }
}

class MultiThread
{
    public static void Main()
    {
        Console.WriteLine("Основной поток стартовал.");
        // Сначала создаем объект класса MyThread.
        MyThread mt = new MyThread("Потомок #1");

        // Затем из этого объекта создаем поток.
        Thread newThrd = new Thread(new ThreadStart(mt.run));
        // Наконец, запускаем выполнение потока.
        newThrd.Start();

        do
        {
            Console.Write(".");
            Thread.Sleep(10);
        } while (mt.count != 10);
        Console.WriteLine("Основной поток завершен.");
    }
}
