// Демонстрация использования различных
// спецификаторов формата.
using System;
using System.Text;
using System.Threading;
using System.Globalization;

class FormatDemo
{
    public static void Main()
    {
        double v = 17688.65849;
        double v2 = 0.15;
        int x = 21;

        // System.Globalization.CultureInfo.InvariantCulture;
        //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("{0:F2}", v);
        Console.WriteLine("{0:N5}", v);
        Console.WriteLine("{0:e}", v);
        Console.WriteLine("{0:r}", v);
        Console.WriteLine("{0:p}", v2);
        Console.WriteLine("{0:X}", x);
        Console.WriteLine("{0:D12}", x);
        Console.WriteLine("{0:C}", 189.99);
    }
}
