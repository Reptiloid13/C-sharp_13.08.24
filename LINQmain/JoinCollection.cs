using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LINQ;
/// <summary>
/// Соединение в LINQ позволяет объединить разные наборы объектов в коллекциях по общим свойствам, по аналогии с тем, как мы объединяем разные таблицы по общему ключу в SQL(будет изучаться в последующих модулях), используя операторы Join.
/// </summary>
public class JoinCollection
{
    /// <summary>
    /// Как правило, эту операцию можно применять к двум наборам коллекций, имеющим общий критерий.
    /// </summary>
    public static void JoinExample()
    {
        var cars = new List<Car1>()
        {
            new Car1() { Model  = "SX4", Manufacturer = "Suzuki"},
   new Car1() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
   new Car1() { Model  = "Jimny", Manufacturer = "Suzuki"},
   new Car1() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
   new Car1() { Model  = "Camry", Manufacturer = "Toyota"},
   new Car1() { Model  = "Polo", Manufacturer = "Volkswagen"},
   new Car1() { Model  = "Passat", Manufacturer = "Volkswagen"},
        };
        var manufactures = new List<Manufacturer>()
        {
              new Manufacturer() { Country = "Japan", Name = "Suzuki" },
   new Manufacturer() { Country = "Japan", Name = "Toyota" },
   new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
        };

        // Соединим и сопоставим коллекции: 

        var result = from car in cars // выберем машины
                     join m in manufactures on car.Manufacturer equals m.Name  // соединим по общему ключу (имя производителя) с производителями
                     select new //   спроецируем выборку в новую анонимную сущность
                     {
                         Name = car.Model,
                         Manufacturer = m.Name,
                         Country = m.Country

                     };


        // выведем результаты
        foreach (var item in result)
            Console.WriteLine($"{item.Name} - {item.Manufacturer} ({item.Country})");

        //Extansion
        var result2 = cars.Join(manufactures,// передаем в качестве параметра вторую коллекцию
            car => car.Manufacturer, // указываем общее свойство для первой коллекции
            m => m.Name,
            (car, m) =>
            new
            {
                Name = car.Model,
                Manufacturer = m.Name,
                Country = m.Country
            });


    }
    /// <summary>
    /// Соедините данные и выведите на экран, кто работает в каком отделе
    /// </summary>
    public static void Task1541()
    {
        var departments = new List<Department>()
        {
            new Department() {Id = 1, Name = "Программирование"},
            new Department() {Id = 2, Name = "Продажи" }
        };

        var employees = new List<Employee>()
        {
              new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
   new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
   new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
   new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4}
        };

        var result = from employee in employees
                     join dep in departments on employee.DepartmentId equals dep.Id//  соединяем коллекции по общему ключу

                     select new // выборка в новую сущность
                     {
                         EmployeeName = employee.Name,
                         DepartmentName = dep.Name

                     };
        foreach (var item in result)
            Console.WriteLine(item.EmployeeName + ", отдел: " + item.DepartmentName);

        //Extansion 
        var result2 = employees.Join(departments,
            emp => emp.DepartmentId,
            dep => dep.Id,
            (emp, dep) =>
            new
            {
                EpmloyeeName2 = emp.Name,
                DepartmentName2 = dep.Name
            });


    }
    public static void Task1542()
    {
        var departments = new List<Department>()
   {
       new Department() {Id = 1, Name = "Программирование"},
       new Department() {Id = 2, Name = "Продажи"}
   };

        var employees = new List<Employee>()
   {
       new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
       new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
       new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
       new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
   };



        var result2 = employees.GroupJoin(departments,
            emp => emp.DepartmentId,
            dep => dep.Id,
            (emp, dep) => new
            {
                EmlployeeName2 = emp.Name,
                DepartamentName2 = dep.Name,
            });
    }
}

public class Department
{
    public string Name { get; set; }
    public int Id { get; set; }
}
public class Employee
{
    public string Name { get; set; }
    public int DepartmentId { get; set; }
    public int Id { get; set; }
}