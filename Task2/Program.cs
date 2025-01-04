using System.Net.Http.Headers;
using Task2;



var milk = new Product() { Size = 1, Name = "Milk", Price = 10 };
var water = new Product() { Size = 2, Name = "Water", Price = 5 };
var cola = new Product() { Size = 3, Name = "Cola", Price = 15 };
var chocolate = new Product() { Size = 4, Name = "Chocolate", Price = 20 };

var vendingMachine = new VendingMachine() { Capacity = 10 };

vendingMachine.AddProduct(milk);
vendingMachine.AddProduct(water);
vendingMachine.AddProduct(cola);
vendingMachine.AddProduct(chocolate);

// Здесь нужно передать делегат и писать в консоль, что осталось
// половина продуктов

//Здесь нужно передать делегат и писать в консоль, что осталась треть продуктов

// десь нужно писать в консоль, что все продукты куплены и автомат пустой 


namespace Task2
{

    class Product
    {
        public int Size;
        public string Name;
        public int Price;
    }

    class VendingMachine
    {
        private List<Product> Products = new List<Product>(); // Нужно ли здесь задать параметры Листу? 

        public int Money = 0;
        public int Capacity;

        public void Buy(Product product)
        {
            // Если такого продукта нет, выбросить исключение - ProductNotFoundException (Message = "Продукт не найден")
        }
        public void AddProduct(Product product)
        {
            // При превышении вместимости выбросить исключение  CapacityExceededException (Message = "Превышении вместимости") 
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


    }
}
