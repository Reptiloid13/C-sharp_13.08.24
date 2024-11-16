using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace OOP;

//8. Создайте класс Book с методом экземпляра read, который выводит на экран строку "Читаю книгу {название}".
//    Добавьте в класс статический метод getTotalPages, который возвращает общее количество страниц во всех книгах.
//    Создайте два экземпляра класса Book и вызовите метод read для каждого

public class GetBook
{
    public static void Test()
    {
        Book book1 = new Book("Как стать Айтишником", new Random().Next(100, 999));
        book1.Read();
        Book book2 = new Book("Мой путь в С-шарп", new Random().Next(1, 20));

        //  нужно что то записать 
        book2.Read();


        Console.WriteLine($"Книга - {book1.Name}, Страниц у книги - {book1.Pages}");
        Console.WriteLine($"Книга - {book2.Name}, Страниц у книги - {book2.Pages}");
        Console.WriteLine($"Общее количество страниц у двух книг: {string.Join(", ", Book.TotalPages)}");
        book1.Reset();

        book2.Reset();
    }
}

class Book
{
    public string Name;
    public int Pages;

    // public static int TotalPages { get; private set; }
    private static List<int> TotalPagesList { get; set; } = [];
    public static int TotalPages => TotalPagesList.Sum();

    public Book(string name, int pages)
    {
        Name = name;
        Pages = pages;

        TotalPagesList.Add(pages);
    }

    public void Read()
    {
        Console.WriteLine($"Читаю кингу {Name} ");
    }

    public void Reset()
    {
        Pages = 0;
    }
}

//9. Создайте класс Weather с методом экземпляра getForecast, который выводит на экран строку "Погода в {городе}: {погода}".
//    Добавьте в класс статический метод getAverageTemperature, который возвращает среднюю температуру во всех городах.
//    Создайте два экземпляра класса Weather и вызовите метод getForecast для каждого.

public class GetWeather
{
    public static void Test()
    {
        Weather weather = new Weather("Moscow", 10);

        weather.GetForecast();

        Weather weather1 = new Weather("Evpatoria", 20); // Какой аргумент отсутсвует, вроде все верно. 

        weather1.GetForecast();

        Console.WriteLine($"Wetaher in {weather.Name} : {weather.Temperature}");
        Console.WriteLine($"Weather in  {weather1.Name} : {weather1.Temperature}");
    }
}

class Weather
{
    public string Name;
    public int Temperature;
    private static List<int> AverageTemperatureList { get; set; } = [];
    public static int AverageTemperature => AverageTemperatureList.Sum(); // Не пойму что за ошибка? 

    public Weather(string name, int temperature)
    {
        Name = name;
        Temperature = temperature;
        AverageTemperatureList.Add(Temperature);
    }


    public void GetForecast()
    {
        Console.WriteLine($"Погода в {Name} : {Temperature}");
    }
}