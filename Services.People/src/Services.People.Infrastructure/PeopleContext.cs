using Microsoft.EntityFrameworkCore;
using Services.People.Infrastructure.Context;
using Services.People.Infrastructure.Interfaces;
using Services.People.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services.People.Infrastructure
{
    public class PeopleContext : IPeopleContext
    {
        private readonly AppDbContext _context;

        public PeopleContext(AppDbContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
            return person;
        }

        public bool Delete(Person person)
        {
            _context.People.Remove(person);
            _context.SaveChanges(true);
            return true;
        }

        public Person Read(string id)
        {
            return _context.People.Where(person => person.Id == id).FirstOrDefault() ?? new Person();
        }

        public IEnumerable<Person> Read()
        {
            return _context.People;
        }

        public Person Update(Person person)
        {
            var entity = _context.People.Update(person);
            _context.SaveChanges();
            return entity.Entity;
        }
    }
}
