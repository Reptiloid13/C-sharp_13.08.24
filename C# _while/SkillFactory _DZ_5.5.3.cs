using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___while
{
    internal class SkillFactory__DZ_5
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Напиши что то ");
            var str = Console.ReadLine();
            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());
            for (int i = 0; i < deep; i++)
            {
                Echo(str, deep);


            }



        }
        static void Echo(string saidword, int deep)
        {
            var modif = saidword;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;

            Console.WriteLine("....." + modif);
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }

        }
    }
    
}
