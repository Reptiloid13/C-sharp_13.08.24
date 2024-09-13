using SkillFactory;
using SkillFactory.Tasks;

namespace SkillFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user1 = ClassTasks.GetUser(1, "A");
            var user2 = ClassTasks.GetUser(2, "B");

            var x = EnterUser();


        }
        static (string Name, string LastName, int Age, bool Pets, string[] favcolors) EnterUser()
        {
            (string Name, string LastName, int Age, bool Pets, string[] favcolors) User = ("", "", 0, false, []);

            Console.WriteLine("Enter your name: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter your LastName: ");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");


            while (int.TryParse(Console.ReadLine(), out User.Age) && User.Age > 0) ;



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
            }
            while (Pets == null);

            if (Pets != null && Pets == true)
            {
                var petsCount = ReadPositiveInt("How many pets do you have?  ");
                var hasPet = ReadStrings(petsCount, "Name pet : ");

                Console.WriteLine(string.Join(";", hasPet));

            }


            var colorCount = ReadPositiveInt("How many favortite colors do you have: ");
            var colors = ReadStrings(colorCount, "Color: ");



            Console.WriteLine(string.Join(";", colors));


            return User;



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