// Сравнение строк.
using System;
class CompareDemo
{
    public static void Main()
    {
        string str1 = "один";
        string str2 = "один";
        string str3 = "ОДИН";
        string str4 = "два";
        string str5 = "один, два";
        if (String.Compare(str1, str2) == 0)
            Console.WriteLine(str1 + " и " + str2 + " равны.");
        else
            Console.WriteLine(str1 + " и " + str2 + " не равны.");
        if (String.Compare(str1, str3) == 0)
            Console.WriteLine(str1 + " и " + str3 + " равны.");
        else
            Console.WriteLine(str1 + " и " + str3 + " не равны.");
        if (String.Compare(str1, str3, true) == 0)
            Console.WriteLine(str1 + " и " + str3 + " равны без учета регистра.");
        else
            Console.WriteLine(str1 + " и " + str3 + " не равны без учета регистра.");
        if (String.Compare(str1, str5) == 0)
            Console.WriteLine(str1 + " и " + str5 + " равны.");
        else
            Console.WriteLine(str1 + " и " + str5 + " не равны.");
        if (String.Compare(str1, 0, str5, 0, 3) == 0)
            Console.WriteLine("Первая часть строки " + str1 + " и " + str5 + " равны.");
        else
            Console.WriteLine("Первая часть строки " + str1 + " и " + str5 + " не равны.");
        int result = String.Compare(str1, str4);
        if (result < 0)
            Console.WriteLine(str1 + " меньше " + str4);
        else if (result > 0)
            Console.WriteLine(str1 + " больше " + str4);
        else
            Console.WriteLine(str1 + " равно " + str4);
    }
}
