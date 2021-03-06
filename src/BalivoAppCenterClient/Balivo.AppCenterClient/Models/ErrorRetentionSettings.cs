// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorRetentionSettings
    {
        /// <summary>
        /// Initializes a new instance of the ErrorRetentionSettings class.
        /// </summary>
        public ErrorRetentionSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorRetentionSettings class.
        /// </summary>
        public ErrorRetentionSettings(int retentionInDays)
        {
            RetentionInDays = retentionInDays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "retention_in_days")]
        public int RetentionInDays { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
