namespace OOP;

class Program
{
    // 5. Создайте класс Car с методом экземпляр а drive, который выводит на экран строку "Машина едет".
    // Добавьте в класс статический метод getMaxSpeed, который возвращает максимальную скорость всех машин.
    public static void Main()
    {
        //CarTask.Test();
        // Bank.Test();
        // StudentTask.Test();
        // GettersSetters.Test();
        //GetDoposit.Test();
        //GetStudent.Test
        //GetBook.Test();
        //GetWeather.Test();
        // GetPoints.Test();
        //GetTime.Test();
        // TransportTask.Test();
        //Human.HumanMain();
        Animal.GreetingsMain();

        //Создадим нового ученика и заполним его поля: 

        Student student1 = new Student();
        student1.FirstName = "Iosif";
        student1.LastName = "Dzeranov";


    }
}

public class Student
{
    public string FirstName = "Неизвестное имя";
    public string LastName = "Неизвестная фамилия";
    public string Print()
    {
        return FirstName + " " + LastName;
    }

    public Student()
    {
        FirstName = "Unknown FirstName";
        LastName = "Unknown LastName";
    }
}

public class User
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }


    public User()
    {
        Name = "Поликарп";
        PhoneNumber = "+7(000)000 00 00";
    }



}