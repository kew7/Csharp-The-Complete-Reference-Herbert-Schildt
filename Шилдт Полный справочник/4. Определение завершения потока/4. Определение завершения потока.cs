// Используем свойство IsAlive для установления факта
// завершения выполнения потока.

using System;
using System.Threading;

class MyThread
{
    public int count;
    public Thread thrd;
    public MyThread(string name)
    {
        count = 0;
        thrd = new Thread(new ThreadStart(this.run));
        thrd.Name = name;
        thrd.Start();
    }
    // Входная точка потока.
    void run()
    {
        Console.WriteLine(thrd.Name + " стартовал.");
        do
        {
            Thread.Sleep(500);
            Console.WriteLine("В потоке " + thrd.Name + ", count = " + count);
            count++;
        } while (count < 10);
        Console.WriteLine(thrd.Name + " завершен.");
    }
}

class MoreThreads
{
    public static void Main()
    {
        Console.WriteLine("Основной поток стартовал.");
        // Создаем три потока.
        MyThread mt1 = new MyThread("Потомок #1");
        MyThread mt2 = new MyThread("Потомок #2");
        MyThread mt3 = new MyThread("Потомок #3");
        do
        {
            Console.Write("."); Thread.Sleep(10);
        } while (mt1.thrd.IsAlive &&
                 mt2.thrd.IsAlive &&
                 mt3.thrd.IsAlive);
        Console.WriteLine("Основной поток завершен.");
    }
}
