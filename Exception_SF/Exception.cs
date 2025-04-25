using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_SF
{
    public class ExceptionSF
    {
        //        Задание 9.1.3
        //Создайте экземпляр класса исключения Exception
        //и добавьте в свойство Data дату создания исключения.



        public static void Task913()
        {
            Exception exception = new Exception();
            exception.Data.Add("Дата создания исключения : ", DateTime.Now);


        }
        //    Задание 9.1.4
        //Создайте класс исключения Exception и переопределите его свойство Message,
        //        а также свойство HelpLink, добавив в него ссылку на внешний ресур
        public static void Task914()
        {

            Exception exception = new Exception("My exception"); // Создаем класс эксепшен и переопределяем его свойосто
            exception.HelpLink = "www.google.ru";
        }
        //        Задание 9.2.2
        //Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally 
        //            для обработки исключения ArgumentOutOfRangeException.В случае исключения отобразите в консоль сообщение об ошибке.

        public static void Task922()
        {
            try
            {
                throw new ArgumentOutOfRangeException("Сообщите об ошибке");
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine(ex);
            }
            finally
            {
                Console.Read();
            }

        }
        //        Задание 9.2.3
        //Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally 
        //            для обработки исключения RankException.В случае исключения отобразите 
        //            в консоль тип исключения(через метод GetType()).

        public static void Task923()
        {
            try
            {
                throw new RankException("Сообщите об ошибке");
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
        }
    }
}


