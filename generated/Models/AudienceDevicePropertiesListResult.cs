// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of device properties.
    /// </summary>
    public partial class AudienceDevicePropertiesListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AudienceDevicePropertiesListResult class.
        /// </summary>
        public AudienceDevicePropertiesListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AudienceDevicePropertiesListResult class.
        /// </summary>
        /// <param name="values">List of device properties.</param>
        public AudienceDevicePropertiesListResult(IDictionary<string, DevicePropertyType?> values)
        {
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of device properties.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IDictionary<string, DevicePropertyType?> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Values == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Values");
            }
        }
    }
}
