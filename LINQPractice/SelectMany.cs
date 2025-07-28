using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LINQPractice;

public class SelectMany
{
    /// <summary>
    /// /Условие:
        //Есть список магазинов, каждый содержит список продуктов. Нужно получить единый список всех продуктов.
    /// </summary>
    public static void Task1()
    {
        var stores = new List<Store>()
        {
        new Store {Product = new List<string> {"Bread", "Orange", "Milk"} },
        new Store { Product = new List<string> { "Chocolate", "Sugar", "Bananas" } },
        new Store { Product = new List<string> { "Coffee", "Tea", "Coca-Cola" } }
        };
        var result = stores.SelectMany(s => s.Product).OrderBy(p => p).ToList();
        foreach (var store in result)
        {
            Console.WriteLine(store);
        }
        //Query 
        var result2 = from store in stores
                      from product in store.Product
                      orderby product
                      select product;

        foreach (var store in result2)
            Console.WriteLine(store);

    }
    /// <summary>
    ///  Есть список точек, каждая точка содержит список координат.Получить все координаты в один список.
    /// </summary>
    public static void Task2()
    {
        var points = new List<Point>()
        {
            new Point { Coordinate = new List<int> { 1, 2, 3 } },
            new Point { Coordinate = new List<int> { 4, 5, 6 } },
            new Point { Coordinate = new List<int> { 7, 8, 9 } },

        };
        var result = points.SelectMany(p => p.Coordinate).OrderBy(p => p).ToList();
        foreach (var point in result)
        {
            Console.WriteLine(point);
        }
        // Query 
        var result2 = from point in points
                      from coordinate in point.Coordinate
                      orderby coordinate
                      select point;

        foreach (var point in result2)
        {
            Console.WriteLine(point);
        }

    }
    /// <summary>
    /// Есть список заказов, каждый заказ содержит список товаров. Нужно получить список всех товаров с указанием цены.
    /// </summary>
    public static void Task3()
    {
        var orders = new List<Order>()
        {
            new Order
            {
                Products = new List<Product>
                {
                    new Product {Name = "Item 1", Price= 10 },
                    new Product{Name = "Item 2", Price = 20 }
                }
            },
            new Order
            {
                Products = new List<Product>
                {
                    new Product{Name = "Item 3", Price =30},
                    new Product{Name = "Item 4", Price=35}
                }
            }
        };
        var allProductswithPrice = orders.SelectMany(o => o.Products).Select(p => new { p.Name, p.Price });
        foreach (var product in allProductswithPrice)
            Console.WriteLine($"Product: {product.Name}, Price: {product.Price} ");

        //Query
        var result = from order in orders
                     from product in order.Products
                     orderby product
                     select product;
        foreach (var product in result)
        {
            Console.WriteLine($"Product: {product.Name}, Price: {product.Price} ");
        }


    }
    /// <summary>
    /// Есть список предложений, каждое предложение содержит список слов. Нужно получить список всех слов.
    /// </summary>
    public static void Task4()
    {
        var sentences = new List<string[]>
        {
            new string[] { "Привет", "как", "дела" },
            new string[] {"Все", "хорошо", "спасибо" },
            new string[] {"А", "у", "вас" }
        };
        var result = from sentence in sentences
                     from word in sentence
                     orderby word
                     select word;
        foreach (var word in result)
        {
            Console.WriteLine(word);
        }

        //Extansiom
        var result2 = sentences.SelectMany(s => s).OrderBy(word => word);
        foreach (var word in result2)
        {
            Console.WriteLine(word);
        }
    }
}
public class Store
{
    public List<string> Product;
}
public class Point
{
    public List<int> Coordinate;
}
public class Order
{
    public List<Product> Products { get; set; }
}
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
}


