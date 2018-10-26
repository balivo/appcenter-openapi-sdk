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

    public partial class Status
    {
        /// <summary>
        /// Initializes a new instance of the Status class.
        /// </summary>
        public Status()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Status class.
        /// </summary>
        public Status(string statusProperty)
        {
            StatusProperty = statusProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string StatusProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StatusProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StatusProperty");
            }
        }
    }
}
