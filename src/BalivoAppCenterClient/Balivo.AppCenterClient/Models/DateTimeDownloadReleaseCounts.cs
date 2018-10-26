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

    public partial class DateTimeDownloadReleaseCounts
    {
        /// <summary>
        /// Initializes a new instance of the DateTimeDownloadReleaseCounts
        /// class.
        /// </summary>
        public DateTimeDownloadReleaseCounts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DateTimeDownloadReleaseCounts
        /// class.
        /// </summary>
        /// <param name="counts">Release Counts per day</param>
        public DateTimeDownloadReleaseCounts(long? total = default(long?), long? unique = default(long?), IList<DateTimeDownloadReleaseCount> counts = default(IList<DateTimeDownloadReleaseCount>))
        {
            Total = total;
            Unique = unique;
            Counts = counts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unique")]
        public long? Unique { get; set; }

        /// <summary>
        /// Gets or sets release Counts per day
        /// </summary>
        [JsonProperty(PropertyName = "counts")]
        public IList<DateTimeDownloadReleaseCount> Counts { get; set; }

    }
}