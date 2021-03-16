// Использование атрибута MethodImplAttribute
// для синхронизации метода.
using System;
using System.Threading;
using System.Runtime.CompilerServices;

class TickTock
{
    /* Следующий атрибут синхронизирует метод
    tick() целиком. */
    [MethodImplAttribute(MethodImplOptions.Synchronized)]
    public void tick(bool running)
    {
        if (!running)
        { // Останов часов.
            Monitor.Pulse(this); // Уведомление для
                                 // ожидающих потоков.
            return;
        }
        Console.Write("Тик ");
        Monitor.Pulse(this); // Разрешаем работать
                             // методу tock().
        Monitor.Wait(this); // Ожидаем, пока не завершится
                            // метод tock().
    }
    /* Следующий атрибут синхронизирует метод
    tock() целиком. */
    [MethodImplAttribute(MethodImplOptions.Synchronized)]
    public void tock(bool running)
    {
        if (!running)
        { // Останов часов.
            Monitor.Pulse(this); // Уведомление для
                                 // ожидающих потоков.
            return;
        }
        Console.WriteLine("Так");
        Monitor.Pulse(this); // Разрешаем работать
                             // методу tick().
        Monitor.Wait(this); // Ожидаем, пока не завершится
                            // метод tick().
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
    // Начинаем выполнять новый поток.
    void run()
    {
        if (thrd.Name == "Тик")
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
        MyThread mt1 = new MyThread("Тик", tt);
        MyThread mt2 = new MyThread("Так", tt);
        mt1.thrd.Join();
        mt2.thrd.Join();
        Console.WriteLine("Часы остановлены.");
    }
}