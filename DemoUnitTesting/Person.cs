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

                return string.Empty;
            }
        }

        public int Age
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
