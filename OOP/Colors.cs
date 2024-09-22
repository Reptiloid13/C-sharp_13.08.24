namespace OOP;

class ColorsTask
{
    public static Color[] GetColorShades(Color fromColor, Color toColor, int shadesCount)
    {
        Color[] shades = new Color[shadesCount];

        for (int i = 0; i < shadesCount; i++)
        {
        }

        return shades;
    }
}

struct Color
{
    public int Red;
    public int Green;
    public int Blue;

    public override string ToString()
    {
        return $"Red: {Red}, Green: {Green}, Blue: {Blue}";
    }
}