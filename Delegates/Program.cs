using System.Globalization;
using Task2;

namespace Delegates
{
    class Test
    {
        static void Main()
        {

            FinallyTask.TaskDeleg();


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