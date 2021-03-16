// Демонстрация использования интерфейсных ссылок.
using System;
// Определение интерфейса.
public interface ISeries
{
    int getNext(); // Возвращает следующее число ряда.
    void reset(); // Выполняет перезапуск.
    void setStart(int x); // Устанавливает начальное
                          // значение.
}
// Используем интерфейс ISeries для генерирования
// последовательности четных чисел.
class ByTwos : ISeries
{
    int start;
    int val;
    public ByTwos()
    {
        start = 0;
        val = 0;
    }
    public int getNext()
    {
        val += 2;
        return val;
    }
    public void reset()
    {
        val = start;
    }
    public void setStart(int x)
    {
        start = x; val = start;
    }
}
// Используем интерфейс ISeries для построения
// ряда простых чисел.
class Primes : ISeries
{
    int start;
    int val;
    public Primes()
    {
        start = 2;
        val = 2;
    }
    public int getNext()
    {
        int i, j;
        bool isprime;
        val++;
        for (i = val; i < 1000000; i++)
        {
            isprime = true;
            for (j = 2; j < (i / j + 1); j++)
            {
                if ((i % j) == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime)
            {
                val = i;
                break;
            }
        }
        return val;
    }
    public void reset()
    {
        val = start;
    }
    public void setStart(int x)
    {
        start = x;
        val = start;
    }
}
class SeriesDemo2
{
    public static void Main()
    {
        ByTwos twoOb = new ByTwos();
        Primes primeOb = new Primes();
        ISeries ob;
        for (int i = 0; i < 5; i++)
        {
            ob = twoOb;
            Console.WriteLine("Следующее четное число равно " + ob.getNext());
            ob = primeOb;
            Console.WriteLine("Следующее простое число равно " + ob.getNext());
        }
    }
}