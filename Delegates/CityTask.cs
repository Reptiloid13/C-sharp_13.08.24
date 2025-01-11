namespace Delegates
{
    public class CityTask
    {
        // 1) city.OnMakeCrime = () => Call112()
        // 2) makeCrime()
        // 3) city.OnMakeCrime() -> Call112()
        // 4) Console.WriteLine("Криминал");

        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        //решить при помощи делегата 
        public static void Start()
        {
            var city = new City();

            city.OnMakeCrime = PrintHello;
            city.OnMakeCrime = () =>  Console.WriteLine("Hello");
            city.MakeCrime();

            city.OnMakeFire = () => Help.Call112(EventType.Fire);
            // city.OnMakeFire = Help.Call112;
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
        public OnEventStart OnMakeCrime = null;
        public OnEventStart OnMakeFire = null;
        public OnEventStart OnMakeExplosion = null;
        public OnEventStart OnMakeAccident = null;

        public void MakeCrime()
        {
            Help.Call112(EventType.Crime);
            Console.WriteLine("Криминал");
        }
        
        public void MakeFire()
        {
            Help.Call112(EventType.Fire);
            Console.WriteLine("Пожар");
        }
        
        public void MakeExplosion()
        {
            Help.Call112(EventType.Explosion);
            Console.WriteLine("Взрыв");
        }
        
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