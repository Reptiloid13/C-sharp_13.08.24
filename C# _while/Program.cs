using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
public class MainClass()
{
    public static void Main(string[] args)
    {

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your name is {0} and age is {1}", name, age);
        Console.WriteLine("Enter your birthdate: 05.03.1993 ");   
       
        Console.WriteLine("Your birthadate 05.03.1993");
        Console.ReadKey();






    }
}




