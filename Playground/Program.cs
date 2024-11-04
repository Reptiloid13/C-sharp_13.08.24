using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.XPath;

class Program
{



    public class MainClass
    {

        public static void Main()
        {
            Product product = new Product("ключи", 12, 123, 4);
            Console.WriteLine(product.ToString());
            Courier courier = new Courier(98745);
            courier.Deliver(product);




        }
    }

    class Order<T> where T : Delivery

    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }


    }
    //{
    //    public int Number;
    //    public string Descrtiption;

    //    public void DisplayAddress()
    //    {
    //        Console.WriteLine("Delivery.Address");
    //    }
    //}
    class Product : Order<Delivery>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Id { get; private set; }
        public int Quantity { get; set; }


        public Product(string name, decimal price, int id, int quantity)
        {
            Name = name;
            Price = price;
            Id = id;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name} - {Quantity}шт., цена за единцу: {Price:f2}, общая стоимость: {(Price * Quantity):f2}";
        }
        public decimal TotalPrice => Price * Quantity;
    }

    abstract class Delivery
    {
        public abstract void Deliver(Product product);
    }
    class Courier : Delivery
    {
        private int _id;
        private DateTime _nextDeliveryTime;

        public Courier(int id)
        {
            _id = id;
            _nextDeliveryTime = DateTime.Now;
        }
        public override void Deliver(Product product)
        {
            Console.WriteLine($"{product.Name} доставлен курьером {_id}!");
            _nextDeliveryTime = _nextDeliveryTime.AddMinutes(15);
        }
        public DateTime NextDeliveryTime => _nextDeliveryTime;
    }




    class HomeDelivery : Delivery
    {
        public override void Deliver(Product product)
        {
            Console.WriteLine($"{product.Name} доставлен курьером!");
        }
    }
    class PickPoint : Delivery
    {
        private string _address;
        private bool _isAvailable;

        public PickPoint(string address)
        {
            _address = address;
        }
        public override void Deliver(Product product)
        {
            Console.WriteLine($"Заказ {_isAvailable} доставлен в постомат по адресу: {_address}");
        }

    }
    class ShopDelivery : Delivery
    {
        public string Name { get; set; }
        public int Quanttity { get; set; }

        public ShopDelivery(string name, int quanttity)
        {
            Name = name;
            Quanttity = quanttity;
        }
        public override void Deliver(Product product)
        {
            Console.WriteLine($" Товар {Name} доставлен в магазин {Quanttity}");
        }
    }
}

class Person
{
    public string Name;
    public static int count = 0;

    public Person(string name)
    {
        Name = name;
        count++;
    }

    public static void SayHello(string name)
    {
        Console.WriteLine($"Привет, меня зовут {name}");
    }

    public void SayHello1()
    {
        Console.WriteLine($"Привет, меня зовут {Name}");
    }


