using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_SOLID;

/// <summary>
/// Применять стоит в следующих случаях: 
/// 1. Ваша система не должна зависеть от способа компоновки объектов.
/// 2. Объекты в вашей системе должны использоваться вместе и быть взаимосвязанными.
/// </summary>
public class AbstractFactory
{
    public static void GetFactory()
    {
        // Создание дракона через фабрику
        var dragon = new Monster(new DragonFactory());
        dragon.Move();
        dragon.Hit();

        Console.WriteLine();

        // Создание орка через фабрику
        var orc = new Monster(new OrcFactory());
        orc.Move();
        orc.Hit();
        Console.WriteLine();
        Console.WriteLine("Всем конец...");

    }

}
/// <summary>
///  Базовый интерфейс для движения
/// </summary>
public interface IMovement
{
    void Start();
}


/// <summary>
///  /// Большинству наземных монстров доступен бег
/// </summary>
public class RunMevement : IMovement
{
    public void Start()
    {
        Console.WriteLine("RUN");
    }
}
public class FlyMovement : IMovement
{
    public void Start()
    {
        Console.WriteLine("FLY");
    }
}
/// <summary>
/// Создадим модели оружия: 
/// </summary>
public interface IWeapon
{
    void Attack();
}
public class Axe : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Hit with the Axe");
    }
}
public class FireBreath : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Breathe Fire");
    }
}
/// <summary>
/// Перейдем к созданию абстрактной фабрики:
/// </summary>
public interface IMonsterFactory
{
    IMovement CreateMovement();
    IWeapon CreateWeapon();
}
/// <summary>
/// Создадим конкретные реализации фабрики: 
/// </summary>
public class DragonFactory : IMonsterFactory
{
    public IMovement CreateMovement()
    {
        return new FlyMovement();
    }
    public IWeapon CreateWeapon()
    {
        return new FireBreath();
    }
}
public class OrcFactory : IMonsterFactory
{
    public IMovement CreateMovement()
    {
        return new RunMevement();
    }
    public IWeapon CreateWeapon()
    {
        return new Axe();
    }
}
/// <summary>
/// Создадим класс монстра, где будут использоваться фабрики: 
/// </summary>
public class Monster
{
    private IWeapon _weapon;
    private IMovement _movement;

    /// <summary>
    /// Метод - конструктор, где создаются объекты при помощи фабрики
    /// </summary>
    public Monster(IMonsterFactory factory)
    {
        _weapon = factory.CreateWeapon();
        _movement = factory.CreateMovement();
    }
    public void Move() { _movement.Start(); }
    public void Hit() { _weapon.Attack(); }
}
