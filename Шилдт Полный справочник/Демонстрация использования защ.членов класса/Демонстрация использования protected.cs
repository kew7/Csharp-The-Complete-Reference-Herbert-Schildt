// Демонстрация использования защищенных членов класса.
using System;
class В
{
    protected int i, j; // Закрыт внутри класса В,
                        //но доступен для класса D.
    public void set(int a, int b)
    {
        i = a;
        j = b;
    }
    public void show()
    {
        Console.WriteLine(i + " " + j);
    }
}
class D : В
{
    int k; // Закрытый член.
           // Класс D получает доступ к членам i и j класса В.
    public void setk()
    {
        k = i * j;
    }
    public void showk()
    {
        Console.WriteLine(k);
    }
}
class ProtectedDemo
{
    public static void Main()
    {
        D ob = new D();
        ob.set(2, 3); // OK, так как D "видит" В-члены i и j.
        ob.show(); // OK, так как D "видит" В-члены i и j.
        ob.setk(); // OK, так как это часть самого класса D.
        ob.showk(); // OK, так как это часть самого класса D.
    }
}