using Playground2.Tasks1;
using System;
using System.Security.Cryptography.X509Certificates;
namespace Playground2.Tasks1;



public delegate void MyDelegate();



class Program
{
    public delegate int ValueDelegate(int i);
    public delegate void MyDelegate();
    public event MyDelegate Event;
    public event Action EventAction;

    public static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Golda"
        };

        person.GoToSleep += Person_GoToSleep1;
        person.DoWork += Person_DoWork;
        person.TakeTime(DateTime.Parse("02.01.2025   7:27:55"));
        person.TakeTime(DateTime.Parse("02.01.2025   16:27:55"));




    }

    private static void Person_DoWork(object? sender, EventArgs e)
    {
        if (sender is Person)
        {
            Console.WriteLine($"{((Person)sender).Name} работает работу");
        }
    }

    private static void Person_GoToSleep1()
    {
        Console.WriteLine("Человек пошел спать");

    }



    public static void Task()
    {
        MyDelegate myDelegate = Method1;
        myDelegate += Method4; // первый спопсоб добавление методав в делегат  

        myDelegate();

        MyDelegate myDelegate2 = new MyDelegate(Method4); // второй способ вызова метода в делегат 
        myDelegate2 += Method4;
        myDelegate2 -= Method4; // удаление Метода
        myDelegate2.Invoke();

        MyDelegate myDelegate3 = myDelegate + myDelegate2;
        myDelegate3.Invoke();


        var valueDelegate = new ValueDelegate(MethodValue);

        valueDelegate((new Random()).Next(10, 50));
    }

    public static int MethodValue(int i)
    {
        Console.WriteLine(i);
        return i;
    }

    public static void Method1()
    {
        Console.WriteLine("Method1");
    }
    public static void Method2()
    {
        Console.WriteLine("Method2");

    }
    public static void Method3()
    {
        Console.WriteLine("Method3");

    }

    public static void Method4()
    {
        Console.WriteLine("Method4");

    }
}