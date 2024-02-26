using Moq;
using Services.People.Infrastructure;
using Services.People.Infrastructure.Interfaces;
using Services.People.Models;
using Services.People.UnitTests.Fixtures;

namespace Services.People.UnitTests.Mocks
{
    public class PeopleContextMock : Mock<IPeopleContext>
    {
        public void SetupForCreate()
        {
            this.Setup(x => x.Create(It.IsAny<Person>()))
                .Returns(new PersonFixture().CompletePerson());
        }

        public void SetupForReadOne()
        {
            this.Setup(x => x.Read(It.IsAny<string>()))
                .Returns(new PersonFixture().CompletePerson());
        }

        public void SetupForReadAll()
        {
            this.Setup(x => x.Read())
                .Returns(new List<Person>() { new PersonFixture().CompletePerson() });
        }

        public void SetupForUpdate()
        {
            this.Setup(x => x.Update(It.IsAny<Person>()))
                .Returns(new PersonFixture().CompletePerson());
        }

        public void SetupForDelete()
        {
            this.Setup(x => x.Delete(It.IsAny<Person>()))
                .Returns(true);
        }
    }
}
