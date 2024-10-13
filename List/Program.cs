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

        GetInitials getinitials = new GetInitials();
        getinitials.GetInitials(person);
    }

    public  string GetInitials(Person person)
    {
        return $"{person.FirstName[0]}. {person.SecondName[0]}. {person.LastName}"; // А. А. Тестов
    }

    public static void PrintPeople(List<Person> people)
    {
        Console.WriteLine("List of people: ");
        foreach (var person in people)
            Console.WriteLine(GetInitials(person));

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
}