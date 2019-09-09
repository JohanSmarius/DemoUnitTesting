using System;
using DemoUnitTesting;
using Xunit;

namespace DemoUnitTests
{
    public class PersonTests
    {
        [Fact]
        public void FullName_Given_No_Middle_Name_Should_Return_First_And_LastName()
        {
            var sut = new Person()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var fullName = sut.Fullname;

            Assert.Equal("John Doe", fullName);
        }

        //TODO: Add unit test for full name with MiddleName


        //TODO: Add code and unit test for age calculation. Just take the year part into account.
        // The formula does not have to be full proof.
    }
}
