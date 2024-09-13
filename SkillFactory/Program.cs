using System.Security.Cryptography.X509Certificates;

namespace SkillFactory
{
    internal class Program

    {
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
Вызов методов из метода Main.*/

        static void Main(string[] args)

        {
            var x = EnterUser();
        }

        static (string Name, string LastName, int Age, bool Pets, int[] favcolors) EnterUser()
        {
            (string Name, string LastName, int Age, bool Pets) User;

            Console.WriteLine("Enter your name: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter your LastName: ");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            User.Age = Convert.ToInt32(Console.ReadLine());


            bool? Pets = null;
            do
            {
                Console.WriteLine("Do you have  pets (Yes/Y/No/N) : ");
                var inPut = Console.ReadLine();

                if (inPut == "Yes" || inPut == "Y")
                {
                    Pets = true;
                }
                else if (inPut == "NO" || inPut == "N")
                {
                    Pets = false;
                }
            } while (Pets == null);

            if (Pets != null && Pets == true)
            {
                var petsCount = ReadPositiveInt("You have pets  ");
                var hasPet = ReadStrings(petsCount, "Name pet : ");

                Console.WriteLine(string.Join(";", hasPet));
            }


            var colorCount = ReadPositiveInt("How many favortite colors do you have: ");
            var colors = ReadStrings(colorCount, "Color: ");

            for (int i = 0; i < colorCount; i++)
            {
                Console.Write($"Color № {i + 1}: ");
                var color = Console.ReadLine();
                colors[i] = color;
            }

            Console.WriteLine(string.Join(";", colors));


            return EnterUser();
        }

        static string[] ReadStrings(int count, string message)
        {
            var strings = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{message} № {i + 1}: ");
                strings[i] = Console.ReadLine();
            }

            return strings;
        }

        static int ReadPositiveInt(string message)
        {
            int colorsCount;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out colorsCount) && colorsCount > 0);

            return colorsCount;
        }
    }
}