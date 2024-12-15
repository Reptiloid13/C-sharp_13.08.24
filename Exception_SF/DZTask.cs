using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_SF.SFTask;

internal class DZTask
{
    //    Создайте свой тип исключения.
    //Сделайте массив из пяти различных видов исключений,
    //включая собственный тип исключения.
    //Реализуйте конструкцию TryCatchFinally,
    //в которой будет итерация на каждый тип исключения (блок finally по желанию).
    //В блоке catch выведите в консольном сообщении текст исключения.
    public static void Task1()
    {
        try
        {
            int[] array = { 1, 2, 3, 4, 5, };

            array[7] = 9;


            int x = 5;
            int y = x / 0;
            Console.WriteLine($"Результат: {y}");

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Исключение - DivideByZeroException");
        }


        catch (ArgumentNullException)
        {
            Console.WriteLine("Аргумент, передаваемый в метод — null.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Исключение - OverflowException");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Исключение - IndexOutOfRangeException ");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
        }

    }
    //    Создайте консольное приложение, в котором будет происходить сортировка
    //    списка фамилий из пяти человек.
    //    Сортировка должна происходить при помощи события.
    //    Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А)
    //Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally с использованием собственного типа исключения.
    public static void Task2()
    {

    }
}
