using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ;

public class SetOperation
{
    /// <summary>
    /// Бывает необходимо исключить из одной коллекции то, что содержится в другой.  Для этого служит метод Except()
    /// Важно! Метод Except() возвращает только уникальные элементы.
    /// </summary>

    public static void ExceptExample()
    {
        // Список напитков в продаже
        string[] drinks = { "Вода", "Кока-кола", "Лимонад", "Вино" };
        // Алкогольные напитки
        string[] alcohol = { "Вино", "Пиво", "Сидр" };

        // Убираем алкоголь из ассортимента
        var drinksForKids = drinks.Except(alcohol);

        foreach (var drink in drinksForKids)
        {
            Console.WriteLine(drink);
        }

    }

    /// <summary>
    ///  Для нахождения общих элементов коллекций используйте Intersect():
    /// </summary>
    public static void IntersectExample()
    {
        string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
        string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        // поищем машины, которые можно считать микроавтобусами

        var microBuses = cars.Intersect(buses);

        foreach (var car in microBuses)
        {
            Console.WriteLine(car);
        }

    }
    /// <summary>
    /// Соединить две коллекции в одну возможно с помощью метода Union().
    /// Если нам нужно просто прибавить элементы одной коллекции к другой, не заботясь о дублировании, есть метод Concat():
    /// </summary>
    public static void UnionExample()
    {
        string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
        string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        var vehicles = cars.Union(buses);
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }

    }

    /// <summary>
    /// Также мы можем проверить коллекцию на наличие дубликатов и удалить их с помощью метода Distinct():
    /// </summary>

    public static void DistinctExample()
    {
        string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
        // удалим дубликаты
        var uniqueCars = cars.Distinct();

        foreach (var car in uniqueCars)
        {
            Console.WriteLine(car);
        }
    }
    /// <summary>
    /// Напишите метод для поиска общих букв в двух словах.
    /// </summary>
    public static void Task1514()
    {
        string word1 = "Volga";
        string word2 = "Lada";
        var sameLetters = word1.Intersect(word2).Count();
        Console.WriteLine(sameLetters);
    }
    /// <summary>
    /// Напишите недостающий код так, чтобы на выходе мы получили список всех IT-компаний без повторений.
    /// </summary>
    public static void Task1515()
    {
        var softwareManufactures = new List<string>()
        {
            "Microsoft", "Apple", "Oracle"
        };

        var handwareManufactures = new List<string>()
        {
            "Apple", "Samsung", "Intel"
        };
        var itCompanies = softwareManufactures.Union(handwareManufactures);
        Console.WriteLine(itCompanies);
    }
    /// <summary>
    /// Напишите программу, которая будет принимать на вход строку текста с консоли (конструкция Console.Readline()) и выводить в ответ список содержащихся в строке уникальных символов без пробелов и следующих знаков препинания: , . ; :  ? !.Напишите программу, которая будет принимать на вход строку текста с консоли (конструкция Console.Readline()) и выводить в ответ список содержащихся в строке уникальных символов без пробелов и следующих знаков препинания: , . ; :  ? !.
    /// </summary>
    public static void Task1516()
    {
        // читаем ввод
        var text = Console.ReadLine();

        // сохраняем список знаков препинания и символ пробела в коллекцию
        var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

        // валидация ввода
        if (string.IsNullOrEmpty(text))
        {
            Console.WriteLine("Вы ввели пустой текст");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("Текст без знаков препинания: ");

        // так как строка - это массив char, мы можем вызвать метод  except  и удалить знаки препинания
        var noPunctuation = text.Except(punctuation).ToArray();

        // вывод
        Console.WriteLine(noPunctuation);

    }

}
