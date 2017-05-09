using System;

namespace Properties
{
    public class Person
    {
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var TimeSpan = DateTime.Today - Birthdate;
                var years = TimeSpan.Days / 365;

                return years;
            }

        }
    }
}