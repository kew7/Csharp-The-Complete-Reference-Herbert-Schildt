// Управление лентой конвейера.
using System;
class ConveyorControl
{
    // public const int i = 7;
    // Перечисляем команды, управляющие конвейером.
    public enum action { старт, стоп, вперед, назад };

    public void conveyor(action com)
    {
        switch (com)
        {
            case action.старт:
                Console.WriteLine("Запуск конвейера.");
                break;
            case action.стоп:
                Console.WriteLine("Останов конвейера.");
                break;
            case action.вперед:
                Console.WriteLine("Перемещение вперед.");
                break;
            case action.назад:
                Console.WriteLine("Перемещение назад.");
                break;
        }
    }
}

class ConveyorDemo
{
    public static void Main()
    {
        ConveyorControl c = new ConveyorControl();
        // перечисление являются константой, поэтому нельзя получить доступ через объект 
        c.conveyor(ConveyorControl.action.старт);
        c.conveyor(ConveyorControl.action.вперед);
        c.conveyor(ConveyorControl.action.назад);
        c.conveyor(ConveyorControl.action.стоп);
    }
}