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

    public delegate int OnResultChanged(int result);
    public class Calculator
    {
        private static int result;


        public static void Task1()
        {
            void OnResultChanged(int result) => Console.WriteLine($"Result changed {result}");

            var calculator = new Calculator() { OnResultChanged = OnResultChanged }; // Ошибка
            calculator.Add(2, 10);
            calculator.Mul(2, 10);
        }
        public void Add(int a, int b)
        {
            result = a + b;
        }

        public void Sub(int a, int b)
        {
            result = a - b;
        }
        public void Mul(int a, int b)
        {
            result = a * b;
        }

        public void Div(int a, int b)
        {
            if (b == 0)
                throw new Exception("Деление на нуль");
            result = a / b;
        }


        private static int Result()
        {
            return result;
        }
    }
}
