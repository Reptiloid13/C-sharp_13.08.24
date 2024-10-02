
//var shades = Color.GetColorShades(new Color(100, 100, 100), new Color(200, 200, 110), 10);
//foreach (var shade in shades)
//    Console.WriteLine(shade.ToString());

// var N = ReadPositiveInt("Введите количество чисел N: ");
// var nums = ReadIntegers(N);
// var reversed = Reverse(nums);
// Console.WriteLine(string.Join(", ", reversed));

static int[] ReadIntegers(int n)
{
    int[] numbers = new int[n];
    var items = Console.ReadLine().Split(' '); // ["1", "2", "3", ...] 
    
    var nums = new int[n]; // [1, 2, 3, ...] 

    for (int i = 0; i < items.Length; i++)
    {
        nums[i] = Convert.ToInt32(items[i]);
    }

    // "a b c".Split(" "); // ["a", "b", "c"]
    // "abc".Split(" "); // ["abc"]

    return nums; 
}

static int ReadPositiveInt(string message)
{
    int value;
    do
    {
        Console.Write(message);
    } while (int.TryParse(Console.ReadLine(), out value) == false);

    return value;
}




static int[] Reverse(int[] nums)
{
    var n = nums.Length;
    for (int i = 0; i < nums.Length / 2; i++)
    {
        // nums[i] - текущий элемент массива
        // nums[n - i - 1] - отзеркаленный
        // nums[nums.Length - i - 1] - отзеркаленный

        //var temp = nums[i];
        //nums[i] = nums[n - i - 1];
        //nums[n - i - 1] = temp;

        (nums[i], nums[n-i-1]) = (nums[n-i-1], nums[i]); // Меняем две инт переменной без третьей 


    }
    return nums; 
}

static void SumElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    Console.WriteLine(sum);
}

//struct Color
//{
//    public int Red;
//    public int Green;
//    public int Blue;

//    public Color(int red, int green, int blue)
//    {
//        Red = red; Green = green; Blue = blue;
//    }
    
//    public override string ToString()
//    {
//        return $"Red: {Red}, Green: {Green}, Blue: {Blue}";
//    }

//    public static Color[] GetColorShades(Color fromColor, Color toColor, int shadesCount)
//    {
//        var shades = new Color[shadesCount];
//        shades[0] = fromColor;
//        shades[shadesCount - 1] = toColor;

//        for (int i = 1; i < shadesCount - 1; i++)
//        {
//            var redStep = (toColor.Red - fromColor.Red) / (shadesCount - 1);
//            var greenStep = (toColor.Green - fromColor.Green) / (shadesCount - 1);
//            var blueStep = (toColor.Blue - fromColor.Blue) / (shadesCount - 1);
            
//            var prevColor = shades[i - 1];
//            var color = new Color(prevColor.Red + redStep, prevColor.Green + greenStep, prevColor.Blue + blueStep);
            
//            shades[i] = color;
//        }

//        return shades;
//    }
//}


/*
RGB: (100,100,100) 0
RGB: (110,110,101) 1
RGB: (120,120,102) 2
RGB: (130,130,103) 3
RGB: (140,140,104) 4
RGB: (150,150,105) 5
RGB: (160,160,106) 6
RGB: (170,170,107) 7
RGB: (180,180,108) 8
RGB: (200,200,110) 9
*/