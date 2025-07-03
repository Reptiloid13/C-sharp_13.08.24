using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collections;

public class List
{

    public static void Exapmple1()
    {
        // Создаем список с типом данных Contact
        var phoneBook = new List<Contact>();

        // добавляем котакты

        phoneBook.Add(new Contact("Igor", 79990000, "igor@examle.com"));
        phoneBook.Add(new Contact("Andrew", 7989000, "andrew@example.com"));

        //Проверяем что добавилось в список

        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"{contact.Name} : {contact.PhoneNumber}");
        }

    }
    //Напишите метод для нашей телефонной книги, который получает на вход список и новый контакт,
    //и добавляет его, только если он уникален.
    public static void Task1334(Contact newContact, List<Contact> phoneBook)
    {
        bool alreadyExists = false;

        // Пробегаемся по списку и смотрим, есть ли уже с таким именем
        foreach (var contact in phoneBook)
        {
            if (contact.Name == newContact.Name)
            {
                // если вдруг находим -выставляем флаг и прерываем цикл 
                alreadyExists = true;
                break;

            }
        }
        if (!alreadyExists)
            phoneBook.Add(newContact);

        // сортируем список по имени

        phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"{contact.Name} : {contact.PhoneNumber}");
        }




    }

    //Напишите метод, который примет на вход обе коллекции, вырежет
    //из второй недостающие месяцы и добавит в наш список. Затем выведет результат в консоль.

    public static void Task1335()
    {
        var month = new List<string>()
        {
            "Jan", "Feb", "Mar", "Apr", "May"
        };

        var missing = new ArrayList()
        {
           1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };
    }

    private static void GetMissing(List<string> months, ArrayList missing)
    {
        //Инициализируем массив для 7 нужных нам недостающих элементов 
        var missedArray = new string[7];

        // Извлекаем эти элементы из ArrayList и копируем в массив

        missing.GetRange(4, 7).CopyTo(missedArray);

        // добавляем наш массив в конец списка 

        months.AddRange(missedArray);

        // смотрим, что получилось

        foreach (var month in months)
            Console.WriteLine(month);
    }

}

public class Contact // модель класса
{

    public string Name { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contact(string name, long phoneNumber, string email) // метод коснтруктор 
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}
