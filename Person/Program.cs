using System;

namespace Person
{
    public class Person
    {
        public string Firstname;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Firstname} {LastName}");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.Firstname = "John";
            newPerson.LastName = "Duka";

            newPerson.Introduce();

        }
    }
}
