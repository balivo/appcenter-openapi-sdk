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
    /// Set or remove custom properties.
    /// </summary>
    [Newtonsoft.Json.JsonObject("custom_properties")]
    public partial class LogFlowCustomPropertyLog : LogFlowLog
    {
        /// <summary>
        /// Initializes a new instance of the LogFlowCustomPropertyLog class.
        /// </summary>
        public LogFlowCustomPropertyLog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogFlowCustomPropertyLog class.
        /// </summary>
        /// <param name="timestamp">Log creation timestamp.
        /// </param>
        /// <param name="installId">Install ID.
        /// </param>
        /// <param name="properties">Custom property changes.</param>
        public LogFlowCustomPropertyLog(System.DateTime timestamp, System.Guid installId, LogFlowDevice device, IList<LogFlowCustomProperty> properties = default(IList<LogFlowCustomProperty>))
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
        /// Gets or sets custom property changes.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<LogFlowCustomProperty> Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Properties != null)
            {
                if (Properties.Count > 60)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "Properties", 60);
                }
                if (Properties.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Properties", 1);
                }
                foreach (var element in Properties)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
