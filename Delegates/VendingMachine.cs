// Здесь нужно передать делегат и писать в консоль, что осталось
// половина продуктов

//Здесь нужно передать делегат и писать в консоль, что осталась треть продуктов

// десь нужно писать в консоль, что все продукты куплены и автомат пустой 

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
            
            var bread = new Product() { Size = 4, Name = "Хлеб", Price = 20 };
            
            var logger = new Logger("C:\\Users\\New");
            var flashLogger = new Logger("F://");
            
            logger.Log("Продукт куплен");
            logger.Log("Продукт куплен");
            logger.Log("Продукт куплен");
            logger.Log("Продукт куплен");
            
            flashLogger.Log("Продукт куплен");
            flashLogger.Log("Продукт куплен");
            flashLogger.Log("Продукт куплен");
            flashLogger.Log("Продукт куплен");
            
            Logger.Log("C:\\Users\\New", "Продукт куплен");
            Logger.Log("C:\\Users\\New", "Продукт куплен");
            Logger.Log("C:\\Users\\New", "Продукт куплен");

            Console.WriteLine();

            var console = new Console();
                
            console.WriteLine();
            
            // ProductNotFoundException
            vendingMachine.Buy(bread);
            
            var console = new Console()
            console.WriteLine();
        }
    }

    class Product
    {
        public int Size;
        public string Name;
        public int Price;
    }

    public delegate void OnFullnessChanged();

    class VendingMachine
    {
        private List<Product> Products = new List<Product>();
        private int fullness = 0; // заполненность

        public OnFullnessChanged OnRichFullness50;
        public OnFullnessChanged OnRichFullness33;
        public OnFullnessChanged OnSoldOut;

        public int Money = 0;
        public int Capacity; // вместимости автомата - не меняется

        public void Buy(Product product)
        {
            // Если такого продукта нет, выбросить исключение - ProductNotFoundException (Message = "Продукт не найден")
        }

        public void AddProduct(Product product)
        {
            // При превышении вместимости выбросить исключение  CapacityExceededException (Message = "Превышении вместимости") 
        }
    }
}