// Демонстрация использования приоритетов потоков.
using System;
using System.Threading;
class MyThread
{
	public int count;
	public Thread thrd;
	static bool stop = false;
	static string currentName;
	/* Создаем новый поток. Обратите внимание на то, что
	этот конструктор в действительности не запускает
	потоки на выполнение. */
	public MyThread(string name)
	{
		count = 0;
		thrd = new Thread(new ThreadStart(this.run));
		thrd.Name = name; 
		currentName = name;
    }
    // Начинаем выполнение нового потока.
    void run()
	{
		Console.WriteLine("Поток " + thrd.Name + " стартовал.");
		do {
			count++;
			if (currentName != thrd.Name) {
				currentName = thrd.Name;
				Console.WriteLine("В потоке " + currentName);
			}
		} while (stop == false && count < 100000);
		stop = true;
		Console.WriteLine("Поток " + thrd.Name + " завершен.");
	}
}

class PriorityDemo
{
	public static void Main()
	{
		MyThread mt1 = new MyThread("с высоким приоритетом");
		MyThread mt2 = new MyThread("с низким приоритетом");
		// Устанавливаем приоритеты.
		mt1.thrd.Priority = ThreadPriority.AboveNormal;
		mt2.thrd.Priority = ThreadPriority.Lowest;
		// Запускаем потоки на выполнение.
		mt1.thrd.Start();
		mt2.thrd.Start();
		mt1.thrd.Join();
		mt2.thrd.Join();
		Console.WriteLine();
		Console.WriteLine("Поток " + mt1.thrd.Name +
				" досчитал до " + mt1.count);
		Console.WriteLine("Поток " + mt2.thrd.Name +
				" досчитал до " + mt2.count);
	}
}