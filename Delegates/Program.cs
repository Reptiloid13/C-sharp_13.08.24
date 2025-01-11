namespace Delegates
{
    class Test
    {
        static void Main()
        {
            // VendingMachineTask.Start();
            // LibaryTask.Start2();
            // DelegateArray2_1.Start();
            // CityTask.Start();

            var button1 = new Button();
            
            button1.OnClick = PrintText;
            button1.OnClick = PrintText("Hello");
            button1.OnClick = PrintText();
            // 1) PrintText - 0 аргументов, а мы отправляем 1 аргумент
            // 2) PrintText() возвращает void
            button1.OnClick = () => PrintText("Hello");
            // Анонимная функция подходит под EmptyDelegate
            // 1) PrintText - 0 аргументов, а мы отправляем 1 аргумент
            
            button1.OnClick = () => PrintText();
            
            var lambda = () =>
            {
                Console.WriteLine("Hello1");
                Console.WriteLine("Hello2");
                return 1;
            };

            NotLambda();
            var one = lambda();
        }

        public static void NotLambda()
        {
            Console.WriteLine("Hello1");
            Console.WriteLine("Hello2");
        }

        public static void PrintText()
        {
            Console.WriteLine("Hello");
        }
    }

    // Делегат - Тип данных
    public delegate void EmptyDelegate();

    class Button
    {
        public EmptyDelegate OnClick;
    }
}