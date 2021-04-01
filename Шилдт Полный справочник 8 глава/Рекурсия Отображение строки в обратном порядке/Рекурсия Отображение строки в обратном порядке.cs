// Отображение строки в обратном порядке с помощью рекурсии.
using System;
class RevStr {
    public int Count =0;
    public void displayRev(string str) {
        Count++;
        if (str.Length > 0) {
            Console.WriteLine(str[0] + " \t" + str + " \t" +str.Length); // отоборажение текущего состояния подстроки
            displayRev(str.Substring(1, str.Length - 1));
        }
        else {
            Console.WriteLine();
            Console.Write("Перевернутая строка: "); 
            return;
        }       
        Console.Write(str[0]);
    }
}

internal class RevStrDemo {
    public static void Main() {
        String S = "Ремарк";
        RevStr rsOb = new RevStr();
        Console.WriteLine("Исходная строка: " + S);
        Console.WriteLine("\nstr[0]\tstr\tstr.Length"); // заголовок отоборажения текущего состояния подстроки
        rsOb.displayRev(S);
        Console.WriteLine();
        Console.WriteLine("Количество вызовов метода с рекурсией Count = " + rsOb.Count + "\n");
    }
}
/*Если при каждом вызове метода displayRev() проверка показывает, что длина
строки str больше нуля, то выполняется рекурсивный вызов displayRev() с новым
аргументом-строкой, которая состоит из предыдущей строки str без ее первого символа.
Этот процесс повторяется до тех пор, пока тому же методу не будет передана строка
нулевой длины. После этого вызванные ранее методы начнут возвращать значения, и
каждый возврат будет сопровождаться довыполнением метода, т.е. отображением первого
символа строки str. В результате исходная строка посимвольно отобразится в обратном
порядке.  */
