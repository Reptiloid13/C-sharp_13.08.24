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