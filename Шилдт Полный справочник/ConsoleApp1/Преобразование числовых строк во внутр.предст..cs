// Эта программа усредняет список чисел, введенных пользователем.

using System;

class AvgNums
{
    public static void Main()
    {
        string str;
        int n;
        double sum = 0.0d;
        double avg,
                t;

        Console.Write("Сколько чисел вы собираетесь ввести: ");
        str = Console.ReadLine();
        try
        {
            n = Int32.Parse(str);
        }
        catch (FormatException exc)
        {
            Console.WriteLine(exc.Message);
            n = 0;
        }
        catch (OverflowException exc)
        {
            Console.WriteLine(exc.Message);
            n = 0;
        }

        Console.WriteLine("Введите " + n + " чисел.");
        for (int i = 0; i < n; i++)
        {
            Console.Write(": ");
            str = Console.ReadLine();
            try
            {
                t = Double.Parse(str);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                t = 0.0;
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc.Message);
                t = 0;
            }
          sum += t;
        }
        avg = sum / n;
        Console.WriteLine("Среднее равно " + avg);
    }
}