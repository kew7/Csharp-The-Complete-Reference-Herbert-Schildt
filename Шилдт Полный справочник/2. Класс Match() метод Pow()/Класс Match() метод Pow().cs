/* Вычисление объема начального капиталовложения,
необходимого для достижения известной будущей
стоимости при заданных годовом показателе
ожидаемого дохода и количестве лет. */
using System;
class IntialInvestment
{
    public static void Main()
    {
        decimal InitInvest; // начальное капиталовложение
        decimal FutVal; // будущая стоимость
        double NumYears; // количество лет
        double IntRate; // годовой показатель
                        // ожидаемого дохода
        string str;
        Console.Write("Введите значение будущей стоимости: ");
        str = Console.ReadLine();
        try
        {
            FutVal = Decimal.Parse(str);
        }
        catch (FormatException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }
        Console.Write("Введите процентную ставку (например, 0.085): ");
        str = Console.ReadLine();
        try
        {
            IntRate = Double.Parse(str);
        }
        catch (FormatException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }
        Console.Write("Введите количество лет: ");
        str = Console.ReadLine();
        try
        {
            NumYears = Double.Parse(str);
        }
        catch (FormatException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }
        InitInvest = FutVal / (decimal)Math.Pow(IntRate + 1.0, NumYears);
        Console.WriteLine("Требуемый объем начального капиталовложения: {0:C}", InitInvest);
    }
}
