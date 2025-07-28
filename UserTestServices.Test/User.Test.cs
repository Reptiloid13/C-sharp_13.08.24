using Moq;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTestService;

namespace UserTestServices.Test;
/// <summary>
/// Выполните тестирование функции FindAll при помощи moq-объекта. Используйте следующие три имени пользователей для добавления в moq-коллекцию: Антон, Иван, Алексей. При написании теста используйте фреймворк NUnit. Для проверки наличия элемента в коллекции используйте метод That класса Assert и метод Any синтаксиса Linq.
/// </summary>

public class UserTest
{
    public void FindAllMustReturnNames()
    {
        var list = new List<User>
        {
            new User()
            {
                Name = "Anton"
            },
            new User()
            {
                Name = "Ivan"
            },
            new User()
            {
                Name = "Aleksey"
            }
        };
        Mock<IUsertRepository> mock = new Mock<IUsertRepository>();
        mock.Setup(v => v.FindAll()).Returns(list);

        Assert.That(mock.Object.FindAll().Any(user => user.Name == "Anton"));
        Assert.That(mock.Object.FindAll().Any(user => user.Name == "Ivan"));
        Assert.That(mock.Object.FindAll().Any(user => user.Name == "Aleksey"));

    }
}