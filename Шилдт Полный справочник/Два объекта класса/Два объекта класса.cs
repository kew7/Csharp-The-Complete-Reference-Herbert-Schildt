// Эта программа создает два объекта класса Building.
using System;
class Building
{
    public int floors; // количество этажей
    public int area; // общая площадь основания здания
    public int occupants; // количество жильцов
}
// Этот класс объявляет два объекта типа Building.
class BuildingDemo
{
    public static void Main()
    {
        Building house = new Building();
        Building office = new Building();
        int areaPP; // Площадь, приходящаяся на одного жильца.
                    // Присваиваем значения полям в объекте house.
        house.occupants = 4;
        house.area = 2500;
        house.floors = 2;
        // Присваиваем значения полям в объекте office.
        office.occupants = 25;
        office.area = 4200;
        office.floors = 3;
        // Вычисляем площадь, приходящуюся на одного жильца.
        areaPP = house.area / house.occupants;
        Console.WriteLine("Дом имеет:\n " +
        house.floors + " этажа\n " +
        house.occupants + " жильца\n " +
        house.area +
        " квадратных футов общей площади, из них\n " +
        areaPP + " приходится на одного человека");
        Console.WriteLine();
        // Вычисляем площадь, приходящуюся на одного
        // работника офиса.
        areaPP = office.area / office.occupants;
        Console.WriteLine("Офис имеет:\n " +
        office.floors + " этажа\n " +
        office.occupants + " работников\n " +
        office.area +
        " квадратных футов общей площади, из них\n " +
        areaPP + " приходится на одного человека");
    }
}