// Запуск нового процесса.
using System;
using System.Diagnostics;
class StartProcess
{
    public static void Main()
    {
        Process newProc = Process.Start("wordpad.exe");
        Console.WriteLine("Новый процесс стартовал.");
        newProc.WaitForExit();
        newProc.Close(); // Освобождаем ресурсы системы.
        Console.WriteLine("Новый процесс завершился.");
    }
}
