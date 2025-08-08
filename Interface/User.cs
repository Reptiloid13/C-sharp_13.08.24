using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public class InterfaceExample
{
    public static void Example()
    {
        User user1 = new User("Josef", 26);
        User user2 = new User("Mark", 27);

        User[] users = new User[] { user1, user2 };
        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

}
public class UsersStorage : IEnumerable
{
    private readonly User[] users;
    public UsersStorage(User[] users)
    {
        this.users = users;
    }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class UsersStorageEnumerator : IEnumerator
{
    public object Current => throw new NotImplementedException();
    public bool MoveNext()
    {
        throw new NotImplementedException();
    }
    public void Reset()
    {
        throw new NotImplementedException();
    }
}

