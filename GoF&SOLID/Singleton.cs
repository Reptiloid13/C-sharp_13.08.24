using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_SOLID;

public class Singleton
{
    public static void GetSingleton()
    {
        // создаем объект приложения
        Application app = new Application();

        // запускаем наше приложение (внутри создается соединение с базой данных по переданному адресу)
        app.Launch("10.30.60.80");
        Console.WriteLine(app.DbConnection.Configuration);
        // Теперь пробуем создать новое соединение с базой данных уже по другому адресу
        app.DbConnection = DbConnection.GetConnectionInstance("10.30.60.80");
        // у нас не получилось, так как объект уже существует
        Console.WriteLine(app.DbConnection.Configuration);

    }
}

public class DbConnection
{
    private static DbConnection Connection;

    public string Configuration { get; private set; }

    protected DbConnection(string configuration)
    {
        Configuration = configuration;
    }
    /// <summary>
    /// Реализация Синглтона не позволяет нам плодить новые объекты, если объект уже существует
    /// </summary>

    public static DbConnection GetConnectionInstance(string dbServer)
    {
        if (Connection == null)
            Connection = new DbConnection(dbServer);
        return Connection;
    }

}
/// <summary>
/// Теперь создадим объект нашего приложения: 
/// </summary>
public class Application
{
    public DbConnection DbConnection { get; set; }
    public void Launch(string dbServer)
    {
        DbConnection = DbConnection.GetConnectionInstance(dbServer);
    }
}