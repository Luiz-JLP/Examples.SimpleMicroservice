using Services.People.Domains;
using Services.People.UnitTests.Fixtures;
using Services.People.UnitTests.Mocks;

namespace Services.People.UnitTests
{
    public class PeopleTests
    {
        private readonly PeopleContextMock _mock;

        public PeopleTests()
        {
            _mock = new PeopleContextMock();
        }

        [Fact]
        public void Create_WhenFirstNameIsEmpty_ShouldThrowsException()
        {
            _mock.SetupForCreate();
            var entity = new PersonFixture().BasicPerson();
            var service = new PeopleDomain(_mock.Object);

            entity.FirstName = string.Empty;

            Assert.Throws<ArgumentException>(() => service.Create(entity));
        }

        [Fact]
        public void Create_WhenLastNameIsEmpty_ShouldThrowsException()
        {
            _mock.SetupForCreate();
            var entity = new PersonFixture().BasicPerson();
            var service = new PeopleDomain(_mock.Object);

            entity.LastName = string.Empty;

            Assert.Throws<ArgumentException>(() => service.Create(entity));
        }

        [Fact]
        public void Create_WhenEntityIsCorrect_ShouldIncludeEntity()
        {
            _mock.SetupForCreate();
            var entity = new PersonFixture().BasicPerson();
            var service = new PeopleDomain(_mock.Object);

            var newPerson = service.Create(entity);

            Assert.False(String.IsNullOrEmpty(newPerson.Id));
        }

        [Fact]
        public void Read_WhenIdIsEmpty_ShouldThrowsException()
        {
            _mock.SetupForReadOne();
            var service = new PeopleDomain(_mock.Object);

            Assert.Throws<ArgumentException>(() => service.Read(string.Empty));
        }

        [Fact]
        public void Read_WhenIdIsPassed_ShouldReturnEntity()
        {
            _mock.SetupForReadOne();
            var service = new PeopleDomain(_mock.Object);

            var entity = service.Read(Guid.NewGuid().ToString());

            Assert.NotNull(entity);
            Assert.False(String.IsNullOrEmpty(entity.Id));
        }

        [Fact]
        public void Read_WhenReadAll_ShouldReturnList()
        {
            _mock.SetupForReadAll();
            var service = new PeopleDomain(_mock.Object);

            var entities = service.Read();

            Assert.NotNull(entities);
            Assert.True(entities.Any());

            var entity = entities.First();

            Assert.NotNull(entity);
            Assert.False(String.IsNullOrEmpty(entity.Id));
        }

        [Fact]
        public void Update_WhenFirstNameIsEmpty_ShouldThrowsException()
        {
            _mock.SetupForUpdate();
            var entity = new PersonFixture().BasicPerson();
            var service = new PeopleDomain(_mock.Object);

            entity.FirstName = string.Empty;

            Assert.Throws<ArgumentException>(() => service.Update(entity));
        }

        [Fact]
        public void Update_WhenLastNameIsEmpty_ShouldThrowsException()
        {
            _mock.SetupForUpdate();
            var entity = new PersonFixture().BasicPerson();
            var service = new PeopleDomain(_mock.Object);

            entity.LastName = string.Empty;

            Assert.Throws<ArgumentException>(() => service.Update(entity));
        }

        [Fact]
        public void Update_WhenEntityIsCorrect_ShouldUpdateEntity()
        {
            _mock.SetupForUpdate();
            var entity = new PersonFixture().BasicPerson();
            var service = new PeopleDomain(_mock.Object);

            var newPerson = service.Update(entity);

            Assert.False(String.IsNullOrEmpty(newPerson.Id));
        }

        [Fact]
        public void Delete_WhenCorrect_ShouldReturnEntity()
        {
            _mock.SetupForDelete();
            var entity = new PersonFixture().CompletePerson();
            var service = new PeopleDomain(_mock.Object);

            var result = service.Delete(entity);

            Assert.True(result);
        }
    }
}
