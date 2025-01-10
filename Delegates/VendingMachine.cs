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
            var milk = new Product() { Size = 4, Name = "Milk", Price = 10 };
            var water = new Product() { Size = 2, Name = "Water", Price = 5 };
            var cola = new Product() { Size = 3, Name = "Cola", Price = 15 };
            var chocolate = new Product() { Size = 1, Name = "Chocolate", Price = 20 };

            var vendingMachine = new VendingMachine() { Capacity = 10 };

            vendingMachine.OnRichFullness50 = () => Console.WriteLine("Треть продуктов");
            vendingMachine.OnRichFullness33 = () => Console.WriteLine("Половина продуктов");
            vendingMachine.OnSoldOut = () => Console.WriteLine("Все продукты куплены и автомат пустой");

            vendingMachine.AddProduct(milk);
            vendingMachine.AddProduct(water);
            vendingMachine.AddProduct(cola);
            vendingMachine.AddProduct(chocolate);

            vendingMachine.Buy(milk); // 4
            vendingMachine.Buy(water); // 2
            // Console.WriteLine("Половина продуктов");
            vendingMachine.Buy(cola); // 3
            // Console.WriteLine("Треть продуктов");
            vendingMachine.Buy(chocolate); // 1
            // Console.WriteLine("Все продукты куплены и автомат пустой");
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

            public OnFullnessChanged OnRichFullness50 = null;
            public OnFullnessChanged OnRichFullness33 = null;
            public OnFullnessChanged OnSoldOut = null;

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
                Money += product.Price;

                // Todo+
                fullness += product.Size;

                CheckFullness();
            }

            public void AddProduct(Product product)
            {
                // При превышении вместимости выбросить исключение  CapacityExceededException (Message = "Превышении вместимости") 

                if (fullness + product.Size > Capacity)
                {
                    throw new CapacityExceededException("Превышение вместимости");
                }

                Products.Add(product);
                fullness += product.Size;
                CheckFullness();
            }


            private void CheckFullness()
            {
                // Todo
                // 10 -> 6 -> 4 
                // 3.33 == 10 > 9 > 8 > 7 > 6 > 5 > 4 > 3 > 2 > 1 > 0
                if (fullness == Capacity / 2 && OnRichFullness50 != null)
                {
                    OnRichFullness50();
                }



                if (fullness == Capacity / 3 && OnRichFullness33 != null)
                {
                    OnRichFullness33();
                }

                if (fullness < Capacity / 2 && fullness > Capacity / 3)
                {
                    Console.WriteLine($"Продуктов в автомате - {fullness}");
                }

                if (fullness == 0 && OnSoldOut != null)
                {
                    OnSoldOut();
                }

            }
        }
    }
}


public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(string message) : base(message)
    {
    }
}

public class CapacityExceededException : Exception
{
    public CapacityExceededException(string message) : base(message)
    {
    }
}
