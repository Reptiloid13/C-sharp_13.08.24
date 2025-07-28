using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice;

public class WhereFiltration
{
    /// <summary>
    ///  Отфильтровать четные числа из списка
    /// </summary>
    public static void Task1()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result = from num in numbers
                     where num % 2 == 0
                     orderby num
                     select num;
        foreach (var num in result)
            Console.Write(num + " ");

        //EXtansion
        var result2 = numbers.Where(n => n % 2 == 0);
        foreach (var num in result)
            Console.Write(num + " ");


    }
    /// <summary>
    /// Выбрать слова длиннее 4 символов
    /// </summary>
    public static void Task2()
    {
        var words = new List<string> { "кот", "собака", "мышь", "слон", "тигр", "крокодил" };

        var result = from word in words
                     where word.Length > 4
                     select word;

        foreach (var word in result)
        {
            Console.WriteLine(word);
        }
        //Extansion 
        var result2 = words.Where(word => word.Length > 4);

        foreach (var word in result2)
            Console.WriteLine(word);

    }
    /// <summary>
    ///  Фильтрация по нескольким условиям
    /// Условие: Выбрать товары стоимостью больше 20 и в наличии
    /// </summary>
    public static void Task3()
    {
        var products = new List<Product>
        {
            new Product { Name = " Item 1", Price = 50, IsAvailable = true },
            new Product { Name = "Item 2", Price = 15, IsAvailable = false },
            new Product { Name = "Item 3", Price = 25, IsAvailable = true },
            new Product { Name = "Item 4", Price = 12, IsAvailable = true },

        };
        var result = from product in products
                     where product.Price > 20 && product.IsAvailable == true
                     orderby product
                     select product;

        foreach (var product in result)
            Console.WriteLine(product);

        //Extansion
        var result2 = products
            .Where(product => product.Price > 20 && product.IsAvailable == true);


    }
    /// <summary>
    /// Задача 4: Фильтрация с использованием OR
    ///Условие: Выбрать пользователей с ролью “admin” или “moderator”
    /// </summary>
    public static void Task4()
    {
        var users = new List<User>
        {
          new User { Name = "Иван", Role = "user" },
        new User { Name = "Петр", Role = "admin" },
        new User { Name = "Анна", Role = "moderator" },
        new User { Name = "Мария", Role = "guest" }
        };
        var result = from user in users
                     where user.Role == "admin" || user.Role == "moderator"
                     orderby user.Name
                     select user;
        foreach (var user in result)
            Console.WriteLine(user);

        //Extansion
        var result2 = users
            .Where(u => u.Role == "admin" || u.Role == "moderator")
            .OrderBy(u => u.Name); ;
        foreach (var user in result2)
            Console.WriteLine(user);
    }
}
public class User
{
    public string Name { get; set; }
    public string Role { get; set; }

}
