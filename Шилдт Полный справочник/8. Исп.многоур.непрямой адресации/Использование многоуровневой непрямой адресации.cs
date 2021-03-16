using System;
class Multiplelndirect
{
    unsafe public static void Main()
    {
        int x; // Переменная содержит значение.
        int* p; // Переменная содержит указатель
                //на int-значение.
        int** q; // Переменная содержит указатель на указатель
                 //на int-значение.
        x = 10;
        p = &x; // Помещаем адрес x в р.
        q = &p; // Помещаем адрес p в q.
        Console.WriteLine(**q); // Отображаем значение x.
    }
}
