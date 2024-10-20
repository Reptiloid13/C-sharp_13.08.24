
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{

    //5. Создайте класс Car с методом экземпляра drive, который выводит на экран строку "Машина едет".
    //        Добавьте в класс статический метод getMaxSpeed, который возвращает максимальную скорость всех машин.


    public static void Main(string[] args)
    {
        Car car = new Car(120, "BMW");
        Car car1 = new Car(210, "Lada");



    }
}

class Car
{
    public int Speed;
    public string Name;


    public Car(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }

    public string Drive(string message)
    {
        return "Машина едет";
    }
    public static int GetMaxSpeed(int speed)
    {

    }
}