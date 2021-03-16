// Сравнение доступа к открытым и закрытым членам класса.
using System;
class MyClass
{
    private int alpha; // Явно задан спецификатор private.
    int beta; // Спецификатор private по умолчанию.
    public int gamma; // Явно задан спецификатор public.
    /* Методы для получения доступа к членам alpha и beta.
    Другие члены класса беспрепятственно получают доступ
    к private-члену того же класса. */
    public void setAlpha(int a)
    {
        alpha = a;
    }
    public int getAlpha()
    {
        return alpha;
    }
    public void setBeta(int a)
    {
        beta = a;
    }
    public int getBeta()
    {
        return beta;
    }
}
class AccessDemo
{
    public static void Main()
    {
        MyClass ob = new MyClass();
        /* Доступ к private-членам alpha и beta разрешен
        только посредством соответствующих методов. */
        ob.setAlpha(-99);
        ob.setBeta(19);
        Console.WriteLine("Член ob.alpha равен " +
        ob.getAlpha());
        Console.WriteLine("Член ob.beta равен " +
        ob.getBeta());
        // К private-членам alpha или beta нельзя получить
        // доступ таким образом:
        // ob.alpha = 10;
        // Неверно! alpha — закрытый член!
        // ob.beta = 9;
        // Неверно! beta — закрытый член!
        // Можно получить прямой доступ
        // к члену gamma, поскольку он открытый член.
        ob.gamma = 99;
    }
}