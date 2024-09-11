using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static string[] CreateArrayOets(int num)
    {
        var result = new string[num];
        return result;
    }
    static (string Name, string LastName, int Age) EnterUser()
    {
        (string Name, string LastName, int Age) User;
        Console.WriteLine("Enter your name: ");
        User.Name = Console.ReadLine();

        Console.WriteLine("Enter your Lastname: ");
        User.LastName = Console.ReadLine();

        string age;
        int intage;

        do
        {
            Console.WriteLine("Enter your age");
            age = Console.ReadLine();

        }
        while (CheckNum(age, out intage));

        User.Age = intage;

        return User;

    }
    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        {
            corrnumber = 0;
            return true;
        }
    }


        static void Main(string[] args)

        {





        }

    }





