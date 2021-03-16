// Использование свойства в качестве именованного
// параметра атрибута.
using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute : Attribute
{
    string pri_remark; // Базовое поле для свойства remark.
    int pri_priority; // Базовое поле для свойства priority.
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
    // Используем свойство в качестве именованного параметра.
    public int priority
    {
        get
        {
            return pri_priority;
        }
        set
        {
            pri_priority = value;
        }
    }
}

[RemarkAttribute(
"Этот класс использует атрибут.",
supplement = "Это дополнительная информация.",
priority = 10)]
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
        // Считываем атрибут RemarkAttribute.
        Type tRemAtt = typeof(RemarkAttribute);
        RemarkAttribute ra = (RemarkAttribute)
        Attribute.GetCustomAttribute(t, tRemAtt);
        Console.Write("Remark: ");
        Console.WriteLine(ra.remark);
        Console.Write("Supplement: ");
        Console.WriteLine(ra.supplement);
        Console.WriteLine("Priority: " + ra.priority);
    }
}
