//namespace SkillFactory.Tasks;


//internal class Program
//{

//    static void Main(string[] args)
//    {
//        Car ferarri = new Car("F40", 471, 30, 317.0f); // Создаали конструктор и задали параметры в скобках, то что ниже уже не нужно.
//        //ferarri.Name = "F40"; 
//        //ferarri.HorsePower = 471;
//        //ferarri.Age = 30;
//        //ferarri.MaxSpeed = 317.0f;


//        Car maserati = ferarri;
//        maserati.HorsePower = 1000;
//        ferarri.ShowTechnicalPassport();
//        ferarri.BecomeOlder(5, 50); // Ввводим в место значения  5 - года ; 50 - пройдено километро
//        Console.WriteLine();
//        ferarri.ShowTechnicalPassport();



//    }


//}

//class Car
//{
//    public string Name;
//    public int HorsePower;
//    public int Age;
//    public float MaxSpeed;

//    public Car(string name, int horsePower, int age, float maxSpeed) // Конструктор
//    {
//        Name = name;
//        HorsePower = horsePower;
//        Age = age;
//        MaxSpeed = maxSpeed;

//    }

//    public void ShowTechnicalPassport()
//    {
//        Console.WriteLine($"Название авто: {Name}; \nКоличество лошадиных сил: {HorsePower} \nВозраст авто: {Age} \nМаксимальная скорость:{MaxSpeed} км/ч");
//    }
//    public void BecomeOlder(int years, int runAwayHorses)
//    {
//        Age += years;
//        HorsePower -= runAwayHorses;
//    }

//}

