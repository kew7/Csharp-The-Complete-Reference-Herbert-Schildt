/* Создание класса для поддержки массива с заданным
диапазоном индексации. Класс RangeArray позволяет
начинать индексацию с числа, отличного от нуля.
При создании объекта класса RangeArray необходимо
задать индексы начала и конца диапазона.
Отрицательные индексы также допустимы. Например,
можно создать массивы с диапазоном изменения индексов
от -5 до 5, от 1 до 10 или от 50 до 56. */
using System;
class RangeArray
{
    // Закрытые данные.
    int[] a; // Ссылка на базовый массив.
    int lowerBound; // Наименьший индекс.
    int upperBound; // Наибольший индекс.
                    // Данные для свойств.
    int len; // Базовая переменная для свойства Length.
    bool errflag; // Базовая переменная для свойства Error.
    // Создаем массив с заданным размером.
    public RangeArray(int low, int high)
    {
        high++;
        if (high <= low)
        {
            Console.WriteLine("Неверные индексы.");
            high = 1; // Создаем минимальный массив для
                      // безопасности.
            low = 0;
        }
        a = new int[high - low];
        len = high - low;
        lowerBound = low;
        upperBound = --high;
    }
    // Свойство Length, предназначенное только для чтения.
    public int Length
    {
        get
        {
            return len;
        }
    }
    // Свойство Error, предназначенное только для чтения.
    public bool Error
    {
        get
        {
            return errflag;
        }
    }
    // Это — индексатор для класса RangeArray.
    public int this[int index] {
        // Это — get-аксессор.
        get
        {
            if (ok(index))
            {
                errflag = false;
                return a[index - lowerBound];
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
                a[index - lowerBound] = value;
                errflag = false;
            }
            else errflag = true;
        }
    }
    // Метод возвращает true, если индекс находится
    // внутри границ.
    private bool ok(int index)
    {
        if (index >= lowerBound & index <= upperBound)
            return true;
        return false;
    }
}
// Демонстрируем использование массива с произвольно
// заданным диапазоном индексов.
class RangeArrayDemo
{
    public static void Main()
    {
        RangeArray ra = new RangeArray(-5, 5);
        RangeArray ra2 = new RangeArray(1, 10);
        RangeArray ra3 = new RangeArray(-20, -12);
        // Используем массив ra.
        Console.WriteLine("Длина массива ra: " + ra.Length);
        for (int i = -5; i <= 5; i++)
            ra[i] = i;
        Console.Write("Содержимое массива ra: ");
        for (int i = -5; i <= 5; i++)
            Console.Write(ra[i] + " ");
        Console.WriteLine("\n");
        // Используем массив ra2,
        Console.WriteLine("Длина массива ra2: " + ra2.Length);
        for (int i = 1; i <= 10; i++)
            ra2[i] = i;
        Console.Write("Содержимое массива ra2: ");
        for (int i = 1; i <= 10; i++)
            Console.Write(ra2[i] + " ");
        Console.WriteLine("\n");
        // Используем массив ra3
        Console.WriteLine("Длина массива ra3: " + ra3.Length);
        for (int i = -20; i <= -12; i++)
            ra3[i] = i;
        Console.Write("Содержимое массива ra3: ");
        for (int i = -20; i <= -12; i++)
            Console.Write(ra3[i] + " ");
        Console.WriteLine("\n");
    }
}