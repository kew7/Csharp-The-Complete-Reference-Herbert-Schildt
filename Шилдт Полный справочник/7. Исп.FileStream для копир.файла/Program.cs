/* Копирование файла.
Для использования этой программы укажите имя
исходного и приемного файлов.
Например, чтобы скопировать файл FIRST.DAT
в файл SECOND.DAT, используйте следующую
командную строку:
CopyFile FIRST.DAT SECOND.DAT */

using System;
using System.IO;
class CopyFile
{
    public static void Main(string[] args)
    {
        int i;
        FileStream fin;
        FileStream fout;
        try
        {
            // Открываем входной файл.
            try
            {
                fin = new FileStream(args[0], FileMode.Open);
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message + "\nВходной файл не найден.");
                return;
            }
            // Открываем выходной файл.
            try
            {
                fout = new FileStream(args[1], FileMode.Create);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message + "\nОшибка при открытии выходного файла.");
                return;
            }
        }
        catch (IndexOutOfRangeException exc)
        {
            Console.WriteLine(exc.Message + "\nПрименение: CopyFile ИЗ КУДА");
            return;
        }
        // Копируем файл.
        try
        {
            do
            {
                i = fin.ReadByte();
                if (i != -1) fout.WriteByte((byte)i);
            } while (i != -1);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "Ошибка при чтении файла. ");
        }
        fin.Close();
        fout.Close();
    }
}
