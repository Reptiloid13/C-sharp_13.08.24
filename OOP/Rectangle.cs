using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Contracts;

namespace OOP;

internal class Program
{

    static void Main(string[] args)
    {
        Car ferarri = new Car();
        ferarri.Name = "F40";
        ferarri.HorsePower = 471;
        ferarri.Age = 30;
        ferarri.MaxSpeed = 317.0f;


        Car maserati = ferarri;
        maserati.HorsePower = 1000;
        Console.WriteLine(ferarri.HorsePower);




    }


}

class Car
{
    public string Name;
    public int HorsePower;
    public int Age;
    public float MaxSpeed;

}

