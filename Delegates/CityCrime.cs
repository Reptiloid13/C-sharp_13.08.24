using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class CityCrime
    {
        public delegate void EventDelegate();

        //решить при помощи делегата 
        public static void Start3()
        {
            var city = new City();

            EventDelegate crimeEvent = city.MakeCrime;
            EventDelegate fireEvent = city.MakeFire;
            EventDelegate explosionEvent = city.MakeExplosion;
            EventDelegate accidentEvent = city.MakeAccident;


        }
    }

    public class City
    {
        public void MakeCrime()
        {
            Help.Call112(EvenType.Crime);
            Console.WriteLine("Криминал");
        }

        public void MakeFire()
        {
            Help.Call112(EvenType.Fire);
            Console.WriteLine("Пожар");

        }

        public void MakeExplosion()
        {
            Help.Call112(EvenType.Explosion);
            Console.WriteLine("Взрыв");
        }

        public void MakeAccident()
        {
            Help.Call112(EvenType.Accident);
            Console.WriteLine("Происшествие");
        }
    }

    enum EvenType
    {
        Crime = 0,
        Fire = 1,
        Explosion = 2,
        Accident = 3
    }

    public class Help
    {
        public static void Call112(EvenType type) // Что не так? 
        {
            string reason = type switch

            {
                EvenType.Crime => "Криминал",
                EvenType.Fire => "Пожар",
                EvenType.Explosion => "Взрыв",
                EvenType.Accident => "Инцидент"

            };

            Console.WriteLine($" Вызов 112 причина {reason}");
        }
    }
}
