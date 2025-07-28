using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ;

public class Filtration
{
    /// <summary>
    /// Рассмотрим пример, где надо выбрать четные числа больше 10:
    /// </summary>
    public static void WhereExample()
    {
        int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
        var evenNums = from i in numbers where i % 2 == 0 && i > 10 select i;
        foreach (var i in evenNums)
            Console.WriteLine(i);

        //  Решение с помощью метода расширения
        var evenExtensionMethod = numbers.Where(i => i % 2 == 0 && i > 10);
    }

    public static void WhereExample2()

    {
        // Добавим Россию с её городами
        var russianCities = new List<City>();
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));
        SolutionWhereExample2(russianCities);
    }

    // Создадим модель класс для города
    public class City
    {
        public string Name { get; set; }
        public long Population { get; set; }

        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

    }

    public static void SolutionWhereExample2(List<City> russianCities)
    {
        var bigCities = from russianCity in russianCities
                        where russianCity.Population > 1000000 // Фильтрация
                        orderby russianCity.Population descending//Сортировка
                        select russianCity;//выбираем объект и сохраняем выбор

        foreach (var bigCity in bigCities)
            Console.WriteLine(bigCity.Name + " - " + bigCity.Population);

        // EXTANSION METHOD!!!
        var bigCitiesExtansion = russianCities.Where(p => p.Population > 1000000).
            OrderByDescending(p => p.Population);


    }
    /// <summary>
    /// А теперь попробуйте выбрать все города, название у которых не длиннее 10 букв, и отсортируйте их по длине названия.
    /// </summary>
    /// <param name="russianCities"></param>
    public static void Task1411(List<City> russianCities)
    {
        var nameOverTenChar = from russianCity in russianCities
                              where russianCity.Name.Length > 10 // Filtration
                              orderby russianCity.Name descending // Sorting
                              select russianCity; // Select, Choose object
        foreach (var name in nameOverTenChar)
        {
            Console.WriteLine(name);
        }
        //EXTANSION MEHOD
        var nameOverTenExtansion = russianCities.Where(city => city.Name.Length > 10).
            OrderBy(city => city.Name.Length);

    }

    /// <summary>
    /// Задача: сделать выборку городов-миллионников по всем странам.
    /// </summary>
    public static void CityTask2()
    {
        // Словарь для хранения стран с городами
        var Countries = new Dictionary<string, List<City>>();

        // Добавим Россию с её городами
        var russianCities = new List<City>();
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));
        Countries.Add("Россия", russianCities);

        // Добавим Беларусь
        var belarusCities = new List<City>();
        belarusCities.Add(new City("Минск", 1200000));
        belarusCities.Add(new City("Витебск", 362466));
        belarusCities.Add(new City("Гродно", 368710));
        Countries.Add("Беларусь", belarusCities);

        // Добавим США
        var americanCities = new List<City>();
        americanCities.Add(new City("Нью-Йорк", 8399000));
        americanCities.Add(new City("Вашингтон", 705749));
        americanCities.Add(new City("Альбукерке", 560218));
        Countries.Add("США", americanCities);
    }

    public static void SolutionCityTask2(Dictionary<string, List<City>> countries)
    {
        var biggestCity = from country in countries // пройдемся по странам
                          from city in country.Value //   // пройдемся по городам
                          where city.Population > 1000000
                          orderby city.Population descending
                          select city;
        foreach (var city in biggestCity)
        {
            Console.WriteLine(city.Name + " - " + city.Population);
        }

        //EXTANSION METHOD

        var citiesExtansion = countries.SelectMany(country => country.Value). // Раскрываем список городов
            Where(city => city.Population > 1000000). // Фильтруем по населению
            OrderByDescending(city => city.Population); // Сортируем


    }
    /// <summary>
    /// А теперь попробуйте выбрать все города, название у которых не длиннее 10 букв,
    /// и отсортируйте их по длине названия.
    /// </summary>
    public static void Task1411(Dictionary<string, List<City>> countries)
    {
        var nameLessTen = from country in countries
                          from city in country.Value
                          where city.Name.Length <= 10
                          orderby city.Name descending
                          select city;
        foreach (var city in nameLessTen)
            Console.WriteLine(city);

        //EXTANSION
        var nameLessTenExtansion = countries.SelectMany(country => country.Value).
            Where(city => city.Name.Length <= 10).
            OrderByDescending(city => city.Name);

        foreach (var city in nameLessTenExtansion) Console.WriteLine(city);
    }
    /// <summary>
    /// Соедините все слова в одну последовательность (каждое слово — отдельный элемент последовательности).
    /// </summary>
    public static void Task1412()
    {
        string[] text = {"Раз два три",
   "четыре пять шесть",
   "семь восемь девять" };

        var textLinq = from t in text// пробегаемся по элементам массива
                       from word in t.Split(' ')// дробим каждый элемент по пробелам, сохраняя в новую последовательность
                       select word;

        foreach (var word in textLinq)
        {
            Console.WriteLine(word);
        }

        //EXTANSION 

        var textLinqExtansion = text.SelectMany(t => t.Split(' '));
        foreach (var word in textLinqExtansion)
            Console.WriteLine(word);
    }

    public static void Task1416()
    {
        var numsList = new List<int[]>()
        {
             new[] {2, 3, 7, 1},
   new[] {45, 17, 88, 0},
   new[] {23, 32, 44, -6},

        };

        //var numArr = from n in numsList
        //             where nums in n.SelectMany


        ////EXTENSION
        //var numsLinq = numsList.SelectMany(n => n).// выбираем элементы
        //    OrderBy(n => n);// сортируем

        //foreach (var num in numsLinq)
        //{
        //    Console.WriteLine(num);
        //}

    }

}



