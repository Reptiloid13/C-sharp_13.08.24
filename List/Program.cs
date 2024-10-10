
namespace List;

class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();





        people.Add(new Person() { FirstName = "John", LastName = "Ivanov", SecondName = "Jimmovich", Age = 31 });
        people.Add(new Person() { FirstName = "Enrique", LastName = "Fedorchuk", SecondName = "Iglesiovich", Age = 21 });
        people.Add(new Person() { FirstName = "Leonardo", LastName = "DaVcitor", SecondName = "Olegovich", Age = 49 });




        // people.RemoveAt(1);

        PrintPersons(people);

        Console.WriteLine("List of peole: ");

        //Console.WriteLine(people.ToString()); // ВОПРОС -  Почему не вывозидится список ? 

        // foreach (Person person in people)
        // {
        //     // Спрятать в метод toString у Person
        //     Console.WriteLine($"{person.FirstName}, {person.LastName}, {person.Age}");
        // }
    }
    public static void PrintFirstLetters(List<Person> people)
    {
        var secondname = people[0].SecondName;

        var firstname = people[0].FirstName;

        Console.WriteLine($"{firstname}, {secondname}");


    }
    public static void PrintPersons(List<Person> people)
    {
        for (int i = 0; i < people.Count; i++)
        {
            var person = people[i];
            Console.WriteLine($"index = {i}, {person.FirstName}, {person.LastName}, {person.SecondName} {person.Age}");
        }
    }
    //public override string ToString(List<Person> people) // Попробовал вывести в отдельный методвне класса, но все равно ошибка 
    //{
    //    foreach(Person person in people)
    //    return $"{person.FirstName}, {person.LastName}, {person.SecondName}, {person.Age}";
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
    public string SecondName;
    public int Age;
    //public override string ToString()
    //{
    //    return $"{FirstName}, {LastName}, {SurName}, {Age}";
    //}
}