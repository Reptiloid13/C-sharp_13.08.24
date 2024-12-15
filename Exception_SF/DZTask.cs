using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_SF.SFTask;

public class MyException : Exception
{
    public override string Message { get; } = "MyException";
}

public class InvalidSortVariantException : Exception
{
    public override string Message { get; } =
        "Сортировку можно задачать либо числом 1 (по возрастанию), либо числом 2 (по убыванию)";
}

internal class DZTask
{
    // Создайте свой тип исключения.
    // Сделайте массив из пяти различных видов исключений,
    // включая собственный тип исключения.
    // Реализуйте конструкцию TryCatchFinally,
    // в которой будет итерация на каждый тип исключения (блок finally по желанию).
    // В блоке catch выведите в консольном сообщении текст исключения.
    public static void Task1()
    {
        Exception[] exceptions =
        [
            new DivideByZeroException(), new ArgumentNullException(), new OverflowException(),
            new IndexOutOfRangeException(), new MyException()
        ];

        foreach (var ex in exceptions)
        {
            try
            {
                throw ex;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Исключение DivideByZeroException - {e.Message}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Аргумент, передаваемый в метод — null.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Исключение - OverflowException");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Исключение - IndexOutOfRangeException ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Исключение: {e.Message}");
            }
        }
    }

    // Делегат - тип данных, который описывает метод. (Описание сигнатуры метода)
    public delegate void MyMethod();

    public static void Implementation1()
    {
    }

    public static void Implementation2()
    {
    }

    // Создайте консольное приложение, в котором будет происходить сортировка
    // списка фамилий из пяти человек.
    // Сортировка должна происходить при помощи события.
    // Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А)
    // Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally с использованием собственного типа исключения.
    public delegate void PrintSortedNamesAscDelegate(List<string> names);

    public delegate void PrintSortedNamesDescDelegate(List<string> names);

    public static event PrintSortedNamesAscDelegate PrintSortedNamesAscEvent;
    public static event PrintSortedNamesDescDelegate PrintSortedNamesDescEvent;

    public static void PrintSortedNamesAsc(List<string> names)
    {
        names.Sort();
        Console.WriteLine(string.Join(", ", names));
    }

    public static void PrintSortedNamesDesc(List<string> names)
    {
        names.Sort();
        names.Reverse();
        Console.WriteLine(string.Join(", ", names));
    }

    public static void Task2()
    {
        MyMethod myMethod = Implementation2;
        myMethod();

        var names = new List<string> { "D", "B", "A", "C", "E" };
        Console.WriteLine("Введите 1, чтобы отсортировать по возрастанию, или 2, чтобы отсортировать по убыванию");

        PrintSortedNamesDescEvent += PrintSortedNamesDesc;
        PrintSortedNamesAscEvent += PrintSortedNamesAsc;

        try
        {
            var variant = int.Parse(Console.ReadLine());
            if (variant != 1 && variant != 2) throw new InvalidSortVariantException();

            if (variant == 1)
            {
                PrintSortedNamesAscEvent(names);
            }
            else if (variant == 2)
            {
                PrintSortedNamesDescEvent(names);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static bool Method1()
    {
        Console.WriteLine(123);
        return true;
    }

    public static void Method2()
    {
        Console.WriteLine(123);
    }

    public bool Method3()
    {
        Console.WriteLine(123);
        return true;
    }

    public void Method4()
    {
        Console.WriteLine(123);
        
        var alex = new Person(); // instance - экземпляр класса
        alex.Go();
        
        var masha = new Person(); // instance - экземпляр класса
        masha.Go();

        Person.PrettyfyName(alex.Name);
        Person.PrettyfyName("Петруся");
        Person.PrettyfyName("Сашка Нагибатор");
        Person.PrettyfyName("pro100 нагибатор");
    }
}

class Person
{
    public string Name;
    
    public static void StaticGo()
    {
        
    }
    
    public void Go()
    {
        
    }

    public static string PrettyfyName(string personName)
    {
        return $"-= XxX @ {personName} @ XxX =-";
    }
}