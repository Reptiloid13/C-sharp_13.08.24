using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace OOP;

internal class Program
{
    //    На ввод поступает число n и одномерный массив размером n.

    //Напишите функцию, которая разворачивает данный массив в обратном порядке

    //Sample Input:

    //10
    //0 1 2 3 4 5 6 7 8 9

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ');
        int[] a = new int[n];
        for (int i = 0; i < s.Length; i++)
        {
            a[i] = Convert.ToInt32(s[i]);
        }
    }
    public static int Sum(int[] array, int s)
    {

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == b)
            {
                s++;
            }
        }
        return s;
    }

}