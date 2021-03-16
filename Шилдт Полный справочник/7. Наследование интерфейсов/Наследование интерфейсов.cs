// Один интерфейс может наследовать другой.
using System;
public interface A
{
    void meth1();
    void meth2();
}

// Интерфейс В теперь включает методы meth1() и meth2(),
//а также добавляет метод meth3().
public interface В : A
{
    void meth3();
}

// Этот класс должен реализовать все методы
// интерфейсов А и В.
class MyClass : В
{
    public void meth1()
    {
        Console.WriteLine("Реализация метода meth1().");
    }
    public void meth2()
    {
        Console.WriteLine("Реализация метода meth2().");
    }
    public void meth3()
    {
        Console.WriteLine("Реализация метода meth3().");
    }
}

class IFExtend
{
    public static void Main()
    {
        MyClass ob = new MyClass();
        ob.meth1();
        ob.meth2();
        ob.meth3();
    }
}