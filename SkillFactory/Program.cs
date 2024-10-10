using SkillFactory;


namespace SkillFactory
{
    class Program
    {
        //  Создать класс Player, Должны быть поля
        // name и HealtPoints = 100.
        //Каждый игрок может Damage(int value)
        // другого игрока.Каждый игрок по очереди
        //     наносит урон (случайное число от 0 до 10). 
        //      Вывести победителя
        class Players
        {
            public string player1 = "Paladin";
            public string player2 = "Ork";
            public int HealthPoints = 100;

            public void Print()
            {
                Console.WriteLine($"Name {player1}, {player2}");
            }
        }
    }
}