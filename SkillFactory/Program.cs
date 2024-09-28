using SkillFactory;


namespace SkillFactory
{

    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;


    }

    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.firstName = "Sarkis";
            student.lastName = "Petrosyants";
            student.middleName = "Semenovich";
            student.age = 30;
            student.group = "CDEV-47";

        }

        static void Print(studetn student)
        {

        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }











}