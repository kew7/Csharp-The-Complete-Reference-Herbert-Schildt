// Демонстрация возможности передачи методам объектов.
using System;

class MyClass {
int alpha, beta;
    public MyClass(int i, int j) { // конструктор
    alpha = i;
    beta = j;
    }
    /* Метод возвращает true, если параметр ob содержит
    те же значения, что и вызывающий объект. */
    public bool sameAs(MyClass ob) {
    if((ob.alpha == alpha) & (ob.beta == beta))
    return true;
    else
    return false;
}
    // Создаем копию объекта ob.
    public void copy(MyClass ob)
    {
        alpha = ob.alpha;
        beta = ob.beta;
    }
    public void show()
    {
        Console.WriteLine("alpha: {0}, beta: {1}", alpha, beta);
    }
}

class PassOb
{
    public static void Main()
    {
        MyClass ob1 = new MyClass(4, 5);
        MyClass ob2 = new MyClass(6, 7);
        Console.Write("ob1: ");
        ob1.show();
        Console.Write("ob2: ");
        ob2.show();
        if (ob1.sameAs(ob2))
            Console.WriteLine(
            "ob1 и оb2 имеют одинаковые значения.");
        else
            Console.WriteLine(
            "ob1 и оb2 имеют разные значения.");
        Console.WriteLine();
        // Теперь делаем объект оb1 копией объекта оb2.
        ob1.copy(ob2);
        Console.Write("ob1 после копирования: ");
        ob1.show();
        if (ob1.sameAs(ob2))
            Console.WriteLine(
            "ob1 и оb2 имеют одинаковые значения.");
        else
            Console.WriteLine(
            "оb1 и оb2 имеют разные значения.");
    }
}