using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ;
//Проекция - позволяет преобразовать данные текущей выборки в какой-либо другой тип.
public class Application_Selection
{
    /// <summary>
    /// Проекция - позволяет преобразовать данные текущей выборки в какой-либо другой тип.
    /// Для этого используется оператор select (также есть соответствующий метод расширения).
    /// </summary>


    public static void ProectionExample()
    {
        List<Student> students = new List<Student>
{
   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
};
        var studentAgeApplication = from s in students
                                    where s.Age <= 27
                                    let birthYear = DateTime.Now.Year - s.Age// // Вычисляем год рождения
                                    select new Application()
                                    {
                                        Name = s.Name,
                                        YearOfBirth = birthYear
                                    };
        foreach (var studApplication in studentAgeApplication)
        {
            Console.WriteLine(studApplication + ", " + studApplication.YearOfBirth);
        }

    }
    /// <summary>
    /// Сделайте выборку в анонимный тип с одновременной сортировкой слов по длине.
    /// Результат выведите в консоль.
    /// </summary>
    public static void Task1421()
    {
        string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };
        var wordsApplications = words.Select(w =>
                                 new
                                 {// Выборка в анонимный тип
                                     Name = w,
                                     Length = w.Length,// Длину слова сохраняем сразу в свойство нового анонимного типа
                                 })
        .OrderBy(word => word.Length); // сортируем коллекцию по длине

        foreach (var word in wordsApplications)
        {
            Console.WriteLine($"{word.Name} - {word.Length} букв");
        }
    }


    /// <summary>
    /// Возьмем список студентов из примера выше и добавим им всем в анкету фамилию: 
    /// </summary>
    //public static void LetExample()
    //{
    //    var fullNameStudents = from s in students
    //                           let fullName = s.Name + " Иванов"
    //                           // проекция в новую сущность с использованием новой переменной
    //                           select new
    //                           {
    //                               Name = fullName,
    //                               Age = s.Age
    //                           };
    //    foreach (var stud in fullNameStudents)
    //    {
    //        Console.WriteLine(stud.Name + "," + stud.Age);
    //    }

    //}

    public static void SkipTakeExample()
    {
        var cars = new[] { "Volvo", "Opel", "Suzuki", "Toyota", "Lada", "Kamaz" };
        // пропустим первые два элемента и выведем следующие два
        var skip2 = cars.Skip(2).Take(2);

        foreach (var car in skip2)
            Console.WriteLine(car);

    }
    /// <summary>
    ///  Давайте попробуем сделать свою мини-программу для просмотра контактов с постраничным выводом.
    ///  Сделайте вывод контактов в консоль по два в бесконечном цикле.
    /// </summary>
    //    public static void Task1425()
    //    {
    //        var contacts = new List<Contact>()
    //{
    //   new Contact() { Name = "Андрей", Phone = 7999945005 },
    //   new Contact() { Name = "Сергей", Phone = 799990455 },
    //   new Contact() { Name = "Иван", Phone = 79999675 },
    //   new Contact() { Name = "Игорь", Phone = 8884994 },
    //   new Contact() { Name = "Анна", Phone = 665565656 },
    //   new Contact() { Name = "Василий", Phone = 3434 }
    //};
    //        // бесконечный цикл, ожидающий ввод с консоли
    //        while (true)
    //        {
    //            // получаем символ с консоли
    //            var keyChar = Console.ReadKey().KeyChar;
    //            Console.Clear();  //  очистка консоли от введенного текста

    //            if (!Char.IsDigit(keyChar))
    //            {
    //                Console.WriteLine("Ошибка ввода, введите число");
    //            }
    //            else
    //            {

    //                //  переменная для хранения запроса в зависимости от введенного с консоли числа
    //                IEnumerable<Contact> page = null;

    //                //  выбираем нужное кол-во элементов для создания
    //                //  постраничного ввода в зависимости от запроса

    //                switch (keyChar)
    //                {
    //                    case ('1'):
    //                        page = contacts.Take(2);
    //                        break;

    //                    case ('2'):
    //                        page = contacts.Skip(2).Take(2);
    //                        break;

    //                    case ('3'):
    //                        page = contacts.Skip(4).Take(4);
    //                        break;

    //                }
    //                //   проверим, что ввели существующий номер страницы
    //                if (page == null)
    //                {
    //                    Console.WriteLine($"Ошибка ввода, страницы {keyChar} не существует");
    //                    continue;
    //                }
    //                // вывод результата на консоль
    //                foreach (var contact in page)
    //                {
    //                    Console.WriteLine(contact.Name + " " + contact.Phone);
    //                }


    //            }
    //        }

}

/// <summary>
/// Допустим, у нас есть база данных машин, и мы знаем, что сначала идут японские: 
/// </summary>
//    public static void SkipTakeWhileExample()
//    {
//        // Подготовка данных
//        var cars = new List<Car>()
//{
//   new Car("Suzuki", "JP"),
//   new Car("Toyota", "JP"),
//   new Car("Opel", "DE"),
//   new Car("Kamaz", "RUS"),
//   new Car("Lada", "RUS"),
//   new Car("Lada", "RUS"),
//   new Car("Honda", "JP"),
//};
//        Console.WriteLine("Пропустим японские машины в начале списка");
//        var notJapaneseCars = cars.SkipWhile(car => car.CountryCode == "JP");
//        foreach (var notJapanCar in notJapaneseCars)
//            Console.WriteLine(notJapanCar.Manufacturer);

//        Console.WriteLine();

//        Console.WriteLine("Теперь выберем только японские машины из начала списка");
//        var japanCars = cars.TakeWhile(car => car.CountryCode == "JP");

//        foreach (var japanCar in japanCars)
//            Console.WriteLine(japanCar.Manufacturer);

//        var withoutJapanCars = cars.RemoveAll(car => car.CountryCode == "JP");
//    }


//    /// <summary>
//    /// Реализуйте для неё постраничный вывод, по 2 записи на страницу.
//    /// </summary>
//    public static void Task14210()
//    {
//        var phoneBook = new List<Contact>();
//        // добавляем контакты
//        phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
//        phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
//        phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
//        phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
//        phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
//        phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

//        while (true)
//        {
//            // Читаем введенный с консоли символ
//            var input = Console.ReadKey().KeyChar;
//            // проверяем, число ли это
//            var parsed = Int32.TryParse(input.ToString(), out int pageNumber);

//            // если не соответствует критериям - показываем ошибку
//            if (!parsed || pageNumber < 1 || pageNumber > 3)
//            {
//                Console.WriteLine();
//                Console.WriteLine("Страницы не существует");
//            }
//            // если соответствует - запускаем вывод
//            else
//            {
//                // пропускаем нужное количество элементов и берем 2 для показа на странице
//                var pageContent = phoneBook.Skip((pageNumber - 1) * 2).Take(2);
//                Console.WriteLine();

//                // выводим результат
//                foreach (var item in pageContent)
//                {
//                    Console.WriteLine(item.Name + " " + item.LastName + ": " + item.PhoneNumber);
//                }
//                Console.WriteLine();
//            }
//        }
//    }



public class Car
{
    public string Manufacturer { get; set; }
    public string CountryCode { get; set; }

    public Car(string manufacturer, string countryCode)
    {
        Manufacturer = manufacturer;
        CountryCode = countryCode;
    }
}
public class Contact
{
    public string Name { get; }
    public string LastName { get; }
    public long PhoneNumber { get; }
    public string Email { get; }

    public Contact(string name, string lastName, long phoneNumber, string email)
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;

    }
}
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
    public List<string> Coarse { get; set; }
}
public class Application
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
}


public class Manufacturer
{
    public string Name { get; set; }
    public string Country { get; set; }
}

public class Car1
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
}

