using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
public class MainClass()
{
    public static void Main()
    {

       int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 >= 100) 
        {
            num1 = num1 / 10 % 10;
            Console.WriteLine(num1);

        }
        else
        {
            Console.WriteLine("NO");
        }




    }
}