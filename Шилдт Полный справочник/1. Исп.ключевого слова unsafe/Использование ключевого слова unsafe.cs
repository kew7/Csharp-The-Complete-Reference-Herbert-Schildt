// Демонстрация использования указателей и
// ключевого слова unsafe.
using System;
class UnsafeCode
{
    // Отмечаем метод Main() как "опасный".
    unsafe public static void Main()
    {
        int count = 99;
        int* p; // Создаем указатель на int-значение.
        p = &count; // Помещаем адрес переменной count
                    //в указатель р.
        Console.WriteLine("Начальное значение переменной count равно " + *p);
        *p = 10; // Присваиваем значение 10 переменной count
                 // через указатель р.
        Console.WriteLine("Новое значение переменной count равно " + *p);
    }
}
