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
    /// Device Set update information
    /// </summary>
    /// <remarks>
    /// The name of the device set and the list of device IDs
    /// </remarks>
    public partial class DeviceSetUpdate
    {
        /// <summary>
        /// Initializes a new instance of the DeviceSetUpdate class.
        /// </summary>
        public DeviceSetUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceSetUpdate class.
        /// </summary>
        /// <param name="devices">List of device IDs</param>
        /// <param name="name">The name of the device set</param>
        public DeviceSetUpdate(IList<string> devices, string name)
        {
            Devices = devices;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of device IDs
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public IList<string> Devices { get; set; }

        /// <summary>
        /// Gets or sets the name of the device set
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Devices == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Devices");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
