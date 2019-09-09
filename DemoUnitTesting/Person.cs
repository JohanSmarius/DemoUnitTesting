using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUnitTesting
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Middlename { get; set; }

        public DateTime BirthDate { get; set; }

        public string Fullname
        {
            get
            {
                if (string.IsNullOrEmpty(Middlename))
                {
                    return $"{FirstName} {LastName}";
                }
                return $"{FirstName} {Middlename} {LastName}";
            }
        }

        public int Age
        {
            get { return DateTime.Today.Year - BirthDate.Year; }
        }
    }
}
