using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collections;

public class Dictionary
// Словарь - Хранит объуеты, которые представляют пару ключ - значение, то есть
// обращаясь по ключу, мы можем получить значение.

{
    private static Dictionary<string, ContactForDic> PhoneBook = new Dictionary<string, ContactForDic>()
    {
        ["Игорь"] = new ContactForDic(79990000000, "igor@example.com"),
        ["Андрей"] = new ContactForDic(79990000001, "andrew@example.com"),
    };
    public static void DictionaryTasks()
    {
        // Запустим таймер
        var watchTwo = Stopwatch.StartNew();

        PhoneBook.TryAdd("Диана", new ContactForDic(79160000002, "diana@example.com"));

        Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");

        // WriteAllContacts();
    }
    public static void WriteAllContacts()
    {
        foreach (var contact in PhoneBook)
        {
            Console.WriteLine(contact.Key + ":" + contact.Value.PhoneNumber);
            Console.WriteLine();
        }
    }
    public static void ExampleDictionary()
    {
        // Создадим словарь. Ключом будет строка, а значением - массив строк

        var cities = new Dictionary<string, string[]>(3);/*Размер (указывать необязательно))*/

        // Добавим новые значения

        cities.Add("Russia", new[] { "Moscow", "Saint-Petersburg, Volgograd" });
        cities.Add("Ukraine", new[] { "Kiev", "Lvov", "Odessa", "Uman" });
        cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно" });

        //  Посмотрим всё что есть в словаре
        foreach (var citiesByCountry in cities)
        {
            Console.WriteLine(citiesByCountry.Key + ":");

            foreach (var city in citiesByCountry.Value)
                Console.WriteLine(city + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        // Теперь попробуем вывести значения по ключу
        var russianCities = cities["Russia"];
        Console.WriteLine("Russian cities: ");
        foreach (var city in russianCities)
            Console.WriteLine(city);
    }

}
public class ContactForDic
{

    public long PhoneNumber { get; set; }
    public string Email { get; set; }

    public ContactForDic(long phoneNumber, string email)
    {

        PhoneNumber = phoneNumber;
        Email = email;
    }




}

public class SortedDictionary()
{
    private static SortedDictionary<string, ContactForDic> SortedPhoneBook = new SortedDictionary<string, ContactForDic>()
    {
        ["Игорь"] = new ContactForDic(79990000000, "igor@example.com"),
        ["Андрей"] = new ContactForDic(79990000001, "andrew@example.com"),
    };
    public static void SortedExample()
    {
        // Создаем сортированный словарь
        SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
        // Добавим несколько элементов в случайном порядке

        sortedDictionary.Add("zebra", 5);
        sortedDictionary.Add("cat", 2);
        sortedDictionary.Add("dog", 9);
        sortedDictionary.Add("mouse", 4);
        sortedDictionary.Add("programmer", 100);
        // Ищем собаку

        if (sortedDictionary.ContainsKey("dog"))
            Console.WriteLine("Нашли собаку");

        if (sortedDictionary.ContainsKey("zebra"))
            Console.WriteLine("Нашли зебру");

        if (sortedDictionary.ContainsKey("ape"))
            Console.WriteLine("Нашли обезьяну");

        Console.WriteLine();

        // Теперь посмотрим, кто у нас живёт и в каком порядке
        Console.WriteLine("Посмотрим всех: ");

        foreach (KeyValuePair<string, int> p in sortedDictionary)
            Console.WriteLine($"{p.Key} = {p.Value}");
    }

    public static void SortedTask1345()
    {

        // Запустим таймер
        var watchTwo = Stopwatch.StartNew();

        SortedPhoneBook.TryAdd("Диана", new ContactForDic(79160000002, "diana@example.com"));

        Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
    }
}
