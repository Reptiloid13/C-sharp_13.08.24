namespace SkillFactory.Tasks;

public class MaxInArray
{
    public static int GetMaxInArray(int[] array)
    {
        var max = array[0];

        for (var i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }
}