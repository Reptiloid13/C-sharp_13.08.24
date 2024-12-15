using System.Security.Cryptography.X509Certificates;
using Exception_SF;
using Exception_SF.Anonymous;
using Exception_SF.SFTask;

namespace Exception_SF.Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate();
            //Task922();
            //Delegate.Task934();
            //Delegate.Predicate();
            //AnonymousDelegate.Task9312();
            DZTask.Task1();
        }

        public static void Calculate()
        {
            try
            {
                int result = Division(7, 0);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException) Console.WriteLine("На ноль делить нельзя");
                else Console.WriteLine("Произошла непредвиденная ошиибка в приложении");
            }
            finally
            {
                Console.WriteLine("Блок Finally Сработал ");
            }

        }


        public static int Division(int a, int b)
        {
            return a / b;
        }

        public static void Task922()
        //Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally для обработки исключения
        //ArgumentOutOfRangeException.В случае исключения отобразите в консоль сообщение об ошибке.
        {
            try
            {
                Console.WriteLine("Try started work");

                throw new Exception("Ошибка для таска 921");

            }

            catch (Exception ex) when (ex is ArgumentOutOfRangeException)

            {
                Console.WriteLine("Аргумент вышел за пределы");
                Console.WriteLine(ex.ToString);
            }

            finally
            {

                Console.WriteLine("Сработад не нужный Файнали ");


            }


        }

        public static void Task923()
        //Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally для обработки исключения RankException.
        //В случае исключения отобразите в консоль тип исключения(через метод GetType()).

        {

            try
            {
                throw new RankException("Сообщение об ошибке");
            }


            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.Read();
            }





        }
    }
}
