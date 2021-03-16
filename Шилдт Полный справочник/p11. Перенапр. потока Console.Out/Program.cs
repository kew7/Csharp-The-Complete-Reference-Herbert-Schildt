// Перенаправление потока Console.Out.
using System;
using System.IO;
class Redirect
{
    public static void Main()
    {
        StreamWriter log_out;
        try
        {
            log_out = new StreamWriter("logfile.txt");
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message +
            "Не удается открыть файл.");
            return;
        }
        // Направляем стандартный выходной поток в
        // системный журнал.
        Console.SetOut(log_out);
        Console.WriteLine("Это начало системного журнала.");
        for (int i = 0; i < 10; i++)
            Console.WriteLine(i);
        Console.WriteLine("Это конец системного журнала.");
        log_out.Close();
    }
}
