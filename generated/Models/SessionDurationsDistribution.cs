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

    public partial class SessionDurationsDistribution
    {
        /// <summary>
        /// Initializes a new instance of the SessionDurationsDistribution
        /// class.
        /// </summary>
        public SessionDurationsDistribution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SessionDurationsDistribution
        /// class.
        /// </summary>
        /// <param name="distribution">the count of sessions in these
        /// buckets</param>
        /// <param name="previousAverageDuration">the previous average session
        /// duration for previous time range</param>
        /// <param name="averageDuration">the average session duration for
        /// current time range</param>
        public SessionDurationsDistribution(IList<SessionDurationsDistributionDistributionItem> distribution = default(IList<SessionDurationsDistributionDistributionItem>), string previousAverageDuration = default(string), string averageDuration = default(string))
        {
            Distribution = distribution;
            PreviousAverageDuration = previousAverageDuration;
            AverageDuration = averageDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the count of sessions in these buckets
        /// </summary>
        [JsonProperty(PropertyName = "distribution")]
        public IList<SessionDurationsDistributionDistributionItem> Distribution { get; set; }

        /// <summary>
        /// Gets or sets the previous average session duration for previous
        /// time range
        /// </summary>
        [JsonProperty(PropertyName = "previous_average_duration")]
        public string PreviousAverageDuration { get; set; }

        /// <summary>
        /// Gets or sets the average session duration for current time range
        /// </summary>
        [JsonProperty(PropertyName = "average_duration")]
        public string AverageDuration { get; set; }

    }
}
