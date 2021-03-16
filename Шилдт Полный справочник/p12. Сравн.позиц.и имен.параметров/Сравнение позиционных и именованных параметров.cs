// Использование именованного параметра атрибута.
using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute : Attribute
{
    string pri_remark; // Базовое поле для свойства remark.
    public string supplement; // Это именованный параметр.
    public RemarkAttribute(string comment)
    {
        pri_remark = comment;
        supplement = "Данные отсутствуют";
    }
    public string remark
    {
        get
        {
            return pri_remark;
        }
    }
}

[RemarkAttribute("Этот класс использует атрибут.",
supplement = "Это дополнительная информация.")]
class UseAttrib
{
    // ...
}

class NamedParamDemo
{
    public static void Main()
    {
        Type t = typeof(UseAttrib);
        Console.Write("Атрибуты в " + t.Name + ": ");
        object[] attribs = t.GetCustomAttributes(false);
        foreach (object o in attribs)
        {
            Console.WriteLine(o);
        }
        // Считывание атрибута RemarkAttribute.
        Type tRemAtt = typeof(RemarkAttribute);
        RemarkAttribute ra = (RemarkAttribute)
        Attribute.GetCustomAttribute(t, tRemAtt);
        Console.Write("Remark: ");
        Console.WriteLine(ra.remark);
        Console.Write("Supplement: ");
        Console.WriteLine(ra.supplement);
    }
}
