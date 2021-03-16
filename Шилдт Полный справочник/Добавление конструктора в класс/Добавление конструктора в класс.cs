// Добавление конструктора в класс Building.
using System;
class Building
{
    public int floors; // количество этажей
    public int area; // общая площадь основания здания
    public int occupants; // количество жильцов
    public Building(int f, int a, int o) {
      floors = f; area = a; occupants = o;
    }
    // Метод возвращает значение площади, которая
    // приходится на одного человека.
    public int areaPerPerson()
    {
        return area / occupants;
    }
    /* Метод возвращает максимальное возможное количество
    человек в здании, если на каждого должна приходиться
    заданная минимальная площадь. */
    public int maxOccupant(int minArea)
    {
        return area / minArea;
    }
}
// Используем параметризованный конструктор Building().
class BuildingDemo
{
    public static void Main()
    {
        Building house = new Building(2, 2500, 4);
        Building office = new Building(3, 4200, 25);
        Console.WriteLine(
        "Максимальное число человек для дома, \n" +
        "если на каждого должно приходиться " +
        300 + " квадратных футов: " +
        house.maxOccupant(300));
        Console.WriteLine(
        "Максимальное число человек для офиса, \n" +
        "если на каждого должно приходиться " +
        300 + " квадратных футов: " +
        office.maxOccupant(300));
    }
}