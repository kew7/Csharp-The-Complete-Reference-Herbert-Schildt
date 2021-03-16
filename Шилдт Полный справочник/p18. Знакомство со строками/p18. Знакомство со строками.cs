// Знакомство со строками.
using System; 
class StringDemo
{
    public static void Main()
    {
        char[] charray = {'A', ' ', 's', 't', 'r',
                          'i', 'n', 'g', '.' };
        string str1 = new string(charray);
        string str2 = "Еще один string-объект.";
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}
 