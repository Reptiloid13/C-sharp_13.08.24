// Здесь нужно передать делегат и писать в консоль, что осталось
// половина продуктов

//Здесь нужно передать делегат и писать в консоль, что осталась треть продуктов

// десь нужно писать в консоль, что все продукты куплены и автомат пустой 

using System.Runtime.Intrinsics;
using System.Security.Cryptography;
using static Delegates.VendingMachineTask;

namespace Delegates
{
    class VendingMachineTask
    {
        public static void Start()
        {
            var milk = new Product() { Size = 1, Name = "Milk", Price = 10 };
            var water = new Product() { Size = 2, Name = "Water", Price = 5 };
            var cola = new Product() { Size = 3, Name = "Cola", Price = 15 };
            var chocolate = new Product() { Size = 4, Name = "Chocolate", Price = 20 };

            var vendingMachine = new VendingMachine() { Capacity = 10 };

            vendingMachine.OnRichFullness50 = () => Console.WriteLine("Треть продуктов");
            vendingMachine.OnRichFullness33 = () => Console.WriteLine("Половина продуктов");
            vendingMachine.OnSoldOut = () => Console.WriteLine("Все продукты куплены и автомат пустой");

            vendingMachine.AddProduct(milk);
            vendingMachine.AddProduct(water);
            vendingMachine.AddProduct(cola);
            vendingMachine.AddProduct(chocolate);


            vendingMachine.Buy(milk);
            vendingMachine.Buy(water);
            vendingMachine.Buy(cola);
            vendingMachine.Buy(chocolate);
            // Покупка уже проданного продукты для теста


            // А что нужно вызывать ? 



        }

        public class Product
        {
            public int Size;
            public string Name;
            public int Price;
        }

        public delegate void OnFullnessChanged();

        public class VendingMachine
        {
            private List<Product> Products = new List<Product>();
            private int fullness = 0;

            public OnFullnessChanged OnRichFullness50;
            public OnFullnessChanged OnRichFullness33;
            public OnFullnessChanged OnSoldOut;

            public int Money = 0;
            public int Capacity;

            public void Buy(Product product)
            {
                // Если такого продукта нет, выбросить исключение - ProductNotFoundException (Message = "Продукт не найден")

                if (!Products.Contains(product))
                {
                    throw new ProductNotFoundException("Продукт не найден");
                }
                Products.Remove(product);
                Console.WriteLine(Products);
                Money += product.Price;
                Console.WriteLine(Money);

                fullness = Products.Count;
                Console.WriteLine(Products.Count);
                CheckFullness();



            }

            public void AddProduct(Product product)
            {
                // При превышении вместимости выбросить исключение  CapacityExceededException (Message = "Превышении вместимости") 

                if (Products.Count >= Capacity)
                {
                    throw new CapacityExceededException("Превышение вместимости");
                }

                Products.Add(product);
                fullness = Products.Count;
                CheckFullness();

            }
            private void CheckFullness()
            {
                if (fullness == Capacity / 2 && OnRichFullness50 != null)
                {
                    OnRichFullness50.Invoke();
                }
                if (fullness == Capacity / 3 && OnRichFullness33 != null)
                {
                    OnRichFullness33.Invoke();
                }
                if (fullness == 0 && OnSoldOut != null) // Почему тут не равен null
                {
                    OnSoldOut.Invoke();
                }
            }
        }
    }

    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message) { }
    }
    public class CapacityExceededException : Exception
    {
        public CapacityExceededException(string message) : base(message) { }
    }

}
