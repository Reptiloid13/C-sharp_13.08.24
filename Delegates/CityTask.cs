﻿namespace Delegates
{
    public class CityTask
    {
        // 1) makeCrime()
        // 2) OnMakeCrime() = () => Call112()
        // 3) Call112()
        // 4) Console.WriteLine("Криминал");

        //решить при помощи делегата 
        public static void Start()
        {
            var city = new City();

            city.OnMakeCrime = () => Help.Call112(EventType.Crime);
            city.MakeCrime();

            city.OnMakeFire = () => Help.Call112(EventType.Fire);
            city.MakeFire();

            city.OnMakeExplosion = () => Help.Call112(EventType.Explosion);
            city.MakeExplosion();

            city.OnMakeAccident = () => Help.Call112(EventType.Accident);
            city.MakeAccident();
            // Todo: сделать для остальных событий +
        }
    }

    public delegate void OnEventStart();

    public class City
    {
        public OnEventStart OnMakeCrime;

        public void MakeCrime()
        {
            Help.Call112(EventType.Crime);
            Console.WriteLine("Криминал");
        }
        public OnEventStart OnMakeFire;
        public void MakeFire()
        {
            Help.Call112(EventType.Fire);
            Console.WriteLine("Пожар");
        }
        public OnEventStart OnMakeExplosion;
        public void MakeExplosion()
        {
            Help.Call112(EventType.Explosion);
            Console.WriteLine("Взрыв");
        }
        public OnEventStart OnMakeAccident;
        public void MakeAccident()
        {
            Help.Call112(EventType.Accident);
            Console.WriteLine("Происшествие");
        }
    }

    public enum EventType
    {
        Crime = 0,
        Fire = 1,
        Explosion = 2,
        Accident = 3
    }

    public class Help
    {
        // Todo: не дублировать "Вызов 112 причина"
        public static void Call112(EventType type)
        {
            if (type == EventType.Crime)
            {
                Console.WriteLine($"Вызов 112 причина: Криминал");
                return;
            }

            if (type == EventType.Fire)
            {
                Console.WriteLine($"Вызов 112 причина: Пожар");
                return;
            }

            if (type == EventType.Explosion)
            {
                Console.WriteLine($"Вызов 112 причина: Взрыв");
                return;
            }

            if (type == EventType.Accident)
            {
                Console.WriteLine($"Вызов 112 причина: Несчастье");
            }
        }
    }

}