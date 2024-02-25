using Services.People.Models;

namespace Services.People.Domains.Interfaces
{
    public interface IPeopleDomain
    {
        /// <summary>
        /// Create a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        Person Create(Person person);

        /// <summary>
        /// Create Many People
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        IEnumerable<Person> Create(IEnumerable<Person> people);

        /// <summary>
        /// Read a Person by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Person Read(string id);

        /// <summary>
        /// Read All People
        /// </summary>
        /// <returns></returns>
        IEnumerable<Person> Read();

        /// <summary>
        /// Update a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        Person Update(Person person);

        /// <summary>
        /// Delete a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        bool Delete(Person person);
    }
}
