// Использование методов Wait() и Pulse() для создания
// тикающих часов.
using System;
using System.Threading;

class TickTock
{
    public void tick(bool running)
    {
        lock (this)
        {
            if (!running)
            { // Останов часов.
                Monitor.Pulse(this); // Уведомление любых
                                     // ожидающих потоков.
                return;
            }
            Console.Write("тик");
            Monitor.Pulse(this); // Разрешает выполнение
                                 // метода tock().
            Monitor.Wait(this); // Ожидаем завершения
                                // метода tock().
        }
    }
    public void tock(bool running)
    {
        lock (this)
        {
            if (!running)
            { // Останов часов.
                Monitor.Pulse(this); // Уведомление любых
                                     // ожидающих потоков.
                return;
            }
            Console.WriteLine("так");
            Monitor.Pulse(this); // Разрешает выполнение
                                 // метода tick().
            Monitor.Wait(this); // Ожидаем завершения
                                // метода tick().
        }
    }
}

class MyThread
{
    public Thread thrd;
    TickTock ttOb;
    // Создаем новый поток.
    public MyThread(string name, TickTock tt)
    {
        thrd = new Thread(new ThreadStart(this.run));
        ttOb = tt;
        thrd.Name = name;
        thrd.Start();
    }
    // Начинаем выполнение нового потока.
    void run()
    {
        if (thrd.Name == "тик")
        {
            for (int i = 0; i < 5; i++) ttOb.tick(true);
            ttOb.tick(false);
        }
        else
        {
            for (int i = 0; i < 5; i++) ttOb.tock(true);
            ttOb.tock(false);
        }
    }
}

class TickingClock
{
    public static void Main()
    {
        TickTock tt = new TickTock();
        MyThread mt1 = new MyThread("тик", tt);
        MyThread mt2 = new MyThread("так", tt);
        mt1.thrd.Join();
        mt2.thrd.Join();
        Console.WriteLine("Часы остановлены");
    }
}
