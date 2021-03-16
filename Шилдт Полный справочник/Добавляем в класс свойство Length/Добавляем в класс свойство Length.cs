// Добавляем в класс FailSoftArray свойство Length.
using System;
class FailSoftArray
{
    int[] a; // Ссылка на базовый массив.
    int len; // Длина массива, основа для свойства Length.
    public bool errflag; // Индикатор результата
                         // последней операции.
                         // Создаем массив заданного размера.
    public FailSoftArray(int size)
    {
        a = new int[size];
        len = size;
    }
    // Свойство Length предназначено только для чтения.
    public int Length
    {
        get
        {
            return len;
        }
    }
    // Это — индексатор класса FailSoftArray.
    public int this[int index]
    {
        // Это — get-аксессор.
        get
        {
            if (ok(index))
            {
                errflag = false;
                return a[index];
            }
            else
            {
                errflag = true;
                return 0;
            }
        }
        // Это — set-аксессор.
        set
        {
            if (ok(index))
            {
                a[index] = value;
                errflag = false;
            }
            else errflag = true;
        }
    }
    // Метод возвращает true, если индекс внутри границ.
    private bool ok(int index)
    {
        if (index >= 0 & index < Length) return true;
        return false;
    }
}
// Демонстрируем улучшенный отказоустойчивый массив.
class ImprovedFSDemo
{
    public static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        int x;
        // Свойство Length можно считывать.
        for (int i = 0; i < fs.Length; i++)
            fs[i] = i * 10;
        for (int i = 0; i < fs.Length; i++)
        {
            x = fs[i];
            if (x != -1) Console.Write(x + " ");
        }
        Console.WriteLine();
        // fs.Length = 10; // Ошибка, запись запрещена!
    }
}