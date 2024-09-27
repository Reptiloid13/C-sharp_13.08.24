using OOP;



//var fromColor = new Color() { Blue = 100, Green = 100, Red = 100 };
//var toColor = new Color() { Blue = 110, Green = 200, Red = 200 };
//ColorsTask.GetColorShades(fromColor, toColor, 10);

var obj = new A(1) {N = 2};
Console.WriteLine(obj.N);

class A {
    public int N;

    public A(int n)
    {
        Console.WriteLine("Конструктор");
        Console.WriteLine(N);
        N = n;
    }
}


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
            int red = i * 10 + 100;
            int green = i * 10 + 100;
            int blue = i * 10 + 100;
            shades[i] = new Color(red, green, blue);
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