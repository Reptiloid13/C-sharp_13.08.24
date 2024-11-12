class Program
{
    public static void Main(string[] args)
    {
        var simulator = new HeadsAndTailsSimulator() { NumberOfThrows = 1_000_000 };
        simulator.Simulate();
        simulator.PrintResult();
    }
    // Подбрасывание монеты: Напишите программу, которая симулирует подбрасывание монеты 1млн раз и считает,
    // сколько раз выпала орел, а сколько решка.}
}

class HeadsAndTailsSimulator
{
    public required int NumberOfThrows { get; set; }
    public int Heads { get; private set; }
    public int Tails { get; private set; }

    public void Simulate()
    {
        for (int i = 0; i < 1_000_000; i++)
        {
            if (GetRandomNumber() == 0)
                Heads++;
            else
                Tails++;
        }
    }

    public void PrintResult()
    {
        Console.WriteLine($"Орел: {Heads}, Решка: {Tails}, Всего: {NumberOfThrows}");
        Console.WriteLine($"Процент орла: {Heads * 100.0 / NumberOfThrows}%");
        Console.WriteLine($"Процент решки: {Tails * 100.0 / NumberOfThrows}%");
    }


    private static int GetRandomNumber()
    {
        var random = new Random();
        return random.Next(2);
    }
}