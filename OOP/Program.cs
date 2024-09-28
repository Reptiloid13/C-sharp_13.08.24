//var fromColor = new Color() { Blue = 100, Green = 100, Red = 100 };
//var toColor = new Color() { Blue = 110, Green = 200, Red = 200 };
//ColorTask.GetColorShades(fromColor, toColor, 10);

var obj = new A(1) { N = 2 };
Console.WriteLine(obj.N);



var employee = new Employee(1); // Саркис
employee.GetOldestEmployee([new Employee(2), new Employee(3), new Employee(4), new Employee(5), new Employee(6)]);

var oldest = Employee.GetOldestEmployeeStatic([employee, new Employee(2), new Employee(3), new Employee(4), new Employee(5), new Employee(6)]);

class A
{
    public int N;

    public A(int n)
    {
        Console.WriteLine("Конструктор");
        Console.WriteLine(N);
        N = n;
    }
}


class Employee
{
    public int Age;

    public Employee(int age)
    {
        Age = age;
    }

    public Employee GetOldestEmployee(Employee[] othersEmployees)
    {
        Age = 4;
        // ...
    }

    public static Employee GetOldestEmployeeStatic(Employee[] othersEmployees)
    {
        // ...
    }
}

// 10 100 - 6 = 90 / 5 = 18
// 10 20 30 - 3 // 20 / (3 - 1) = 20 / 2 = 10

var shades = Color.GetColorShades(new Color(10, 10, 10), new Color(20, 20, 20), 3);
// 10, 10, 10
// 15, 15, 15
// 20, 20, 20
// 20 - 10 = 10 / (3-1) = 10 / 2 = 5

struct Color
{
    public int Red;
    public int Green;
    public int Blue;

    public Color(int red, int green, int blue)
    {
        Red = red; Green = green; Blue = blue;
    }

    public Color[] GetColorShades(Color fromColor, Color toColor, int shadesCount)
    {
        Color[] shades = new Color[shadesCount];

        for (int i = 0; i < shadesCount; i++)
        {
            fromColor.Red = (110 - 100) / 10 - 1;


        }



        return shades;
    }
}


/*
RGB: (100,100,100)
RGB: (110,110,101)
RGB: (120,120,102)
RGB: (130,130,103)
RGB: (140,140,104)
RGB: (150,150,105)
RGB: (160,160,106)
RGB: (170,170,107)
RGB: (180,180,108)
RGB: (200,200,110)
*/