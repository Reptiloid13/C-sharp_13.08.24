namespace OOP;

public class GettersSetters
{
    public static void Test()
    {
        var user = new User("Иван", 25);
        Console.WriteLine(user.Age);
        Console.WriteLine(user.Name);
    }
}

class User
{
    public string Name;
    public int Age;

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
}