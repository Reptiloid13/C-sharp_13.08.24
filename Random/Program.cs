namespace Playground2.Tasks1;

class Person2
{
    public string Name = "";
    public int Age;

    public void SayHello()
    {
        Console.WriteLine($"Hello, I'm {this.Name}");
    }
}

class Program
{

    public static void Main(string[] args)
    {
        //GetMinElement();
        //GetBigger();
        // GetModulMax();
        Test();
        //GetMultiplicationTable();

        //// instance
        //var ivan = new Person2();

        //ivan.Name = "Ivan";

        //var petr = new Person2() { Name = "Петр" };
        //var john = new Person2();

        //ivan.SayHello();
        //petr.SayHello();

        //var counter = new DateCounter() { Time = "24:10:12" };
        //int minutes = counter.Count("m"); // counter.GetMinutes()
        //int seconds = counter.Count("s"); // counter.GetSecond()
        //int hours = counter.Count("h"); // counter.GetHours()
        //int days = counter.Count("d"); // counter.GetDays()


        //Console.WriteLine(ivan);
    }


    //Найти количество перестановок для массива чисел. Пример: [20, 93, 99999] -> 6

    public static void GetSwapElements()
    {
        int[] array = { 20, 93, 11 };
        var swap = 0;

        // [x] 1
        // [x x] 2
        // [x x x] 6
        // [x x x x] 24
        // 3 = 1 * 2 * 3 = 3!
        // 4 = 1 * 2 * 3 * 4 = 4!

        //for (int i = 0; i < array.Length; i++)
        //{
        //    for (int j = i + 1; j < array.Length; j++)
        //    {
        //        if (array[i] != array[j])
        //        {

        //        }
        //    }
        //}

        // Дописать
    }

    // Вывести таблицу умножения
    public static void GetMultiplicationTable()
    {
        // Вывести в несколько столбцов
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j,3}");
            }
        }
    }

    public static void Test()
    {
        char c = Convert.ToChar(Console.ReadLine());

    }



    // 1 ) Напишите программу, в которую пользователь вводит свой пол(
    //    "М" для мужского, "Ж" для женского) 
    //    и выводит ответное сообщение "Вы мужчина" или "Вы женщина". 
    //    В случае иного ввода программа должна вывести сообщение 
    //    "Некорректный ввод"


    // 2) Калькулятор времени: Напишите программу,
    // которая принимает от пользователя количество часов и минут, а затем выводит общее количество минут.
    //Пользователь вводит сначала число часов, потом число минут.
    //Программа выводит лишь одно число - число минут.

    // Если неправильный Time, выбросить ошибку

    // new DateCounter()
    //            ч  м  с
    // CountDate("34:23:13", "m") // 
    // CountDate("34:23:13", "s") // 
    // CountDate("34:23:13", "h") // 
    // CountDate("34:23:13", "d") // 
}