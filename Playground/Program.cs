using System.Data;

namespace Playground;

class Program
{



    public static void Main()
    {
        Action showMessageDelegate = ShowMessage;
        showMessageDelegate.Invoke();

        Func<int, int, int, int> sumDelegate = Sum; // последний параметр - возвращающий
        int result = sumDelegate.Invoke(1, 30, 120);
        Console.WriteLine(result);

        Predicate<string> checkLengthDelegate = CheckLength;
        bool status = checkLengthDelegate.Invoke("skill_factory");
        Console.WriteLine(status);



    }

    public static void ShowMessage()
    {
        Console.WriteLine("Hello World");
    }


    public static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    private static bool CheckLength(string _row)
    {
        if (_row.Length > 3) return true;
        return false;
    }

}
