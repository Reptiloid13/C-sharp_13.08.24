using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Delegates;

public delegate void FuncDelegate(int[] numbers);
public class DelegateArray
{
    public event FuncDelegate? FuncEvent;
    public void OnFunc(int[] numbers)
    {
        FuncEvent?.Invoke(numbers);
    }


    public static int[] CreateArray()
    {
        var n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];

        string[] ss = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(ss[i]);
        }
        return numbers;
    }
}

public class MinIndex
{
    public static void Test(int[] numbers)
    {
        var delegateArray = new DelegateArray();
        delegateArray.FuncEvent += arr =>
          {
              var minIndex = 0;
              for (int i = 0; i < arr.Length; i++)
              {
                  if (arr[i] < arr[minIndex])
                      minIndex = i;
              }
              Console.WriteLine(minIndex);
          };
        delegateArray.OnFunc(numbers);
    }

}
public class MinElement
{
    public static void GetMinElement(int[] numbers)
    {
        var delegateArray = new DelegateArray();
        delegateArray.FuncEvent += arr =>
        {
            var min = arr[0];


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

            }
        };

        delegateArray.OnFunc(numbers);
    }
}



public class SubtractionOnMinElement
{
    public static void GetSub(int[] numbers)
    {
        var delegateArray = new DelegateArray();
        delegateArray.FuncEvent += arr =>
        {
            var min = arr[0];



            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= min;
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num + " ");
            }

        };
        delegateArray.OnFunc(numbers);
    }
}



