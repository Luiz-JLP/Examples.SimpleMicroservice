using Services.People.Domains.Interfaces;
using Services.People.Infrastructure.Interfaces;
using Services.People.Models;

namespace Services.People.Domains
{
    /// <summary>
    /// Domain Class of People
    /// </summary>
    public class PeopleDomain : IPeopleDomain
    {
        private readonly IPeopleContext _context;

        public PeopleDomain(IPeopleContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create a New Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Delete a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool Delete(Person person)
        {
            return _context.Delete(person);
        }

        /// <summary>
        /// Read a Person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Person Read(string id)
        {
            if (String.IsNullOrEmpty(id)) 
                throw new ArgumentException("O Parâmetro ID é obrigatório.");

            var person = _context.Read(id);

            if (String.IsNullOrEmpty(person.Id))
                throw new ArgumentOutOfRangeException("id", "Nenhum Registro encontrado para o ID passado.");

            return person;
        }

        /// <summary>
        /// Read All People
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Person> Read()
        {
            return _context.Read();
        }

        /// <summary>
        /// Update a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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
