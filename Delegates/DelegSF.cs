using Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2;

public class DelegSF
{
}



//Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек.
//    Сортировка должна происходить при помощи события.Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).


public class InvalidDigitException : Exception
{
    public override string Message { get; } = "Сортировку можно задать либо число 1( по возрастанию), либо число 2(по убыванию)";
}
public class Person()
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
}


public class FinallyTask()
{
    public delegate void GetSortAscDelegate(List<Person> names);
    public delegate void GetSortDescDelegate(List<Person> names);

    public static event GetSortAscDelegate GetSortAscEvent;
    public static event GetSortDescDelegate GetSortDescEvent;



    public static void TaskDeleg()
    {

        List<Person> people = People();
        GetSortAscEvent += GetSortAsc;
        GetSortDescEvent += GetSortDesc;

        try
        {
            var variant = Console.ReadLine();
            if (variant == "1")
            {
                GetSortAscEvent?.Invoke(people);
            }
            if (variant == "2")
            {
                GetSortDescEvent?.Invoke(people);
            }
            else if (variant != "1" && variant != "2")
            {
                throw new InvalidDigitException();

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    public static List<Person> People()
    {
        List<Person> person = new List<Person>();
        person.Add(new Person() { Name = "John", LastName = "Travolta", DateOfBirth = "1980" });
        person.Add(new Person() { Name = "Jack", LastName = "Sorrow", DateOfBirth = "1754" });
        person.Add(new Person() { Name = "Van", LastName = "Dam", DateOfBirth = "1987" });
        person.Add(new Person() { Name = "Arnold", LastName = "Swrtz", DateOfBirth = "1976" });
        person.Add(new Person() { Name = "Silvester", LastName = "Stallone", DateOfBirth = "1978" });


        return person;

    }

    public static void GetSortAsc(List<Person> names)
    {
        names.Sort((x, y) => x.LastName.CompareTo(y.LastName));
        PrintPeople(names);


    }
    public static void GetSortDesc(List<Person> names)
    {
        {
            names.Sort((x, y) => y.LastName.CompareTo(x.LastName));
            PrintPeople(names);

        }



    }
    public static void PrintPeople(List<Person> people)
    {
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.LastName}, {person.Name} {person.DateOfBirth}");
        }
    }
}