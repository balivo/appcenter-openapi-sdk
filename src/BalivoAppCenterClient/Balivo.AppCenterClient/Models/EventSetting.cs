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
    /// Event Setting
    /// </summary>
    public partial class EventSetting
    {
        /// <summary>
        /// Initializes a new instance of the EventSetting class.
        /// </summary>
        public EventSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventSetting class.
        /// </summary>
        /// <param name="value">Frequency of event. Possible values include:
        /// 'Disabled', 'Individual', 'Daily', 'DailyAndIndividual',
        /// 'Default'</param>
        /// <param name="defaultValue">Default frequency of event. Possible
        /// values include: 'Disabled', 'Individual', 'Daily',
        /// 'DailyAndIndividual'</param>
        public EventSetting(string value, string defaultValue = default(string))
        {
            Value = value;
            DefaultValue = defaultValue;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for EventSetting class.
        /// </summary>
        static EventSetting()
        {
            EventType = "crash_newCrashGroupCreated";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets frequency of event. Possible values include:
        /// 'Disabled', 'Individual', 'Daily', 'DailyAndIndividual', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets default frequency of event. Possible values include:
        /// 'Disabled', 'Individual', 'Daily', 'DailyAndIndividual'
        /// </summary>
        [JsonProperty(PropertyName = "default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Event Name
        /// </summary>
        [JsonProperty(PropertyName = "event_type")]
        public static string EventType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
