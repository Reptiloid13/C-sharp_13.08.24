namespace OOP;

public class Car
{
    public int Speed;
    public string Name;

    public Car(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }

    public void Drive()
    {
        Console.WriteLine($"Машина едет: {Name}");
    }

    public static int GetMaxSpeed()
    {
        return 1;
    }
}

class CarTask
{
    public static void Test()
    {
        var car = new Car(120, "BMW");
        var car1 = new Car(210, "Lada");
        var car2 = new Car(110, "Opel");

        car.Drive();
        car1.Drive();

        var maxSpeedEver = Car.GetMaxSpeed(); // 210
        Console.WriteLine(maxSpeedEver);
    }
}