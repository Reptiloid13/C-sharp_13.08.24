namespace Delegates
{
    class Test
    {
        static void Main()
        {
            // VendingMachineTask.Start();
            //LibaryTask.Start2();
            //DelegateArray2_1.Start();
            //CityTask.Start();

            var button1 = new Button();
            button1.OnClick = PrintTextParent;
        }

        public static void PrintTextParent()
        {
            PrintText("Hello");
        }

        public static void PrintText(string text)
        {
            Console.WriteLine(text);
        }
    }

    // Делегат - Тип данных
    public delegate void EmptyDelegate();

    class Button
    {
        public EmptyDelegate OnClick;
    }
}