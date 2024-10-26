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
        Person person = new Person("Иван") { Name = "Иван2" };
        var ivan = person.Name; // "Иван"


        Person.SayHello("Иван");
        person.SayHello1("Fedor"); // 2 ой методд Задание 1 

        Person person1 = new Person("Олег");
        Person.SayHello("Олег");
        // var count = Person.GetCount(); // А какой здесь нужен аргумент? 
        person1.GetCount(); // Решение Задания 2 
        Console.WriteLine($"Количество экземпляров {person1.GetCount()}");
    }
}

class Person
{
    public string Name;
    public static int count = 0;

    public Person(string name)
    {
        Name = name;
        count++;
    }

    public static void SayHello(string name)
    {
        Console.WriteLine($"Привет, меня зовут {name}");
    }

    // Что-то здесь не так
    public void SayHello1(string name)
    {
        Console.WriteLine($"Привет, меня зовут {name}");
    }


    public int GetCount()
    {
        return count;
    }
}