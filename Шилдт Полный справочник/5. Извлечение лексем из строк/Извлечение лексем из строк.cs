// Извлечение лексем из строк.
using System;
class TokenizeDemo
{
    public static void Main()
    {
        string[] input = {
                    "100 + 19",
                    "100 / 3,3",
                    "-3 * 9",
                    "100 - 87"
                    };
        char[] seps = { ' ' };
        for (int i = 0; i < input.Length; i++)
        {
            // Разбиваем строку на части.
            string[] parts = input[i].Split(seps);
            Console.Write("Команда: ");
            for (int j = 0; j < parts.Length; j++)
                Console.Write(parts[j] + " ");
            Console.Write(", результат: ");
            double n = Double.Parse(parts[0]);
            double n2 = Double.Parse(parts[2]);
            switch (parts[1])
            {
                case "+":
                    Console.WriteLine(n + n2);
                    break;
                case "-":
                    Console.WriteLine(n - n2);
                    break;
                case "*":
                    Console.WriteLine(n * n2);
                    break;
                case "/":
                    Console.WriteLine(n / n2);
                    break;
            }
        }
    }
}
