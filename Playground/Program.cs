using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.XPath;

class Program
{
    //Задача: Напишите класс Book с приватными полями title и author.
    //    Реализуйте геттеры и сеттеры для этих полей.
    //    Сеттер для title должен проверять, является ли 
    //    входное значение строкой и не содержит ли она 
    //    запрещенные символы: "!@#$%^&*()_+"



    public static void Main(string[] args)
    {
        Book book = new Book();
        book.Tittle = "Agata";
        Console.WriteLine(book.Tittle);
    }
}
class Book
{
    private string title { get; set; }
    private string _author { get; set; }

    public string Tittle
    {
        set
        {
            if (IsValidTittle(value)) Tittle = value;
        }
        get { return title; }

    }
    private bool IsValidTittle(String input)
    {
        if (string.IsNullOrEmpty(input)) return false;

        string forbiddenChars = "!@#$%^&*()_+";
        foreach (char symbol in forbiddenChars)
        {
            if (input.Contains(symbol))
            {
                return false;
            }

        }
        return true;
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

    public void SayHello1()
    {
        Console.WriteLine($"Привет, меня зовут {Name}");
    }


