using Services.People.Models;

namespace Services.People.Infrastructure.Interfaces
{
    /// <summary>
    /// Interface People Data Access
    /// </summary>
    public interface IPeopleContext
    {
        /// <summary>
        /// Create a Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        Person Create(Person person);

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
