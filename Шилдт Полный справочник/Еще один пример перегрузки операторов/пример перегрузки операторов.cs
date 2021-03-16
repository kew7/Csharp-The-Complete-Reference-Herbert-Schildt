// Создание 4-битового типа с именем Nybble.
using System;
// 4-битовый тип.
class Nybble
{
    int val; // Основа типа - встроенный тип int.
    public Nybble()
    {
        val = 0;
    }
    public Nybble(int i)
    {
        val = i;
        val = val & 0xF; // Выделяем младшие 4 бита.
    }
    // Перегружаем бинарный оператор "+" для
    // сложения Nybble + Nybble.
    public static Nybble operator +(Nybble op1, Nybble op2)
    {
        Nybble result = new Nybble();
        result.val = op1.val + op2.val;
        result.val = result.val & 0xF; // Оставляем младшие
                                       // 4 бита.
        return result;
    }
    // Перегружаем бинарный оператор "+" для
    // сложения Nybble + int.
    public static Nybble operator +(Nybble op1, int op2)
    {
        Nybble result = new Nybble();
        result.val = op1.val + op2;
        result.val = result.val & 0xF; // Оставляем младшие
                                       // 4 бита.
        return result;
    }
    // Перегружаем бинарный оператор "+" для
    // сложения int + Nybble.
    public static Nybble operator +(int op1, Nybble op2)
    {
        Nybble result = new Nybble();
        result.val = op1 + op2.val;
        result.val = result.val & 0xF; // Оставляем младшие
                                       // 4 бита.
        return result;
    }
    // Перегружаем оператор "++".
    public static Nybble operator ++(Nybble op)
    {
        op.val++;
        op.val = op.val & 0xF; // Оставляем младшие
                               // 4 бита.
        return op;
    }
    // Перегружаем оператор ">".
    public static bool operator >(Nybble op1, Nybble op2)
    {
        if (op1.val > op2.val)
            return true;
        else
            return false;
    }
    // Перегружаем оператор "<".
    public static bool operator <(Nybble op1, Nybble op2)
    {
        if (op1.val < op2.val)
            return true;
        else
            return false;
    }
    // Преобразование Nybble-объекта в значение типа int.
    public static implicit operator int(Nybble op)
    {
        return op.val;
    }
    // Преобразование int-значения в Nybble-объект.
    public static implicit operator Nybble(int op)
    {
        return new Nybble(op);
    }
}
class NybbleDemo
{
    public static void Main()
    {
        Nybble a = new Nybble(1);
        Nybble b = new Nybble(10);
        Nybble c = new Nybble();
        int t;
        Console.WriteLine("a: " + (int)a);
        Console.WriteLine("b: " + (int)b);
        // Используем Nybble-объект в if-инструкции.
        if (a < b) Console.WriteLine("а меньше b\n");
        // Суммируем два Nybble-объекта.
        c = a + b;
        Console.WriteLine(
        "с после сложения c = a + b: " + (int)c);
        // Суммируем int-значение с Nybble-объектом.
        a += 5;
        Console.WriteLine("а после сложения а += 5: " + (int)a);
        Console.WriteLine();
        // Используем Nybble-объект в int-выражении.
        t = a * 2 + 3;
        Console.WriteLine(
        "Результат выражения а * 2 + 3: " + t);
        Console.WriteLine();
        // Иллюстрируем присваивание Nybble-объекту
        // int-значения и переполнение.
        a = 19;
        Console.WriteLine(
        "Результат присваивания а = 19: " + (int)a);
        Console.WriteLine();
        // Используем Nybble-объект для управления циклом.
        Console.WriteLine(
        "Управляем for-циклом с помощью Nybble-объекта.");
        for (a = 0; a < 10; a++)
            Console.Write((int)a + " ");
        Console.WriteLine();
    }
}