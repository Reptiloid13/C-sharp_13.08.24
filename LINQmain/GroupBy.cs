using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ;

public class GroupBy
{
    public static void GroupByExample()
    {
        var cars = new List<Car>()
        {
            new Car("Suzuki", "JP" ),
            new Car("Toyota", "JP"),
            new Car("Opel", "DE"),
            new Car("Kamaz", "RUS"),
            new Car("Lada", "RUS"),
            new Car("Honda", "JP"),
        };
        // Группировка по стране - производителю
        var carsByCountry = from car in cars
                            group car by car.CountryCode;

        // Пробежимся по группам
        foreach (var grouping in carsByCountry)
        {
            Console.WriteLine(grouping.Key + ":");

            // внутри каждой группы пробежимся по элементам
            foreach (var car in grouping)
                Console.WriteLine(car.Manufacturer);
            Console.WriteLine();

            //И даже осуществлять вложенные запросы, используя ключевое слово into.
            var carsByCountry2 = from car in cars
                                 group car by car.CountryCode into grouping1 // выборка в локальную переменную для вложенного запроса
                                 select new
                                 {
                                     Name = grouping1.Key,
                                     Count = grouping1.Count(),
                                     Cars = from p in grouping1 select p //  выполним подзапрос, чтобы заполнить список машин внутри нашего нового типа
                                 };

            foreach (var group in carsByCountry2)
            {
                Console.WriteLine($"{group.Name} : {group.Count} авто");
                foreach (Car car in group.Cars)
                    Console.WriteLine(car.Manufacturer);
                Console.WriteLine();
            }

        }

        //EXTANSION 
        var carsByCountry3 = cars
   .GroupBy(car => car.CountryCode)
   .Select(g => new
   {
       Name = g.Key,
       Count = g.Count(),
       Cars = g.Select(c => c)
   });


    }
}
