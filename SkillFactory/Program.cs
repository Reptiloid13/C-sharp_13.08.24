using SkillFactory;
using SkillFactory.Tasks;

namespace SkillFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user1 = ClassTasks.GetUser(1, "A");
            var user2 = ClassTasks.GetUser(2, "B");

            user1.PrintUser();
            
            var user3 = user1;
            user3.Name = "C";
            
            user1.PrintUser();
            user3.PrintUser();
            // user2.PrintUser();
            //
            // Console.WriteLine(user1.Name);
            //
            // var auto = new Auto();
            // auto.Start();
            // Console.WriteLine(int.MaxValue);
            //
            // int x = 1;
            // int y = x;
        }
    }
}