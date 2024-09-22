using OOP;

var square = new Rectangle(21, 5) { Width = 20, Height = 4 };
Console.WriteLine(square.GetArea());

var fromColor = new Color() { Blue = 100, Green = 100, Red = 100 };
var toColor = new Color() { Blue = 110, Green = 200, Red = 200 };
ColorsTask.GetColorShades(fromColor, toColor, 10);

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