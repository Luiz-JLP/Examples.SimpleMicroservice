using Services.People.Domains.Interfaces;
using Services.People.Infrastructure.Interfaces;
using Services.People.Models;

namespace Services.People.Domains
{
    public class PeopleDomain : IPeopleDomain
    {
        private readonly IPeopleContext _context;

        public PeopleDomain(IPeopleContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            return _context.Create(person);
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
