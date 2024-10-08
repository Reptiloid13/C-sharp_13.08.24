
namespace List;

class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();





        people.Add(new Person() { FirstName = "John", LastName = "Ivanov", SurName = "Jimmovich", Age = 31 });
        people.Add(new Person() { FirstName = "Enrique", LastName = "Fedorchuk", SurName = "Iglesiovich", Age = 21 });
        people.Add(new Person() { FirstName = "Leonardo", LastName = "DaVcitor", SurName = "Olegovich", Age = 49 });


        ;

        // people.RemoveAt(1);

        // PrintPersons(people);

        Console.WriteLine("List of peole: ");

      Console.WriteLine(people.ToString()); // ВОПРОС -  Почему не вывозидится список ? 

        // foreach (Person person in people)
        // {
        //     // Спрятать в метод toString у Person
        //     Console.WriteLine($"{person.FirstName}, {person.LastName}, {person.Age}");
        // }
    }
    // public static void PrintPersons(List<Person> people)
    //{

//    }
    //public static void PrintPersons(List<Person> people)
    //{
    //    for (int i = 0; i < people.Count; i++)
    //    {
    //        var person = people[i];
    //        Console.WriteLine($"index = {i}, {person.FirstName}, {person.LastName}, {person.Age}");
    //    }
    //}
}

class Person
{
    //Сохранение списка объектов: Создайте
    //класс Person, и создайте список объектов этого класса.
    //Заполните список, а затем выведите данные всех людей
    //на консоль.
    public string FirstName;
    public string LastName;
    public string SurName;
    public int Age;
    public override string ToString()
    {
        return $"{FirstName}, {LastName}, {SurName}, {Age}";
    }
}