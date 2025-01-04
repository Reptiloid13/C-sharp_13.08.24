using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//int Add(int x, int y) => x + y;

//int Sub(int x, int y) => x - y;

//int Mul(int x, int y) => x * y;

//int Div(int x, int y) => x / y;

namespace Exception_SF
{
    // Написать класс Calculate  с делегатом OneResultChanged
    // Который задается снаружи класса. В калькуляторе
    // есть методы - Add, 
    //Sub,Mul, Div,
    // При вызове рузультат должен записываться в приватном поле Result
    // Нужно сделать так, чтобы при изменении результата вызывался делегат OneResultChanged.

    // это тип данных, который описывает любую функцию, которая ничего не принимает и ничего не возвращает
    public delegate void OnResultChanged(int changedValue);

    // new Person() { Age = 1, Name = "Alex", Test = 123};
    // class Person
    // {
    //     public string Name;
    //     public int Age;
    // }

    public class CalculatorTask
    {
        public static void Test(int changedValue)
        {
            Console.WriteLine($"Result changed {changedValue}");
        }
        
        public int Sum1(int a, int b, int c) => a + b + c;

        public int Sum2(int a, int b, int c)
        {
            return a + b + c;
        }
        
        public static void Start()
        {
            void OnResultChanged(int changedValue) => Console.WriteLine($"Result changed {changedValue}");

            void OnResultChanged2(int changedValue)
            {
                Console.WriteLine($"Result changed {changedValue}");
            }
            // void OnResultChanged2() => Console.WriteLine();
            // int Sum(int x) => x;
            //
            // int x = 1;
            // int y = 2;
            //
            // OnResultChanged myFn = Sum;

            //                          конструктор         инициализатор
            var calculator = new Calculator() { OnResultChangedField = Test };
            calculator.Add(2);
            calculator.Mul(4);
            calculator.Sub(7);
        }
    }

    public class Calculator
    {
        private int result = 0;

        public OnResultChanged OnResultChangedField;

        public void Add(int a)
        {
            result += a;
            OnResultChangedField(result);
        }

        public void Sub(int a)
        {
            result -= a;
            OnResultChangedField(result);
        }

        public void Mul(int a)
        {
            result *= a;
            OnResultChangedField(result);
        }

        public void Div(int a)
        {
            if (a == 0)
                throw new Exception("Деление на нуль");
            result /= a;
            OnResultChangedField(result);
        }
    }
}