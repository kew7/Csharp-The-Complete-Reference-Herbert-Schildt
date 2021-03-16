// Демонстрация передачи объектов по ссылке.
using System;
class Test
{
    public int a, b;
    public Test(int i, int j)
    {
        a = i;
        b = j;
    }
    /* Передаем объект. Теперь ob.a и ob.b в объекте,
    используемом при вызове, будут изменены. */
    public void change(Test ob)
    {
        ob.a = ob.a + ob.b;
        ob.b = -ob.b;
    }
}
class CallByRef
{
    public static void Main()
    {
        Test ob = new Test(15, 20);
        Console.WriteLine("ob.a и ob.b перед вызовом: " +
        ob.a + " " + ob.b);
        ob.change(ob);
        Console.WriteLine("ob.а и ob.b после вызова: " +
        ob.a + " " + ob.b);
    }
}