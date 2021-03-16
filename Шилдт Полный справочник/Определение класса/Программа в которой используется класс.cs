// Программа, в которой используется класс Building.
using System;

namespace The_Difinition_Of_Class
{
    class Building
    {
        public int floors; // количество этажей
        public int area; // общая площадь основания здания
        public int occupants; // количество жильцов
    }
    // Этот класс объявляет объект типа Building.
    class BuildingDemo
    {
        public static void Main()
        {
            Building house = new Building(); // Создание объекта
                                             // типа Building.
            int areaPP; // Площадь, приходящаяся на одного жильца.
                        // Присваиваем значения полям в объекте house.
            house.occupants = 4;
            house.area = 2500;
            house.floors = 2;
            // Вычисляем площадь, приходящуюся на одного жильца дома.
            areaPP = house.area / house.occupants;
            Console.WriteLine(
            "Дом имеет:\n " +`
            house.floors + " этажа\n " +
            house.occupants + " жильца\n " +
            house.area +
            " квадратных футов общей площади, из них\n "
            + areaPP + " приходится на одного человека");
        }
    }
}