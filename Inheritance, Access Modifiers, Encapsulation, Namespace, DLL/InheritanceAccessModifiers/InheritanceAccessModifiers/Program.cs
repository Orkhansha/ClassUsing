using InheritanceAccessModifiers.Models;
using System;
using System.Reflection;
using InheritanceAccessModifiers.Data;
using Domain.Models;

namespace InheritanceAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(55);
            //person.name = "Orxan";






            //typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "Akbarov");

            //var personSurname = typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            //Console.WriteLine(personSurname); 

            //Car car = new Car();
            //car.HorsePower = 120;
            //Console.WriteLine(car.HorsePower);

            //Animal animal = new Animal();

            //Context context = new Context();

            Book book = new Book();

        }
    }
}
