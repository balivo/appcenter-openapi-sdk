// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object containing a UUID for an architecture for an iOS app.
    /// </summary>
    public partial class ArchIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the ArchIdentifier class.
        /// </summary>
        public ArchIdentifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArchIdentifier class.
        /// </summary>
        /// <param name="architecture">The architecture that the UUID belongs
        /// to, i.e. armv7 or arm64.</param>
        /// <param name="uuid">The unique identifier.</param>
        public ArchIdentifier(string architecture, System.Guid uuid)
        {
            Architecture = architecture;
            Uuid = uuid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the architecture that the UUID belongs to, i.e. armv7
        /// or arm64.
        /// </summary>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public System.Guid Uuid { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Architecture == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Architecture");
            }
        }
    }
}