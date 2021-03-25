// Демонстрация возврата методом массива.
using System;
class Factor
{   // Поскольку в C# массивы реализованы как объекты, метод может возвратить массив.
    /* Метод возвращает массив, содержащий множители
    параметра num. После выполнения метода
    out-параметр numfactors будет содержать количество
    найденных множителей. */
    public int[] findfactors(int num, out int numfactors)
    {
        int[] facts = new int[80]; // Размер 80 взят произвольно.
        int i, j;
        // Находим множители и помещаем их в массив facts.
        for (i = 2, j = 0; i < num / 2 + 1; i++)
            if ((num % i) == 0)
            {
                facts[j] = i;
                j++;
            }
        numfactors = j; return facts;
    }
}

class FindFactors
{
    public static void Main()
    {
        Factor f = new Factor();
        int numfactors;
        int[] factors;
        int num=170;
        factors = f.findfactors(num, out numfactors);
        Console.Write("Множители числа {0}: ", num);
        if (numfactors == 0) Console.WriteLine("множителей нет, число простое");
            else
            {
                Console.WriteLine();
                for (int i = 0; i < numfactors; i++)
                    Console.Write(factors[i] + " ");
            }
        Console.WriteLine('\n');
    }
}