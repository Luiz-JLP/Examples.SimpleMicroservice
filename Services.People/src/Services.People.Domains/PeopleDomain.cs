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
            if (String.IsNullOrEmpty(person.FirstName))
                throw new ArgumentException("O Campo First Name é Obrigatório.");

            if (String.IsNullOrEmpty(person.LastName))
                throw new ArgumentException("O Campo Last Name é Obrigatório.");

            person.Id = Guid.NewGuid().ToString();
            person.CreationDate = DateTime.Now;
            person.LastModified = DateTime.Now;

            return _context.Create(person);
        }

        public bool Delete(Person person)
        {
            return _context.Delete(person);
        }

        public Person Read(string id)
        {
            if (String.IsNullOrEmpty(id)) 
                throw new ArgumentException("O Parâmetro ID é obrigatório.");

            var person = _context.Read(id);

            if (String.IsNullOrEmpty(person.Id))
                throw new ArgumentOutOfRangeException("id", "Nenhum Registro encontrado para o ID passado.");

            return person;
        }

        public IEnumerable<Person> Read()
        {
            return _context.Read();
        }

        public Person Update(Person person)
        {
            if (String.IsNullOrEmpty(person.FirstName))
                throw new ArgumentException("O Campo First Name é Obrigatório.");

            if (String.IsNullOrEmpty(person.LastName))
                throw new ArgumentException("O Campo Last Name é Obrigatório.");

            person.LastModified = DateTime.Now;

            return _context.Update(person);
        }
    }
}
