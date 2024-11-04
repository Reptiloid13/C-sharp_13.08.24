using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace OOP;

//Задача: Создайте класс Car с приватным полем speed.
//    Реализуйте геттер и сеттер для скорости.
//    Сеттер должен проверять, находится ли входная скорость в диапазоне от 0 до 200 км/ч.
public class Car
{
    public int Speed;
    public string Name;
    private int _speed { get; set; }

    public int speed
    {
        set
        {
            if (value < 0 || value > 200)

                Console.WriteLine("Такой скорости у этой модели нет");
            else
                speed = value;
        }
        get { return speed; }
    }

    public Car(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }

    public void Drive()
    {
        Console.WriteLine($"Машина едет: {Name}");
    }

    public static int GetMaxSpeed(Car[] cars)
    {
        int maxSpeed = 0;
        foreach (var car in cars)
        {
            if (car.Speed > maxSpeed)
            {
                maxSpeed = car.Speed;
            }
        }

        return maxSpeed;
    }
    public void Reset()
    {
        Speed = 0;
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

        var maxSpeedEver = Car.GetMaxSpeed(new Car[] { car, car1, car2 }); // 210
        Console.WriteLine(maxSpeedEver);
        car.Reset();
        car1.Reset();
    }
}

//Напишите класс Triangle с приватными полями point1, point2 и point3.
//    Они будут типа Point.У Point есть x и y Реализуйте геттеры и сеттеры для этих полей, обеспечивая, чтобы сеттеры проверяли, 
//        являются ли входные значения правильными координатами.
// 1) Если хотя бы две точки совпадают
// 2) Если 3 точки лежат на одной прямой

public class GetPoints
{
    public static void Test()
    {
        var triangle = new Triangle();

        triangle.point1 = new Point() { X = 0, Y = 0 };
        triangle.point2 = new Point() { X = 1, Y = 1 };
        triangle.point3 = new Point() { X = 2, Y = 2 };
    }
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class Triangle
{
    public Point point1 { get; set; }
    public Point point2 { get; set; }
    public Point point3 { get; set; }
}

//4. Задача: Разработайте класс Time с приватными полями hours и minutes.Предоставьте геттеры и сеттеры для этих полей.
//    Сеттеры должны проверять, находятся ли входные значения в диапазоне от 0 до 23 для часов и от 0 до 59 для минут
//var time = new Time(); // 00:00:00
//time.seconds = 65; // 00:01:05

public class GetTime
{
    public static void Test()
    {
        Time time = new Time();
        time.Minutes = 61;
        time.Hours = 10; // часы не изменяются почему то 
        time.Seconds = 90;

        // 10:02:30
        Console.WriteLine(time.ToString());
    }
}

class Time
{
    private int hours { get; set; }
    private int minutes { get; set; }
    private int seconds { get; set; }

    public override string ToString()
    {
        return $"{hours}:{minutes}:{seconds}";
    }

    public int Hours
    {
        set
        {
            if (value < 0)
                Console.WriteLine(" Не то время");

            else if (value > 24)
            {
                Hours += value / 24;
                hours = value % 24;
            }
            else
                hours = value;
        }
        get { return hours; }
    }

    public int Minutes
    {
        set
        {
            if (value < 0) Console.WriteLine(" Не то время");

            else if (value > 60)
            {
                Minutes += value / 60;
                minutes = value % 60;
                hours++;
            }
            else
            {
                minutes = value;
            }
        }
        get { return minutes; }
    }

    public int Seconds
    {
        set
        {
            if (value < 0) Console.WriteLine("Не то время");
            else if (value > 60)
            {
                Seconds += value / 60;
                seconds = value % 60;
                minutes++;
            }
            else seconds = value;
        }
        get { return seconds; }
    }
}

//Задача: Создайте класс Password с приватным полем value. Реализуйте геттер и сеттер для пароля.
//    Сеттер должен проверять, соответствует ли входной пароль определённым критериям 
//    (например, минимальной длине, содержанию хотя бы одной цифры и т. д.).
class Password
{
    private string _value { get; set; }

    public string Value
    {
        set
        {
            if (value.Length < 6)
            {
                Console.WriteLine("Пароль должен состоять не менее чем из 6 цифр");
            }
            else if (!value.Any(char.IsDigit))
            {
                Console.WriteLine("В пароле должна быть хотя бы одна цифра");
            }
            else
            {
                this._value = value;
                Console.WriteLine("Верный пароль");
            }
        }
        get
        {
            return _value;
        }
    }

}

