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

//6. Создайте класс BankAccount с методом экземпляра deposit, который добавляет деньги на счет
//    .Добавьте в класс статический метод getTotalBalance, который возвращает общую сумму денег на всех счетах
//    .Создайте два экземпляра класса BankAccount и вызовите метод deposit для каждого.


public class GetDoposit
{
    public static void Test()
    {
        BankAccount account1 = new BankAccount(0);
        account1.Deposit(100); // Почему присваем значение через скобочки? 
        BankAccount account2 = new BankAccount(0);
        account2.Deposit(200);
        Console.WriteLine($"Total Balance: {BankAccount.GetTotalBalance()}");


    }

}


    class BankAccount
{
    public decimal Balance; // Можно ли писать переменные с маленькой буквы?
    public static decimal TotalBalance = 0;

    public BankAccount(decimal balance) //Какой смысл от конструктора здесь? 
    {
        Balance = balance;

    }

    public void Deposit(decimal amount) // Зачем нам конструктор, когда мы можем  присваивать значение без него?
    {
        Balance += amount;
        TotalBalance += amount;
    }
    public static decimal GetTotalBalance()
    {
        return TotalBalance;
    }
}

