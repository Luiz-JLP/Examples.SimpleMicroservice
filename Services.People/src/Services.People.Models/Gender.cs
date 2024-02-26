using System.Text.Json.Serialization;

namespace Services.People.Models
{
    public enum Gender
    {
        /// <summary>
        /// Male
        /// </summary>
        [JsonPropertyName("Male")]
        Male,

        /// <summary>
        /// Female
        /// </summary>
        [JsonPropertyName("Female")]
        Female,

        /// <summary>
        /// Cisgender
        /// </summary>
        [JsonPropertyName("Cisgender")]
        Cisgender,

        /// <summary>
        /// Transgender
        /// </summary>
        [JsonPropertyName("Transgender")]
        Transgender,

        /// <summary>
        /// Intersex
        /// </summary>
        [JsonPropertyName("Intersex")]
        Intersex,

        /// <summary>
        /// Non Binary
        /// </summary>
        [JsonPropertyName("NonBinary")]
        NonBinary
    }
}
