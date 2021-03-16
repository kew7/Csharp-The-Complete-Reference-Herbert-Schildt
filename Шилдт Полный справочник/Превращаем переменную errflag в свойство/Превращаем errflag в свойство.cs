// Превращаем переменную errflag в свойство.
using System;
class FailSoftArray
{
    int[] a; // Ссылка на базовый массив.
    int len; // Длина массива.
    bool errflag; // Теперь этот член закрыт.
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
    // Свойство Error предназначено только для чтения.
    public bool Error
    {
        get
        {
            return errflag;
        }
    }
    // Это - индексатор класса FailSoftArray.
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
            else
                errflag = true;
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
class FinalFSDemo
{
    public static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        // Используем свойство Error.
        for (int i = 0; i < fs.Length + 1; i++)
        {
            fs[i] = i * 10;
            if (fs.Error)
                Console.WriteLine("Ошибка в индексе " + i);
        }
    }
}