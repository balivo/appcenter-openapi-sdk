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
    /// Generic log.
    /// </summary>
    public partial class LogFlowGenericLog
    {
        /// <summary>
        /// Initializes a new instance of the LogFlowGenericLog class.
        /// </summary>
        public LogFlowGenericLog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogFlowGenericLog class.
        /// </summary>
        /// <param name="type">Log type.
        /// . Possible values include: 'event', 'page', 'start_session',
        /// 'error', 'push_installation', 'start_service',
        /// 'custom_properties'</param>
        /// <param name="timestamp">Log creation timestamp.
        /// </param>
        /// <param name="installId">Install ID.
        /// </param>
        /// <param name="sessionId">Session ID.
        /// </param>
        /// <param name="eventId">Event ID.
        /// </param>
        /// <param name="eventName">Event name.
        /// </param>
        /// <param name="messageId">Message ID.
        /// </param>
        /// <param name="properties">event specific properties.
        /// </param>
        public LogFlowGenericLog(string type, System.DateTime timestamp, System.Guid installId, LogFlowDevice device, System.Guid? sessionId = default(System.Guid?), string eventId = default(string), string eventName = default(string), string messageId = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            Type = type;
            Timestamp = timestamp;
            InstallId = installId;
            SessionId = sessionId;
            EventId = eventId;
            EventName = eventName;
            MessageId = messageId;
            Properties = properties;
            Device = device;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets log type.
        /// . Possible values include: 'event', 'page', 'start_session',
        /// 'error', 'push_installation', 'start_service', 'custom_properties'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets log creation timestamp.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets install ID.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "install_id")]
        public System.Guid InstallId { get; set; }

        /// <summary>
        /// Gets or sets session ID.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        public System.Guid? SessionId { get; set; }

        /// <summary>
        /// Gets or sets event ID.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets event name.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets message ID.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets event specific properties.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public LogFlowDevice Device { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Device == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Device");
            }
            if (Device != null)
            {
                Device.Validate();
            }
        }
    }
}