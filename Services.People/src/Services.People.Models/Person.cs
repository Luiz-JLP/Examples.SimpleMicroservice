using Services.People.Models.Base;

namespace Services.People.Models
{
    public class Person : Model
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime Birthday { get; set; }

        public Gender Gender { get; set; }
    }
}
