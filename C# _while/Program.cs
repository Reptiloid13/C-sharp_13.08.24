using System;
using System.ComponentModel.DataAnnotations;
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
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{


    static void Echo (string saidword, int deep)
    {
        var modif = saidword;
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }
        Console.WriteLine("....."+ modif);
        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }

    }
    
        
        static void Main1( string[] args) 
    {


        Console.WriteLine("Напиши что то ");
        var str = Console.ReadLine();
        Console.WriteLine("Укажите глубину эха" );
        var deep = int.Parse(Console.ReadLine());
        for (int i = 0; i < deep; i++)
        {
            Echo(str, deep);


        }



    }

   
}






