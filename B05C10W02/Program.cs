using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05C10W02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<string> hobbies1 = new List<string> { "gardening" };
            Person person1 = new Person("a", "m@gmail.com", "23th 1999", "male", hobbies1, "dhaka");
            List<string> hobbies2 = new List<string> { "gardening", "swimming" };
            Person person2 = new Person("ab", "mn@gmail.com", "24th 1999", "male", hobbies2, "dhaka");
            List<string> hobbies3 = new List<string> { "gardening", "writing" };
            Person person3 = new Person("abc", "mno@gmail.com", "27th 1999", "male", hobbies3, "dhaka");
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            Console.ReadKey();
        }
    }


class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public List<string> Hobbies { get; set; }
        public string City { get; set; }

        public Person(string name, string email, string birthday, string gender, List<string> hobbies, string city)
        {
            this.Name = name;
            this.Email = email;
            this.Birthday = birthday;
            this.Gender = gender;
            this.Hobbies = hobbies;
            this.City = city;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Birthday: {Birthday}, Gender: {Gender}," +
                $" Hobbies: {string.Join(", ", Hobbies)}, City: {City}";
        }
    }
}
