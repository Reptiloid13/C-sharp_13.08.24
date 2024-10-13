using SkillFactory;
using System.Security.Cryptography.X509Certificates;


namespace SkillFactory
{
    class Program
    {

        static void Main()
        {
            //Player player  =new Player();
            //string player1Name= player.Name;
            //player.Name = "Paladin";
            //string player2Name= player.Name;

            Player player1 = new Player("Paladin");
            Player player2 = new Player("Ork");
            Player damage = new Player(player); // Не получается вызвать метод Damage

            while (true)
            {
                player1.Damage(player2);
                Console.WriteLine($"{player1.Name} Здоровья осталось  {player1.HealthPoints} Урона: {player2.Name}");
                if (player2.HealthPoints <= 0)
                {
                    Console.WriteLine($" победил: {player1.Name}");
                    break;
                }

                player2.Damage(player1);
                Console.WriteLine($"{player2.Name} Здоровья Осталось   {player2.HealthPoints} Урона: {player1.Name}");
                if (player1.HealthPoints <= 0)
                {
                    Console.WriteLine($"Победил {player2.Name}");
                    break;
                }
            }
            //  Создать класс Player, Должны быть поля
            // name и HealtPoints = 100.
            //Каждый игрок может Damage(int value)
            // другого игрока.Каждый игрок по очереди
            //     наносит урон (случайное число от 0 до 10). 
            //      Вывести победителя
        }

        class Player
        {
            public string Name;
            public int HealthPoints = 100;

            public Player(string name) // Можно только так? 
            {
                Name = name;
            }
            public void Damage(Player player)
            {
                int damage = new Random().Next(0, 10);
                player.HealthPoints -= damage;
                Console.WriteLine(damage);

            }
        }
    }
}