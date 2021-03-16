// Добавление метода в класс Building.
using System;
class Building
{
    public int floors; // количество этажей
    public int area; // общая площадь здания
    public int occupants; // количество жильцов
                          // Отображаем значение площади, приходящейся
                          //на одного человека.
    public void areaPerPerson()
    {
        Console.WriteLine(" " + area / occupants +
        " приходится на одного человека");
    }
} 
// Используем метод areaPerPerson().`
class BuildingDemo
{
    public static void Main()
    {
        Building house = new Building();
        Building office = new Building();
        // Присваиваем значения полям в объекте house.
        house.occupants = 4;
        house.area = 2500;
        house.floors = 2;
        // Присваиваем значения полям в объекте office.
        office.occupants = 25;
        office.area = 4200;
        office.floors = 3;
        Console.WriteLine("Дом имеет:\n " +
        house.floors + " этажа\n " +
        house.occupants + " жильца\n " +
        house.area +
        " квадратных футов общей площади, из них");
        house.areaPerPerson();
        Console.WriteLine();
        Console.WriteLine("Офис имеет:\n " +
        office.floors + " этажа\n " +
        office.occupants + " работников\n " +
        office.area +
        " квадратных футов общей площади, из них");
        office.areaPerPerson();
    }
}