 /*
Добавляем параметризованный метод, вычисляющий
максимальное количество человек, которые могут
занимать это здание в предположении, что на каждого
должна приходиться заданная минимальная площадь.
*/
using System;
class Building
{
    public int floors; // количество этажей
    public int area; // общая площадь здания
    public int occupants; // количество жильцов
                          // Метод возвращает площадь, которая приходится
                          // на одного человека.
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
// Использование метода maxOccupant().
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
