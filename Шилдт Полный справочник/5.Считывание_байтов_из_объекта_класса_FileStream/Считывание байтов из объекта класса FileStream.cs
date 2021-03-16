/* Отображение содержимого текстового файла.
Чтобы использовать эту программу, укажите имя
файла, содержимое которого вы хотите увидеть.
Например, чтобы увидеть содержимое файла TEST.CS,
используйте следующую командную строку:
ShowFile TEST.CS */
using System;
using System.IO;
class ShowFile
{
	public static void Main(string[] args)
	{
		int i;
		FileStream fin;
		try {
			fin = new FileStream(args[0], FileMode.Open);
		} catch (FileNotFoundException exc) {
			Console.WriteLine(exc.Message);
			return;
		} catch (IndexOutOfRangeException exc) {
			Console.WriteLine(exc.Message +
			"\nПрименение: ShowFile Файл");
			return;
		}
		// Считываем байты до тех пор, пока не встретится EOF.
		do {
			try {
				i = fin.ReadByte();
			} catch (Exception exc) {
				Console.WriteLine(exc.Message);
				return;
			}
			if (i != -1) Console.Write((char)i);
		} while (i != -1);
		fin.Close();
	}
}