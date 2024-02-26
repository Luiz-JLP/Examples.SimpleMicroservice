using Services.People.Infrastructure.Context;
using Services.People.Infrastructure.Interfaces;
using Services.People.Models;

namespace Services.People.Infrastructure
{
    /// <summary>
    /// Implementation of People Context
    /// </summary>
    public class PeopleContext : IPeopleContext
    {
        private readonly AppDbContext _context;

        public PeopleContext(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Person Create(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
            return person;
        }

        /// <summary>
        /// Delete a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool Delete(Person person)
        {
            _context.People.Remove(person);
            _context.SaveChanges(true);
            return true;
        }

        /// <summary>
        /// Read a Person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person Read(string id)
        {
            return _context.People.Where(person => person.Id == id).FirstOrDefault() ?? new Person();
        }

        /// <summary>
        /// Read All People
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Person> Read()
        {
            return _context.People;
        }

        /// <summary>
        /// Update a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Person Update(Person person)
        {
            var entity = _context.People.Update(person);
            _context.SaveChanges();
            return entity.Entity;
        }
    }
}
