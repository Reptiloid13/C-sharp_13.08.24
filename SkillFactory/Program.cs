//using SkillFactory;


//namespace SkillFactory
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var N = ReadPositiveInt("Enter  N: ");
//            var nums = ReadIntegers(N);
//            var reversed = Reverse(nums);
//            Console.WriteLine(string.Join(", ", reversed));
//        }

//        static int[] ReadIntegers(int n)
//        {
//            int[] numbers = new int[n];
//            var items = Console.ReadLine().Split(' ');
//            var nums = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                nums[i] = Convert.ToInt32(items[i]);
//            }

//            return nums;
//        }

//        static int ReadPositiveInt(string message)
//        {
//            int value;
//            do
//            {
//                Console.WriteLine(message);
//                //ошибка ниже
//            } while (int.TryParse(message, out value) == false);

//            return value;
//        }

//        static int[] Reverse(int[] nums)
//        {
//            var n = nums.Length;
//            for (int i = 0; i < nums.Length / 2; i++)
//            {
//                (nums[i], nums[n - i - 1]) = (nums[n - i - 1], nums[i]);
//            }

//            return nums;
//        }
//    }
//}