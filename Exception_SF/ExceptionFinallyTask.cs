using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exception_SF
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
    public class ExceptionFinallyTask
    {
        //        Создайте свой тип исключения.
        //Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
        //В блоке catch выведите в консольном сообщении текст исключения.
        public static void Test()
        {

            Exception[] exception = new Exception[5];
            exception[0] = new ArgumentNullException();
            exception[1] = new ArgumentException();
            exception[2] = new DivideByZeroException();
            exception[3] = new InvalidOperationException();
            exception[4] = new MyException("This is custom Exception");

            foreach (Exception ex in exception)
            {
                try
                {
                    throw ex;

                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine($"Argument Null Exception{e.Message}");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Argument Exception{e.Message}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Divide by zero {e.Message}");
                }



            }

        }

    }
}
