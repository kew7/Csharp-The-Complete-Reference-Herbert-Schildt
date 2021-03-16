﻿// Реализация интерфейса ISeries.
class ByTwos : ISeries
{
    int start;
    int val;
    public ByTwos()
    {
        start = 0;
        val = 0;
    }
    public int getNext() {
        val += 2; return val;
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