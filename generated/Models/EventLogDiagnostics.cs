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
    /// Event log.
    /// </summary>
    [Newtonsoft.Json.JsonObject("event")]
    public partial class EventLogDiagnostics : LogWithPropertiesDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the EventLogDiagnostics class.
        /// </summary>
        public EventLogDiagnostics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventLogDiagnostics class.
        /// </summary>
        /// <param name="timestamp">Log creation timestamp.
        /// </param>
        /// <param name="installId">Install ID.
        /// </param>
        /// <param name="sessionId">Session ID.
        /// </param>
        /// <param name="id">Unique identifier for this event.
        /// </param>
        /// <param name="name">Name of the event.
        /// </param>
        /// <param name="properties">Additional key/value pair parameters.
        /// </param>
        public EventLogDiagnostics(System.DateTime timestamp, System.Guid installId, DeviceDiagnostics device, System.Guid sessionId, System.Guid id, string name, IDictionary<string, string> properties = default(IDictionary<string, string>))
            : base(timestamp, installId, device, properties)
        {
            SessionId = sessionId;
            Id = id;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets session ID.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        public System.Guid SessionId { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for this event.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets name of the event.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}