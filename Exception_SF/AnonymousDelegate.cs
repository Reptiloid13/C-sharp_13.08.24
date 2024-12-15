using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_SF.Anonymous
{
    internal class AnonymousDelegate
    {
        public static void Example1()
        {
            GreetingsDelegate gd = new GreetingsDelegate(AnonymousDelegate.Greetings);
            string GreetingsMessage = gd.Invoke("Future Guru");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }

        public delegate string GreetingsDelegate(string name);
        public static string Greetings(string name)
        {
            return $" Hello {name}! Wellcome to SF";
        }


        public delegate string GreetingsDelegate1(string name);
        public static void Example12()
        {
            GreetingsDelegate1 gd = delegate (string name)
            {
                return $" Hello {name}! Wellcome to SF";
            };
            string GreetingsMessage = gd.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }

        public delegate int CalculateDelegate(int a, int b);
        public static void Calculate(int a, int b)
        {
            CalculateDelegate calculateDelegate = delegate (int a, int b)
            {
                return a + b;
            };
            int result = calculateDelegate.Invoke(50, 10);
        }


        //Существует следующее консольное решение, которое отображает сообщение Hello World в консольном сообщении:
        public delegate void ShowMessageDelegate(string _message);
        public static void Task9312()
        {
            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }


        // Существует консольное решение, которое выводит случайное целое число в диапазоне от 0 до 100 и отображает результат в консольное сообщение:
        public delegate int RandomNumberDelegate();
        public static void Task9313()
        {
            RandomNumberDelegate randomNuumber = delegate
            {
                return new Random().Next(0, 100);
            };
            int result = randomNuumber.Invoke();
            Console.WriteLine(result);

        }

    }
}
