using Services.People.Domains.Interfaces;
using Services.People.Models;

namespace Services.People.Domains
{
    public class PeopleDomain : IPeopleDomain
    {
        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Create(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Read(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Read()
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
