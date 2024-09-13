using System.Security.Cryptography.X509Certificates;

namespace SkillFactory
{
    internal class Program
    {
        static void Main(string[] args)
        /*
         * Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
            Имя;
            Фамилия;
            Возраст;
            Наличие питомца;
            Если питомец есть, то запросить количество питомцев;
            Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры);
            Запросить количество любимых цветов;
            Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры);
            Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
            Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
            Корректный ввод: ввод числа типа int больше 0.
            Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
            Вызов методов из метода Main.
         * 
         */
        {
            var x  = EnterUser();

        }
        static (string Name, string LastName, int Age, bool Pets, int [] favcolors ) EnterUser()
        {
            (string Name, string LastName, int age, bool pets, int [] favcolors) User;

            Console.WriteLine("Enter your name: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter your LastName: ");
                User.LastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            User.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you have  pets: ");
            User.pets = true;

            Console.WriteLine("How many favorite colors do you have: ");
            
            User.favcolors = new int[3];



            return User;
        }

        
    }
}
