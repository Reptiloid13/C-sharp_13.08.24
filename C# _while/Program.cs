﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
public class MainClass()
{
    public static void Main(string[] args)
    {
        /* Тернарный оператор разниза 
         */

        Console.WriteLine("Напишите свой любимый цвет с маленькой буквы");
       
        var color = Console.ReadLine(); 
        
        if(color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is red");
        }

        else if (color == "green")
        {
            Console.BackgroundColor=ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green");
        }

        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is cyan!");
        }













    }









    }







