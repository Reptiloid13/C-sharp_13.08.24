using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_SF
{
    public class Metanit
    {
        // public delegate тип_возвращаемого_значения имя_делегата (тип_аргумента аргумент);
        delegate void Message(); //1. Объявляем делегат

        public static void Mes()
        {
            Message mes; //2. Создаем переменную делегатта
            mes = Hello; //3. Присваем этой переменной адрес метода
            mes(); // 4. Вызываем метод

            void Hello() => Console.WriteLine("Hello Metanit");
        }

    }
    //Параметры и результат делегата
    public class ResultDelegate
    {
        public delegate int Operation(int x, int y);
        public static void Result()
        {
            Operation operation = Add; // Делегат указывает на метод Add
            int result = operation(4, 5); // Фактически Add(4,5)
            Console.WriteLine(result);//9

            operation = Multiply; // Теперь делегат указывает на метод Multiply 
            result = operation(4, 5); // Фактически Multiply (4,5)
            Console.WriteLine(result); // 20

            int Add(int x, int y) => x + y;
            int Multiply(int x, int y) => x * y;

        }
    }

    public delegate void MyDelegate();

    public class


}
