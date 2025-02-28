using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Нужно создать функцию MyForEach, которая будет перебирать каждый элемент массива и вызывать делегат для него
    // MyForEach(array, delegate)
    // MyForEach([1, 2, 3], (x) => Console.WriteLine(x));
    // (1) => Console.WriteLine(1)
    // (2) => Console.WriteLine(2)
    // (3) => Console.WriteLine(3)

    public class DelegateArray
    {
        public delegate void MyDelegate();


        public static void Start2()
        {
            int[] array = { 1, 2, 3, };
        }

        public static void ForEach(Array, int)
        {
            public MyDelegate Arraydelegate;

    }


    //public static void Start()
    // {
    //MyDelegate[] delegateArray = new MyDelegate[2]; // массив Делегатов

    ////присваиваю значения элементам массива
    //delegateArray[0] = GetDelegate1;
    //delegateArray[1] = GetDelegate2;

    //// Перебираю элементы в массиве 
    //foreach (var delegArray in delegateArray)
    //{
    //    delegArray(1); // вызываем делегат для каждого элемента массива 

    //}

    // }
    //    // Функция 1 
    //    public static void GetDelegate1(int i)
    //    {
    //        Console.WriteLine("GetDelegate1 " + i);
    //    }
    //    //Функция 2 
    //    public static void GetDelegate2(int i)
    //    {
    //        Console.WriteLine("GetDelegate2 " + 2 * i);
    //    }
    //}

}
