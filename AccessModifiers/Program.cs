using System;

namespace AccessModifiers
{
    internal class Program
    {
        public class Person
        {
            private DateTime _birthdate;

            public void SetBirthdate(DateTime birthdate)
            {
                this._birthdate = birthdate;
            }

            public DateTime GetBirthdate()
            {
                return _birthdate;
            }
        }
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
            
        }
    }
}
