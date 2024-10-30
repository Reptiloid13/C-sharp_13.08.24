using SkillFactory;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


namespace SkillFactory
{
    class Program
    {
        static void Main()
        {

            Order<HomeDeliverry> order1;



        }
    }




    class Vector
    {
        public int X;
        public int Y;

        public Vector Add(Vector second)// что акое вектор секонд? 

        {
            return new Vector
            {
                X = this.X + second.X,
                Y = this.Y + second.Y
            }; // почему ; за квадратными скобака? 
        }
    } // Вопросы

    class Order1<T>
    {
        public T Number;
        public string Descrtiption;

    } // Обобщение!

    class Recordd<T1, T2>
    {
        public T1 Id;
        public DateTime Date;
        public T2 Value;

    }

    class Order<T> where T : Delivery
    {
        public int Number;
        public string Descrtiption;

        public void DisplayAddress()
        {
            Console.WriteLine("Delivery.Address");
        }
    }
    abstract class Delivery
    {
        public string Address;
    }
    class HomeDeliverry : Delivery { }
    class PickPoint : Delivery { }
    class ShopDelivery : Delivery { }






}

