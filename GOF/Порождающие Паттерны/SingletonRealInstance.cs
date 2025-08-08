using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF;

class SingletonRealInstance
{
    public static void Example()
    {
        Application app = new Application(); //TODO Почему здесь ошибка

        app.Launch("10.30.60.80");
        Console.WriteLine(app.DbConnection.Configuration);
        // Теперь пробуем создать новое соединение с базой данных уже по другому адресу
        app.DbConnection = DbConnection.GetConnectionInstance("10.30.60.81");
        // у нас не получилось, так как объект уже существует
        Console.WriteLine(app.DbConnection.Configuration);

    }
}
class DBConnection
{
    private static DBConnection Connection;
    public string Configuration { get; private set; }

    protected DBConnection(string configuration)
    {
        Configuration = configuration;
    }
    /// <summary>
    /// Реализация Синглтона не позволяет нам плодить новые объекты, если объект уже существует
    /// </summary>
    public static DBConnection GetConnectionInstance(string dbServer)
    {
        if (Connection == null)
            Connection = new DBConnection(dbServer);
        return Connection;
    }
    /// <summary>
    /// Теперь создадим объект нашего приложения: 
    /// </summary>
    class Application
    {
        public DBConnection DBConnection { get; set; }
        public void Launch(string dbServer)
        {
            DBConnection = DBConnection.GetConnectionInstance(dbServer);
        }
    }

}
