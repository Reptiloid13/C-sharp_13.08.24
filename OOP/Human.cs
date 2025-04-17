using OOP;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Задание 2. Создать класс, описывающий 
    //    человека(фамилия, имя, отчество при наличии, дата рождения).

    public class Human
    {
        public string Name;
        public string SecondName;
        public DateTime DateOfBirth;
        public Human(string name, string secondName, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            SecondName = secondName;
        }

        public override string ToString()

        {
            return ($"My name is {Name} {SecondName}. My age - {DateOfBirth:dd.MM.yyyy}");
        }

        public static void HumanMain()
        {
            Human human = new Human("John", "Travolta", new DateTime(1993, 12, 02));
            Console.WriteLine(human.ToString());

        }

    }
}
//Задание 1. Создать класс, описывающий домашнее животное. 
//    Много свойств (переменных) делать не нужно. Достаточно описать имя(кличку), вид, породу.
public class Animal
{
    public string Name;
    public string Type;
    public string Breed;
    public Human Owner;

    public Animal(string name, string type, string breed) { Name = name; Type = type; Breed = breed; }



    public override string ToString()
    {
        var result = $"Кличка - {Name}  Вид  - {Type}  Порода - {Breed}";
        if (Owner != null)
        {
            result += $" Владелец - {Owner.Name} {Owner.SecondName}";
        }
        return result;
    }
    public static void GreetingsMain()
    {


        Animal animal = new Animal("Rex", "Dog", "Bulldog");
        animal.Owner = new Human("John", "Travolta", new DateTime(1993, 12, 02));
        Console.WriteLine(animal.ToString());
    }
}

public class User
{
    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть больше 18 ");
            }
            else
            {
                _age = value;
            }

        }
    }

    private string _login;
    public string Login
    {
        get { return _login; }
        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Логин должен быть больше 2 ух символов");
            }
            else
            {
                _login = value;
            }
        }
    }

    private string _email;
    public string Email
    {
        get { return _email; }
        set
        {
            if (!value.Contains('@'))
            {
                Console.WriteLine(" Не верный формат");
            }
            else
            {
                _email = value;
            }
        }
    }
}

class BaseClass
{
    protected string Name;
    public virtual int Counter { get; set; } // 7.2.4 Измените свойство Counter так, чтобы его можно было переопределить в классе DerivedClass.
                                             // Переопределите данное свойство, ограничив занесения в него чисел меньше 0.
    public BaseClass(string name)
    {
        Name = name;
    }
    public virtual void Display() // 7.2.3 Реализуйте в классе BaseClass виртуальный метод Display с типом void и без параметров,
                                  // который будет выводить сообщение "Метод класса BaseClass" в консоль,
                                  // а затем переопределите его в DerivedClass, чтобы он выводил сообщение "Метод класса DerivedClass".виртуальный метод 
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public string Description;
    private int _counter;//7.2.4 - Продолжение решения 
    public override int Counter // /7.2.4 - Продолжение решения 
    {
        get
        {
            return _counter;
        }
        set
        {
            if (_counter < 0)
            {
                Console.WriteLine("Counter have to be >0");
            }
            else
            {
                _counter = value;
            }
        }
    }


    public DerivedClass(string name, string description) : base(name)
    {
        Description = description;
        Name = name;
    }
    public DerivedClass(string name, string description, int counter) : base(name)
    {
        Description = description;
        Counter = counter;
    }
    public override void Display() // 7.2.3 - Продолжение решения 
    {
        base.Display(); //7.2.5  Вернитесь к заданию 7.2.3 и дополните его код так, чтобы для вызова следующего следующего код
                        //в консоль выводилось 2 сообщения (сначала "Метод класса BaseClass", а затем "Метод класса DerivedClass"):
        Console.WriteLine("Метод класса DerivedClass");
    }

}

//Задание 7.2.7
//Создайте схему классов A, B, C, D и E таким образом,
//чтобы B наследовался от A, С от A, D от B и E от C. А также:
//1. Добавьте в класс A виртуальный метод Display (void тип, без параметров), который будет выводить в консоль "A".
//2. В классе B скройте этот метод и сделайте так, чтобы в консоль выводилось "B".
//3. Для класса C переопределите метод Display, чтобы в консоли было "C".
//4. Для D снова скройте метод.
//5. В классе E также скройте метод.

public class A
{
    public virtual void Displsy()
    {
        Console.WriteLine("A");
    }
}
public class B : A
{
    public new void Displsy()
    {
        Console.WriteLine("B");
    }
}
public class C : A
{
    public override void Displsy()
    {
        Console.WriteLine("C");
    }
}
public class D : B
{
    public new void Display()
    {

    }
}
public class E : C
{
    public new void Display()
    {

    }
}

//Задание 7.3.3
//Создайте классы для следующих объектов компьютера:
//процессор(Processor), материнская карта(MotherBoard), видеокарта(GraphicCard).Унаследуйте их от класса ComputerPart.
//Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.
public abstract class ComputerPart
{
    public abstract void Work()
    {

    }
}
public class Processor : ComputerPart
{
    public override void Work()
    {

    }
}

public class MotherBoard : ComputerPart
{
    public override void Work()
    {

    }
}
//Задание 7.6.2
//Создайте класс-обобщение Car для автомобиля. Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый). Для типов двигателей также создайте классы — ElectricEngine и GasEngine.

//В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.

//Задание 7.6.7
//Добавьте к схеме классов автомобиля следующие классы частей автомобиля:
// Battery, Differential, Wheel. Также добавьте в класс Car виртуальный обобщённый метод без реализации 
//    ChangePart, который будет принимать один параметр — 
//    newPart универсального типа.

//Задание 7.6.9
//Установите ограничения на универсальные типы в классе Car.
//    Такие, чтобы поле Engine могло принимать тип ElectricEngine и GasEngine,
//    а параметр newPart метода ChangePart мог бы принимать только типы частей машины (Battery, Differential, Wheel).

//Для этого вам может понадобиться использовать один из ранее изученных принципов ООП.

class Car<TEngine> where TEngine : Engine

{
    public TEngine Engine;
    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart

    {

    }
}

class Engine
{

}
class ElecrticEngine : Engine
{

}

class GasEngine : Engine
{

}

class Battery : CarPart
{

}
class Diffferential : CarPart
{

}
class Wheel : CarPart
{

}
class CarPart
{

}

//Реализуйте класс-обобщение Record, у которого будут два универсальных параметра: 
//    один — для идентификатора записи (Id), другой — для значения записи (Value). Также в классе реализуйте поле Date типа DateTime.

class Record<T1, T2>
{
    public T1 Id;
    public T2 Value;
    public DateTime Date;
}