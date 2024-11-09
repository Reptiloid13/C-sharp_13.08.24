using System;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.XPath;

class Program
{
    public static void Main()
    {

        Product product = new Product("Кровать", "Мягкая", 32, 001, 1);
        Console.WriteLine(product.ToString());



    }
}

class Order<T> where T : Delivery

{
    public List<string> Products = ["Кровать", "Диван", "Стул", "Подушка"];
    public int Quantity { get; set; }


}

class Product : Order<Delivery>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Id { get; set; }
    public int Quantuty;



    public Product(string name, string description, decimal price, int id, int quantity)
    {
        Name = name;
        Price = price;
        Id = id;
        Description = description;
        Quantity = quantity;
    }
    public override string ToString()
    {
        return $"{Name} - {Quantity}шт., цена за единцу: {Price:f2}, общая стоимость: {(Price * Quantity):f2}";
    }
    public decimal TotalPrice => Price * Quantity;
}

abstract class Person
{
    public string SecondName { get; set; }
    public string FirstName { get; set; }
    public int PhoneNumber { get; set; }

    public Person(string secondName, string firstName, int phoneNumber)
    {
        SecondName = secondName;
        FirstName = firstName;
        PhoneNumber = phoneNumber;

    }


    public virtual void GetFullName()
    {
        Console.WriteLine($"{SecondName}, {FirstName}, телефон - {PhoneNumber}");
    }
}

class Customer : Person
{
    public PersonAdress Address;
    public string ReviewText { get; set; }
    public Customer(string secondName, string firstNamem, int phoneNumber, PersonAdress address) : base(secondName, firstNamem, phoneNumber) { }

    public void AddReview()
    {
        Console.WriteLine($"Отзвы добавлен: {ReviewText}");
    }
}

class PersonAdress
{
    public string City;
    public int Index;
    public string Street;
    public int NumberHouse;
    public int NumberApartament;

    public PersonAdress(string city, int index, string street, int numberHouse, int numberApartament)
    {
        City = city;
        Index = index;
        Street = street;
        NumberHouse = numberHouse;
        NumberApartament = numberApartament;
    }
    public void GetFullAddress()
    {
        Console.WriteLine($" Город -  {City}, Индекс -  {Index}, Улица -  {Street},Номер дома -  {NumberHouse}, Квартира -  {NumberApartament}");
    }
}


class Courier : Person
{
    private int _id;


    public Courier(string secondName, string firstName, int phoneNumber, int id) : base(secondName, firstName, phoneNumber)
    { _id = id; }


    public override void GetFullName()
    {
        base.GetFullName();
        Console.WriteLine($"ID Курьера {_id}");
    }

}
abstract class Delivery
{
    public abstract void Deliver(Product product);
    public DateTime DeliveryDate { get; set; }
    public PersonAdress DeliveryAddress { get; set; }

    protected Delivery(DateTime deliveryDate, PersonAdress deliveryAddress)
    {
        DeliveryDate = deliveryDate;
        DeliveryAddress = deliveryAddress;

    }

}




class HomeDelivery : Delivery
{
    public Courier DeliveryCourier { get; set; }
    public PersonAdress CustomerAddress { get; set; }
    public HomeDelivery(DateTime deliveryDate, PersonAdress customerAddress, Courier deliveryCourier, PersonAdress customerAdress) : base(deliveryDate, customerAddress)
    {
        DeliveryCourier = deliveryCourier;
        CustomerAddress = customerAddress;
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

