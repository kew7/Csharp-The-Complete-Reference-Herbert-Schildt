// Демонстрация возврата значения методом areaPerPerson().
using System;
class Building
{
    public int floors; // количество этажей
    public int area; // общая площадь здания
    public int occupants; // количество жильцов
                          // Возврат значения площади, которая
                          // приходится на одного человека.
    public int areaPerPerson()
    {
        return area / occupants;
    }
}
// Использование значения от метода areaPerPerson().
class BuildingDemo
{
    public static void Main()
    {
        Building house = new Building();
        Building office = new Building();
        int areaPP; // Площадь, которая приходится
                    // на одного человека.
        // присваиваем значения полям в объекте house.
        house.occupants = 4;
        house.area = 2500;
        house.floors = 2;
        // Присваиваем значения полям в объекте office.
        office.occupants = 25;
        office.area = 4200;
        office.floors = 3;
        // Получаем для объекта house площадь, которая
        // приходится на одного человека.
        areaPP = house.areaPerPerson();
        Console.WriteLine("Дом имеет:\n " +
        house.floors + " этажа\n " +
        house.occupants + " жильца\n " +
        house.area +
        " квадратных футов общей площади, из них\n " +
        areaPP + " приходится на одного человека");
        Console.WriteLine();
        // Получаем площадь для объекта office, которая
        // приходится на одного человека.
        areaPP = office.areaPerPerson();
        Console.WriteLine("Офис имеет:\n " +
        office.floors + " этажа\n " +
        office.occupants + " работников\n " +
        office.area +
        " квадратных футов общей площади, из них\n " +
        areaPP + " приходится на одного человека");
    }
}