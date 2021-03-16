
using System;
class CountInst
{
    static int count = 0;
    // Инкрементируем счетчик при создании объекта.
    public CountInst()
    {
        count++;
    }
    ~CountInst()
    {
        count--;
    }
    public static int getcount()
    {
        return count;
    }
}
class CountDemo
{
    public static void Main()
    {
        CountInst ob;
        for (int i = 0; i < 10; i++)
        {
            ob = new CountInst();
            Console.WriteLine("Текущее содержимое счетчика: " +
            CountInst.getcount());
        }
    }
}
/* Каждый раз, когда создается объект типа CountInst, static-поле count
инкрементируется. И каждый раз, когда объект типа CountInst разрушается, static-
поле count декрементируется. Таким образом, статическая переменная count всегда
содержит количество объектов, существующих в данный момент. Это возможно только
благодаря использованию статического поля. Переменная экземпляра не в состоянии
справиться с такой задачей, поскольку подсчет экземпляров класса связан с классом в
целом, а не с конкретным его экземпляром.*/