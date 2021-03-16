// Использование интерфейса ISeries для реализации
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