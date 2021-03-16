// Класс стека для хранения символов.

/*В классе StackDemo создается пустым первый стек stk1, который заполняется символами.
  Этот стек затем используется для создания второго стека stk2, и в этом случае 
  вызывается следующий конструктор класса stack.*/
using System;
class Stack {
    // Эти члены закрыты.
    char[] stck; // Этот массив содержит стек.
    int tos; // Индекс вершины стека.
    // Создаем пустой объект класса Stack заданного размера.
    public Stack(int size) {
    stck = new char[size]; // Выделяем память для стека.
    tos = 0;
    }      

    // Создаем Stack-объект на основе существующего стека.
    public Stack(Stack ob) {
        // Выделяем память для стека.
        stck = new char[ob.stck.Length];
        // Копируем элементы в новый стек.
        for(int i=0; i < ob.tos; i++)
            stck[i] = ob.stck[i];
        // Устанавливаем переменную tos для нового стека.
        tos = ob.tos;
    }
    // Помещаем символ в стек.
    public void push(char ch) {
        if(tos==stck.Length) {
            Console.WriteLine(" -- Стек заполнен.");
            return;
        }
        stck[tos] = ch;
        tos++;
    }
    // Извлекаем символ из стека.
    public char pop() {  
        if(tos==0) {
        Console.WriteLine(" -- Стек пуст.");
        return(char) 0;
        }
        tos--;
        return stck[tos];
    }
    // Метод возвращает значение true, если стек заполнен.
    public bool full() {
        return tos==stck.Length;
    }
    // Метод возвращает значение true, если стек пуст.
    public bool empty() {
        return tos==0;
    }
    // Возвращает общий объем стека.
    public int capacity() {
        return stck.Length;
    }
    // Возвращает текущее количество объектов в стеке.
    public int getNum() {
        return tos;
    }
}
    // Демонстрация использования класса Stack.
    class StackDemo {
      public static void Main() {
        Stack stk1 = new Stack(10);
        char ch;
        int i;

        // Помещаем символы в стек stk1.
        Console.WriteLine(
            "Помещаем символы от А до Z в стек stk1.");
        for (i = 0; !stk1.full(); i++)
            stk1.push((char)('A' + i));

        // Создаем копию стека stck1.
        Stack stk2 = new Stack(stk1);

        // Отображаем содержимое стека stk1.
        Console.Write("Содержимое стека stk1: ");
        while (!stk1.empty())
        {
            ch = stk1.pop();
            Console.Write(ch);
        }
        Console.WriteLine();
        Console.Write("Содержимое стека stk2: ");
        while (!stk2.empty())
        {
            ch = stk2.pop();
            Console.Write(ch);
        }
        Console.WriteLine("\n");
     }
    }