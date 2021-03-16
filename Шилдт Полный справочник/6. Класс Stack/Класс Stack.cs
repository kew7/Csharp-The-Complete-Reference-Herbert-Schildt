// Демонстрация использования класса Stack.
using System;
using System.Collections;
class StackDemo
{
    static void showPush(Stack st, int a)
    {
        st.Push(a);
        Console.WriteLine(
        "Помещаем в элемент стек: Push(" + a + ")");
        Console.Write("Содержимое стека: ");
        foreach (int i in st)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    static void showPop(Stack st)
    {
        Console.Write("Извлекаем элемент из стека: Pop -> ");
        int a = (int)st.Pop();
        Console.WriteLine(a);
        Console.Write("Содержимое стека: ");
        foreach (int i in st)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    public static void Main()
    {
        Stack st = new Stack();
        foreach (int i in st)
            Console.Write(i + " ");
        Console.WriteLine();
        showPush(st, 22);
        showPush(st, 65);
        showPush(st, 91);
        showPop(st);
        showPop(st);
        showPop(st);
        try
        {
            showPop(st);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Стек пуст.");
        }
    }
}
