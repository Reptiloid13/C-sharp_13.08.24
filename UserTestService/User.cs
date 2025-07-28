using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTestService;

public interface IUsertRepository
{
    IEnumerable<User> FindAll();
}

public class UserRepository : IUsertRepository
{
    public IEnumerable<User> FindAll()
    {
        return null;
    }
}
public class User
{
    public string Name { get; set; }
}
