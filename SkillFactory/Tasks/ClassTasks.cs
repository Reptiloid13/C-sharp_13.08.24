//namespace SkillFactory.Tasks;

//public class ClassTasks
//{
//    public static User GetUser(int age, string name)
//    {
//        var user = new User() { Age = age, Name = name, };
//        // user.Age = age;
//        // user.Name = name;
//        return user;
//    }
//}

//// static значит, что для вызова этого метода не нужно создавать объект.
//// Значимые типы данных копируются и сравниваются по значению, ссылочные по ссылке.

//public class User
//{
//    private int HandsCount = 2;
//    public int Age;
//    public string Name;

//    public void PrintUser()
//    {
//        Console.WriteLine($"Name: {Name}, Age: {Age}, HandsCount: {HandsCount}");
//    }
//}

//public class Auto
//{
//    public void Start()
//    {
//        if (CheckEngine() == true)
//            Console.WriteLine("Едем");
//        else
//            Console.WriteLine("Проверьте двигатель");
//    }

//    private bool CheckEngine()
//    {
//        return true;
//    }
//}