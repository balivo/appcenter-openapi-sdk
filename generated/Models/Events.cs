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

    public partial class Events
    {
        /// <summary>
        /// Initializes a new instance of the Events class.
        /// </summary>
        public Events()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Events class.
        /// </summary>
        /// <param name="total">the total count of events</param>
        /// <param name="totalDevices">the active device over this
        /// period</param>
        public Events(IList<EventModel> eventsProperty = default(IList<EventModel>), long? total = default(long?), long? totalDevices = default(long?))
        {
            EventsProperty = eventsProperty;
            Total = total;
            TotalDevices = totalDevices;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<EventModel> EventsProperty { get; set; }

        /// <summary>
        /// Gets or sets the total count of events
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// Gets or sets the active device over this period
        /// </summary>
        [JsonProperty(PropertyName = "total_devices")]
        public long? TotalDevices { get; set; }

    }
}
