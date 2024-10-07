namespace List;

class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        var copyPeople = people;

        var john = new Person() { FirstName = "John", LastName = "Ivanov", Age = 31 };
        var johnCopy = john;

        johnCopy.LastName = "Ivanov changed";

        Console.WriteLine(john.LastName);
        Console.WriteLine(johnCopy.LastName);

        bool x = 1 == 0;

        if (x)
        {
        }

        Console.WriteLine(john == johnCopy); // true
        Console.WriteLine(new Person() { } == new Person() { }); // false
        Console.WriteLine("Hello" == "Hello"); // true

        people.Add(john);
        people.Add(new Person() { FirstName = "Enrique", LastName = "Fedorchuk", Age = 21 });
        people.Add(new Person() { FirstName = "Leonardo", LastName = "DaVcitor", Age = 49 });

        copyPeople[0].FirstName = "John changed";

        PrintPersons(people);
        PrintPersons(copyPeople);

        // PrintPersons(people);
        // people.RemoveAt(1);
        people.Remove(john);
        // PrintPersons(people);

        Console.WriteLine("List of peole: ");

        // foreach (Person person in people)
        // {
        //     // Спрятать в метод toString у Person
        //     Console.WriteLine($"{person.FirstName}, {person.LastName}, {person.Age}");
        // }
    }

    public static void PrintPersons(List<Person> people)
    {
        for (int i = 0; i < people.Count; i++)
        {
            var person = people[i];
            Console.WriteLine($"index = {i}, {person.FirstName}, {person.LastName}, {person.Age}");
        }
    }
}

class Person
{
    //Сохранение списка объектов: Создайте
    //класс Person, и создайте список объектов этого класса.
    //Заполните список, а затем выведите данные всех людей
    //на консоль.
    public string FirstName;
    public string LastName;
    public int Age;
}