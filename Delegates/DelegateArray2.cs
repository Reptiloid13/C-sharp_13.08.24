using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class DelegateArray2
    {
        // Нужно создать функцию, которая будет перебирать каждый элемент массива и вызывать делегат для него.
        // Отфильтровать только те элементы, которые удовлетворяют условию
        // Filter(array, delegate)
        // Filter([1, 2, 3, 4, 5, 6, 7, 8], (x) => x % 2 == 0); результат -> [2, 4, 6, 8]

        public delegate void MyDelegate(int x);
        public static void Start()
        {
            MyDelegate[] delegateArray = new MyDelegate[5];


            delegateArray[0] = GetDelegates1;
            delegateArray[1] = GetDelegates2;
            delegateArray[2] = GetDelegates3;
            delegateArray[3] = GetDelegates4;
            delegateArray[4] = GetDelegates5;

            //MyDelegate myDelegate = delegateArray[5];
            //myDelegate.Invoke(x);

            //foreach (var delegArray in delegateArray)
            //{
            //    if (x % 2 == 0)
            //    {
            //        delegArray(x);
            //    }
            //    Console.WriteLine(x);
            //}
        }

        public static void GetDelegates1(int x)
        {

            Console.WriteLine("GetDelegates1 - " + x);
        }
        public static void GetDelegates2(int x)
        {
            Console.WriteLine("GetDelegates2 - " + x * 2);
        }
        public static void GetDelegates3(int x)
        {
            Console.WriteLine("GetDelegates3 - " + x * 3);
        }
        public static void GetDelegates4(int x)
        {
            Console.WriteLine("GetDelegates4 - " + x * 4);
        }
        public static void GetDelegates5(int x)
        {
            Console.WriteLine("GetDelegates5 - " + x * 5);
        }
    }

    public class DelegateArray2_1
    {
        public delegate void MyDelegate(int x);

        public static void Filter(MyDelegate[] delegeteArray, int[] array) // заачем инт арай?
        {
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    delegeteArray[0](item);
                }
            }
        }
        public static void Start()
        {
            MyDelegate[] delegateArray = new MyDelegate[1]; // Почему тут 1  в квадратных скобочках?

            delegateArray[0] = GetDelegates1;

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Filter(delegateArray, numbers);

        }
        public static void GetDelegates1(int x)
        {

            Console.WriteLine("GetDelegates1 - " + x);
        }
    }
}
