using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace OOP;

public class GettersSetters
{
    public static void Test()
    {
        var user = new User("Иван", 25);
        Console.WriteLine(user.Name);

        user.Age = 66; // 66 = value

        Console.WriteLine(user.Age);
    }
}

class User
{
    public string Name;

    // Приватное поле
    private int _age;

    // Свойство, а не поле
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                _age = 0;
            else if (value > 100)
                _age = 100;
            else
                _age = value;
        }
    }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int GetAge()
    {
        return Age;
    }
}

//6. Создайте класс BankAccount с методом экземпляра deposit, который добавляет деньги на счет
//    .Добавьте в класс статический метод getTotalBalance, который возвращает общую сумму денег на всех счетах
//    .Создайте два экземпляра класса BankAccount и вызовите метод deposit для каждого.

public class GetDoposit
{
    public static void Test()
    {
        BankAccount account1 = new BankAccount(0);
        account1.Deposit(100);

        BankAccount account2 = new BankAccount(190);
        account2.Deposit(200);
        Console.WriteLine($"Total Balance: {BankAccount.GetTotalBalance()}");
    }
}
//1. Задача: Разработайте класс BankAccount с приватным полем balance.
//    Предоставьте геттер для баланса и сеттер, который позволяет производить депозиты(добавляет к балансу) и выводы(вычитает из баланса). 
//    Обеспечьте, чтобы баланс не мог быть отрицательным.

class BankAccount
{
    public decimal Balance; // Можно ли писать переменные с маленькой буквы?
    public static decimal TotalBalance = 0;
    private decimal _balance { get; set; }

    public decimal balance
    {
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Баланс не может быть меньше 0 ");
            }
            else
            {
                balance = value;
            }
        }
        get { return balance; }
    }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        TotalBalance += amount;
    }

    public static decimal GetTotalBalance()
    {
        return TotalBalance;
    }
}

//7. Создайте класс Student с методом экземпляра learn, который выводит на экран строку "Студент учится". 
//    Добавьте в класс статический метод getAverageGrade, который возвращает средний балл всех студентов.
//    Создайте три экземпляра класса Student и вызовите метод learn для каждого.
public class GetStudent
{
    public static void Test()
    {
        Student student1 = new Student("Bob", 4); // Как вызывать значение из скобок, что
        Student student2 = new Student("Bill", 5);
        Student student3 = new Student("Jackob", 2);

        Console.WriteLine(student1.Name);

        student1.Learn();
        student2.Learn();
        student3.Learn();

        Student[] students = { student1, student2, student3 };
        double avergeGrade = Student.GetAverageGrade(students);
        Console.WriteLine(
            $"Студент {student1.Name},  оценка: {student1.Grade}\n" + // Как сделать , чтобу "Студент учиться был в Консоли 
            $"Студент {student2.Name},  оценка: {student2.Grade}\n" +
            $"Студент {student3.Name},  оценка: {student3.Grade}\n" +
            $"Средний балл всех студентов: {Math.Round(avergeGrade, 2)}  ");
    }
}

class Student
{
    public string Name;
    public int Grade;

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public void Learn()
    {
        Console.WriteLine($"Студент {Name} учится");
    }

    public static double GetAverageGrade(Student[] students)
    {
        int sum = 0;
        foreach (Student student in students)
        {
            sum += student.Grade;
        }

        return (double)sum / students.Length;
    }
}

//8. Создайте класс Book с методом экземпляра read, который выводит на экран строку "Читаю книгу {название}".
//    Добавьте в класс статический метод getTotalPages, который возвращает общее количество страниц во всех книгах.
//    Создайте два экземпляра класса Book и вызовите метод read для каждого

public class GetBook
{
    public static void Test()
    {
        Book book1 = new Book();
        book1.Name = "Как стать Айтишником";
        book1.TotalPages = new Random().Next(100, 999);
        book1.Read();
        Book book2 = new Book();
        book2.Name = "Мой путь в С-шарп";
        book2.TotalPages = new Random().Next(1, 20);


        //  нужно что то записать 
        book2.Read();

        Console.WriteLine($"Книга - {book1.Name}, Страницу у книги - {book1.TotalPages}\n" +
                          $" Книга - {book2.Name} Страницу у книги - {book2.TotalPages} \n" +
                          $"Общее количество страниц у двух книг: {Book.GetTotalPages(book1.TotalPages, book2.TotalPages)} ");
    }
}

class Book
{
    public string Name;
    public int TotalPages;

    public void Read()
    {
        Console.WriteLine($"Читаю кингу {Name} ");
    }

    public static int GetTotalPages(int totalPages1, int totalPages2)
    {

        return totalPages1 + totalPages2;
    }
}

//9. Создайте класс Weather с методом экземпляра getForecast, который выводит на экран строку "Погода в {городе}: {погода}".
//    Добавьте в класс статический метод getAverageTemperature, который возвращает среднюю температуру во всех городах.
//    Создайте два экземпляра класса Weather и вызовите метод getForecast для каждого.

public class GetWeather
{
    public static void Test()
    {
        Weather moscow = new Weather() { Name = "Moscow", Temperature = 7 };

        moscow.GetForecast();

        Weather evpatoria = new Weather() { Name = "Evpatoria", Temperature = 20 };

        evpatoria.GetForecast();
        Weather[] weathers = { moscow, evpatoria };
        int averageTemperature = Weather.GetAverageTemperature(weathers);


        Console.WriteLine($" Средняя погода {averageTemperature}");
    }
}

class Weather
{
    public string Name;
    public int Temperature;

    public void GetForecast()
    {
        Console.WriteLine($"Погода в {Name} : {Temperature}");
    }

    public static int GetAverageTemperature(Weather[] weathers)
    {
        int sum = 0;
        foreach (Weather weather in weathers)
        {
            sum += weather.Temperature;
        }

        return sum / weathers.Length;
    }
}