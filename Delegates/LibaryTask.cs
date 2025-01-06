namespace Delegates
{
    public class LibaryTask
    {
        public static void Start2()
        {
            var libary = new Libary() { Book = new Book() { Name = "Книга о программировании " } };
            var kate = new Person() { Name = "Kate" };
            var anna = new Person() { Name = "Anna" };

            libary.GiveBook(kate);


            // libary.OnBookReturned = ... 
            //OnBookReturned нужно отправлять SMS Анне о том, что книгу вернули 
            // и она может ее взять 
            libary.OnBookReturned += () =>
            {
                var sms = new SMS();
                sms.Send(anna, $"'{libary.Book.Name}' вернулась и доступна для бронирования");
            };

            libary.ReturnBook(kate);
        }
    }

    public class Person
    {
        public string Name;
    }

    public delegate void OnBookReturned();

    public class Libary
    {
        public Book Book;
        public Person CurrentHolder;
        public OnBookReturned OnBookReturned;

        public void GiveBook(Person person)
        {
            if (CurrentHolder != null)
            {
                // Todo: Exception
                Console.WriteLine($"Книга '{Book.Name}', находится у {CurrentHolder.Name}");
            }
            else
            {
                CurrentHolder = person;
                Console.WriteLine($"{person.Name} уже держит '{Book.Name}' ");
            }
        }

        public void ReturnBook(Person person)
        {
            if (CurrentHolder != null && CurrentHolder.Name == person.Name)
            {
                Console.WriteLine($"Книгу '{Book.Name}',  вернул - {person.Name} ");
                CurrentHolder = null;
                OnBookReturned();
            }
        }
    }

    public class Book
    {
        public string Name;
    }

    public class SMS
    {
        public void Send(Person person, string message)
        {
            Console.WriteLine($"SMS для {person.Name}: " + message);
        }
    }
}