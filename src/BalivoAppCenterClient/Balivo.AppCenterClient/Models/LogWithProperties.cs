// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LogWithProperties : Log
    {
        /// <summary>
        /// Initializes a new instance of the LogWithProperties class.
        /// </summary>
        public LogWithProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogWithProperties class.
        /// </summary>
        /// <param name="timestamp">Log creation timestamp.
        /// </param>
        /// <param name="installId">Install ID.
        /// </param>
        /// <param name="properties">Additional key/value pair parameters.
        /// </param>
        public LogWithProperties(System.DateTime timestamp, System.Guid installId, Device device, IDictionary<string, string> properties = default(IDictionary<string, string>))
            : base(timestamp, installId, device)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets additional key/value pair parameters.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
