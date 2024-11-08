using System;
using System.ComponentModel.Design;
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
    public string PersonAdress;
    public string ReviewText { get; set; }
    public Customer(string secondName, string firsNamem, int phoneNumber) : base(secondName, firsNamem, phoneNumber) { } // Интуитивно что то смущает, все ли ок? 


    public void AddReview()
    {
        Console.WriteLine("Отзвы добавлен");
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

abstract class Delivery
{
    public abstract void Deliver(Product product);
    public int DeliveryDate;
    public int DeliveryAddress;

}
class Courier : Person
{
    private int _id;
    private DateTime _nextDeliveryTime;

    public Courier(string secondName, string firstName, int phoneNumber) : base(secondName, firstName, phoneNumber);



    public override void GetFullName()
    {
        Console.WriteLine($"{SecondName}, {FirstName}, телефон - {PhoneNumber}");
    }

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

