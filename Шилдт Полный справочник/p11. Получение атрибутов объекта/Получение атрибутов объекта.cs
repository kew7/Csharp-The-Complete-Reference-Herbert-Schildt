// Простой пример атрибута.
using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute : Attribute
{
    string pri_remark; // Базовое поле для свойства remark.
    public RemarkAttribute(string comment)
    {
        pri_remark = comment;
    }
    public string remark
    {
        get
        {
            return pri_remark;
        }
    }
}
[RemarkAttribute("Этот класс использует атрибут.")]
class UseAttrib
{
    // ...
}
class AttribDemo
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
        Console.Write("Remark: ");
        // Считываем атрибут RemarkAttribute.
        Type tRemAtt = typeof(RemarkAttribute);
        RemarkAttribute ra = (RemarkAttribute)
        Attribute.GetCustomAttribute(t, tRemAtt);
        Console.WriteLine(ra.remark);
    }
}
