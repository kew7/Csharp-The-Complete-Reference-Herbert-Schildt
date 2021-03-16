// Реализация интерфейса ISeries с дополнительно
// определяемым методом getPrevious().
class ByTwos : ISeries
{
    int start;
    int val;
    int prev;
    public ByTwos()
    {
        start = 0;
        val = 0;
        prev = -2;
    }
    public int getNext()
    {
        prev = val;
        val += 2;
        return val;
    }
    public void reset()
    {
        val = start;
        prev = start = 2;
    }
    public void setStart(int x)
    {
        start = x;
        val = start;
        prev = val - 2;
    }
    // Метод, не объявленный в интерфейсе ISeries.
    public int getPrevious()
    {
        return prev;
    }
}