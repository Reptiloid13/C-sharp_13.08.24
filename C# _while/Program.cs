using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.XPath;

class Program
{
    static void Main()
    {
        var person = new Person("FirstName", "LastName", "SecondName", 10);

        // person.Age = -1000;
        person.SetAge(-1000);
        Console.WriteLine(person.GetAge());

        Console.WriteLine(person.Height);
    }
}

class Person
{
    public string FirstName;
    public string LastName;

    public string SecondName;

    // Поле
    private int Age;

    // Свойство
    public int Height
    {
        get { return Height; }
        set
        {
            if (value < 0)
                Height = 1;
            else
                // value - ключевое слово, которое обозначение значение, которое устанавливается
                Height = value;
        }
    }

    public int GetHeight()
    {
        return Height;
    }

    public int SetHeight(int height)
    {
        Height = height;
    }

    public Person(string firstName, string lastName, string secondName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        SecondName = secondName;
        Age = age;
    }

    public void SetAge(int age)
    {
        if (age < 0) age = 1;
        Age = age;
    }

    public int GetAge()
    {
        return Age;
    }
}

// interface ICar
// {
//     public int Speed { get; set; }
//     
//     void Drive();
//
// }