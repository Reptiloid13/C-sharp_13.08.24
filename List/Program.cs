using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace List
{
    class Person
    {
        //Сохранение списка объектов: Создайте
        //класс Person, и создайте список объектов этого класса.
        //Заполните список, а затем выведите данные всех людей
        //на консоль.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        class Program
        {


            static void Main(string[] args)
            {
                List<Person> people = new List<Person>();

                people.Add(new Person() { FirstName = "John", LastName = "Ivanov", Age = 31 });
                people.Add(new Person() { FirstName = "Enrique", LastName = "Fedorchuk", Age = 21 });
                people.Add(new Person() { FirstName = "Leonardo", LastName = "DaVcitor", Age = 49 });

                Console.WriteLine("List of peole: ");

                foreach (Person person in people)
                {
                    Console.WriteLine($"{person.FirstName}, {person.LastName}, {person.Age}");
                }
            }

        }
    }
}
