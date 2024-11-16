

namespace Playground;

class Program
{
    public static void Main()
    {
        List<ProductItem> products =
        [
            new ProductItem(new Product("Product 1", "Description 1", 10.99m, 1, 5), 1),
            new ProductItem(new Product("Product 2", "Description 2", 19.99m, 2, 3), 1),
            new ProductItem(new Product("Product 3", "Description 3", 5.99m, 3, 2), 1)
        ];
        var address = new Adress("City", 123, "Street", 1, 1);
        var customer = new Customer("John Doe", "123 Main St", "123-456-7890", address);



        var shopDelivery = new ShopDelivery(DateTime.Now, address);

        var courier = new Courier("John Doe", "123 Main St", "1234567890", 1);
        var homeDelivery = new HomeDelivery(DateTime.Now, address, courier);

        var order1 = new Order<ShopDelivery>(products, customer, shopDelivery);
        var order2 = new Order<HomeDelivery>(products, customer, homeDelivery);


    }
}
class Order<T> where T : Delivery
{
    private List<ProductItem> _products;
    private T _delivery;
    private Customer _customer;

    public Order(List<ProductItem> products, Customer customer, T delivery)
    {
        _products = products;
        _delivery = delivery;
        _customer = customer;
    }
}
class ProductItem
{
    public Product Product { get; set; }
    public int Quantity { get; private set; }

    public ProductItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public void IncreaseQuantity() => Quantity++;
    public void DecreaseQuantity() => Quantity--;
}

class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Id { get; set; }
    public int Quantity { get; set; }

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
    public string PhoneNumber { get; set; }

    public Person(string secondName, string firstName, string phoneNumber)
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
    public Adress Address;
    public string ReviewText { get; set; }

    public Customer(string secondName, string firstNamem, string phoneNumber, Adress address) : base(secondName,
        firstNamem, phoneNumber)
    {
    }

    public void AddReview()
    {
        Console.WriteLine($"Отзвы добавлен: {ReviewText}");
    }
}

class Adress
{
    public string City;
    public int Index;
    public string Street;
    public int NumberHouse;
    public int NumberApartament;

    public Adress(string city, int index, string street, int numberHouse, int numberApartament)
    {
        City = city;
        Index = index;
        Street = street;
        NumberHouse = numberHouse;
        NumberApartament = numberApartament;
    }

    public virtual void GetFullAddress()
    {
        Console.WriteLine(
            $" Город -  {City}, Индекс -  {Index}, Улица -  {Street},Номер дома -  {NumberHouse}, Квартира -  {NumberApartament}");
    }
}

class Courier : Person
{
    private int _id;

    public Courier(string secondName, string firstName, string phoneNumber, int id)
        : base(secondName, firstName, phoneNumber)
    {
        _id = id;
    }

    public override void GetFullName()
    {
        base.GetFullName();
        Console.WriteLine($"ID Курьера {_id}");
    }
    //public override void GetFullAddress()
    //{
    //    base.GetFullAddress();


    //}
}

abstract class Delivery
{
    public abstract void Deliver(Product product);
    public DateTime DeliveryDate { get; set; }
    public Adress DeliveryAddress { get; set; }

    protected Delivery(DateTime deliveryDate, Adress deliveryAddress)
    {
        DeliveryDate = deliveryDate;
        DeliveryAddress = deliveryAddress;
    }

}

class HomeDelivery : Delivery
{
    public Courier DeliveryCourier { get; set; }
    public Adress CustomerAddress { get; set; }

    public HomeDelivery(DateTime deliveryDate, Adress customerAddress, Courier deliveryCourier)
        : base(deliveryDate, customerAddress)
    {
        DeliveryCourier = deliveryCourier;
        CustomerAddress = customerAddress;
    }

    public override void Deliver(Product product)
    {
        Console.WriteLine("HomeDelivery");
    }
}

class PickPoint : Delivery
{
    private Courier _courier;
    private Adress _courierPickPointAddress;

    public PickPoint(DateTime deliveryDate, Adress customerAddress, Courier courier, Adress courierPickPointAddress) :
        base(deliveryDate, customerAddress)
    {
        _courier = courier;
        _courierPickPointAddress = courierPickPointAddress;
    }

    public override void Deliver(Product product)
    {
        Console.WriteLine("PickPoint");

    }
}

class ShopDelivery : Delivery
{
    public ShopDelivery(DateTime deliveryDate, Adress customerAddress)
        : base(deliveryDate, customerAddress)
    {
    }

    public override void Deliver(Product product)
    {
        Console.WriteLine($" Товар  доставлен в магазин ");
    }
}