namespace List;

class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        people.Add(new Person() { FirstName = "John", LastName = "Ivanov", SecondName = "Jimmovich", Age = 31 });
        people.Add(new Person()
            { FirstName = "Enrique", LastName = "Fedorchuk", SecondName = "Iglesiovich", Age = 21 });
        people.Add(new Person() { FirstName = "Leonardo", LastName = "DaVcitor", SecondName = "Olegovich", Age = 49 });

        var word = "apple";
        var a = word[0];


        PrintPeople(people);

        Person person = new Person() { FirstName = "John", LastName = "Ivanov", SecondName = "Jimmovich", Age = 31 };
        string initials = person.GetInitials();
        Console.WriteLine(initials);

        person.PrintLastNameAndAge();

        // GetInitials(person);
    }

    // Для статического метода не нужен экземпляр класса
    public static void PrintPeople(List<Person> people)
    {
        Console.WriteLine("List of people: ");
        foreach (var person in people)
        {
            var initials = person.GetInitials();
            Console.WriteLine(initials);
        }
    }
}

class Person
{
    public string FirstName;
    public string LastName;
    public string SecondName;
    public int Age;

    public override string ToString()
    {
        return $"{FirstName}, {LastName}, {SecondName}, {Age}";
    }

    public string GetInitials()
    {
        return $"{FirstName[0]}. {SecondName[0]}. {LastName}"; // А. А. Тестов
    }

    // Иванов, 26
    public void PrintLastNameAndAge()
    {
        Console.WriteLine($"{LastName}, {Age}");
    }
}