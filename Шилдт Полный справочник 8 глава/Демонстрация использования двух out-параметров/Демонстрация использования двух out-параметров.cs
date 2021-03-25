// Демонстрация использования двух out-параметров.
using System;
class Num {
    /* Метод определяет, имеют ли x и v общий множитель.
    Если да, метод возвращает наименьший и наибольший
    общие множители в out-параметрах. */
    public bool isComDenom(int x, int y, out int least, out int greatest)
    {
        int i;
        int max = x < y ? x : y;
        bool first = true;
        least = 1;
        greatest = 1;
        // Находим наименьший и наибольший общие множители.
        for(i=2; i <= max/2 + 1; i++) {
            if( ((y%i)==0) & ((x%i)==0) ) {
                if(first) {
                    least = i;
                    first = false;
                }
                greatest = i;
            }
        }
    if(least != 1) return true;
    else return false;
    }
}
class DemoOut
{
    public static void Main()
    {
        Num ob = new Num();
        int lcd, gcd;
        if (ob.isComDenom(231, 105, out lcd, out gcd))
        {
            Console.WriteLine("Lcd для чисел 231 и 105 равен " +
            lcd);
            Console.WriteLine("Gcd для чисел 231 и 105 равен " +
            gcd);
        }
        else
            Console.WriteLine(
            "Для чисел 35 и 49 общего множителя нет.");
        if (ob.isComDenom(35, 51, out lcd, out gcd))
        {
            Console.WriteLine("Lcd для чисел 35 и 51 равен " +
            lcd);
            Console.WriteLine("Gcd для чисел 35 и 51 равен " +
            gcd);
        }
        else
            Console.WriteLine(
            "Для чисел 35 и 51 общего множителя нет.");
    }
}