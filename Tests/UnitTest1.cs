using SkillFactory.Tasks;
using Tasks;

namespace Tests;

public class ProgramTests
{
    [Fact]
    public void TestSum()
    {
        Assert.Equal(SumTask.Sum(5, 3), 8);
        Assert.Equal(SumTask.Sum(0, 0), 0);
        Assert.Equal(SumTask.Sum(1, -1), 0);
        Assert.Equal(SumTask.Sum(-1, -1), -2);
        Assert.Equal(SumTask.Sum(-100, -1), -101);
    }

    [Fact]
    public void TestMaxInArray()
    {
        Assert.Equal(MaxInArray.GetMaxInArray(new[] { 1, 2, 3, 6, 1, 2, 3 }), 6);
    }
}