// Использование модификатора out.
using System;
class Decompose {
    /* Метод разбивает число с плавающей точкой на
    целую и дробную части. */
    public int parts(double n, out double frac) {
    int whole;
    whole = (int) n;
    frac = n - whole; // Передаем дробную часть
    // посредством параметра frac.
    return whole; // Возвращаем целую часть числа.
    }
}
class UseOut {
    public static void Main() {
    Decompose ob = new Decompose();
    int i; double f;
    i = ob.parts(10.125, out f);
    Console.WriteLine("Целая часть числа равна " + i);
    Console.WriteLine("Дробная часть числа равна " + f);
    }
}