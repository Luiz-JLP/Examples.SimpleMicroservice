namespace Services.People.Models.Base
{
    public abstract class Model
    {
        /// <summary>
        /// ID of Entity
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Creation Date of Entity
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date of Last Update
        /// </summary>
        public DateTime LastModified { get; set; }
    }
}
