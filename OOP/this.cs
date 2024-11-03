namespace OOP;

public class Transport
{
    public string Name;
    public int Speed;

    public Transport(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public void Drive()
    {
        Console.WriteLine($"Машина едет: {this.Name}");
    }
}

class TransportTask
{
    public static void Test()
    {
        var car = new Transport("Car", 100);

        var truck = new Transport("Truck", 200);

        var bus = new Transport("Bus", 300);
        bus.Drive();
    }
}