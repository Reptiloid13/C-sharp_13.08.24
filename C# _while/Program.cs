using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.XPath;

class Program
{
    //Создайте класс Person с методом экземпляра sayHello,
    //    который выводит на экран строку
    //    "Привет, меня зовут {имя}".
    //    Создайте экземпляр класса Person
    //    и вызовите метод sayHello.

    public static void Main(string[] args)
    {
        Person person = new Person("Иван");
        var ivan = person.Name; // "Иван"
        // person.SayHello();

        Person.SayHello("Иван");

        Person person1 = new Person("Олег");
        Person.SayHello("Олег");
        var count = Person.GetCount(); // А какой здесь нужен аргумент? 

        Console.WriteLine($"Количество экземпляров {count}");
    }
}

class Person
{
    public string Name;
    public int count = 0;

    public Person(string name)
    {
        Name = name;
        count++;
    }

    public static void SayHello(string name)
    {
        Console.WriteLine($"Привет, меня зовут {name}");
    }

    public static int GetCount()
    {
        return count;
    }
}