using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_SF.Delegate;




public class Delegate
{
    public delegate int SumDelegate(int a, int b, int c);
    public static void DelegateTasks()
    {
        SumDelegate sumDelegate = Sum;
        sumDelegate.Invoke(1, 10, 20);
        Console.ReadKey();

    }


    // Шаблонные делегаты Func, Action, Predicate
    //Func - возвращает значения. Может принимать до 16 вхдщ параметров
    public static void Func()
    {
        Func<int, int, int> Addition = AddNumbers;
        int result = Addition(10, 20);
        Console.WriteLine(result);


    }
    private static int AddNumbers(int param1, int param2)
    {
        return param1 + param2;
    }


    // Action - Не возвращает никакого значения, может принимать до 16 вхд параметров
    public static void Action()
    {
        Action<string>
            action = new Action<string>(Display);
        action("Hello Sarkis");
        Console.Read();
    }
    public static void Display(string message)
    {
        Console.WriteLine(message);
    }


    //Predicate - Возвращает только логическое значение - True or False
    public static void Predicate()
    {
        Predicate<string> CheckIfApple = IsApple;
        bool result = CheckIfApple("IPhone X");
        if (result) Console.WriteLine("It's IPhone X");
    }
    private static bool IsApple(string modelName)
    {
        if (modelName == "IPhone X") return true;
        else return false;
    }



    public static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public delegate int SubDelegate(int a, int b);


    //Создайте консольное приложение, в котором
    //есть функция, принимающая на вход два числа int, 
    //и возвращающая результат int 
    //вычитания второгочисла из первого
    //.Вызовите эту функцию в классе Main 
    //при помощи делегата и отобразите результат
    //в консольном сообщении.
    public static void Task932()



    {
        SubDelegate subDelegate = Sub;
        int result = subDelegate(10, 5);
        Console.WriteLine(result);


    }


    //Реализуйте консольное приложение, в котором существует две 
    //    функции: первая функция вычитает второе число из 
    //    первого и отображает результат в консольном сообщении, 
    //    вторая функция складывает два числа 
    //    и отображает результат в консоли. 
    //    Реализуйте вызов этих двух функций
    //        через многоадресный делегат.
    public static int Sub(int a, int b)
    { return a - b; }

    public delegate int SumAndSub(int a, int b);
    public static void Task934() // Как вываести разные ответы. 
    {

        SumAndSub sumAndSub = SumTask;
        var result1 = sumAndSub.Invoke(10, 5);
        sumAndSub += SubTask;
        sumAndSub -= SubTask;
        var result2 = sumAndSub.Invoke(10, 5);

        Console.WriteLine($"Сумма  = {result1}");
        Console.WriteLine($"Вычитание = {result2}");

    }

    public static int SumTask(int a, int b)
    {
        return a + b;

    }
    public static int SubTask(int a, int b)
    {
        return a - b;
    }

    // Написать класс Calculate  с делегатом OneResultChanged
    // Который задается снаружи класса. В калькуляторе
    // есть методы - Add, 
    //Sub,Mul, Div,
    // При вызове рузультата должен записываться в приватном поле Result
    // Нужно сделать так, чтобы при измении резултата вызывался делегат OneResultChanged.
    public static void ArturTask1()
    {

    }



}


