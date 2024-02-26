using Services.People.Models;

namespace Services.People.UnitTests.Fixtures
{
    public class PersonFixture
    {
        public Person BasicPerson()
        {
            return new Person()
            {
                FirstName = "First Name",
                LastName = "Last Name",
                Birthday = DateTime.Now.AddYears(-20)
            };
        }

        public Person CompletePerson()
        {
            return new Person()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "First Name",
                LastName = "Last Name",
                Birthday = DateTime.Now.AddYears(-20),
                CreationDate = DateTime.Now.AddDays(-1),
                LastModified = DateTime.Now.AddDays(-1)
            };
        }
    }
}
