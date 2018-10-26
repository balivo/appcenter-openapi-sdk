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

    public partial class EventCount
    {
        /// <summary>
        /// Initializes a new instance of the EventCount class.
        /// </summary>
        public EventCount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventCount class.
        /// </summary>
        public EventCount(long? totalCount = default(long?), long? previousTotalCount = default(long?), IList<DateTimeCounts> count = default(IList<DateTimeCounts>))
        {
            TotalCount = totalCount;
            PreviousTotalCount = previousTotalCount;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public long? TotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previous_total_count")]
        public long? PreviousTotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public IList<DateTimeCounts> Count { get; set; }

    }
}
