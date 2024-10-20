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
        Person person = new Person("Иван");// что нужно писать в скобочках. Аргумент здесь по сути не нужен 
                                           // person.SayHello("Иван");
        var x = Person.SayHello("Иван");
        Console.WriteLine(x);

        Person person1 = new Person("Олег");
        var y = Person.SayHello("Олег");
        Console.WriteLine(y);
        var count = Person.GetCount(); // А какой здесь нужен аргумент? 

        Console.WriteLine($"Количество экземпляров {count}");
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
    public static string SayHello(string name)
    {
        return "Привет, меня зовут " + name;
    }
    public static int GetCount(int count)
    {
        return count;

    }
}

