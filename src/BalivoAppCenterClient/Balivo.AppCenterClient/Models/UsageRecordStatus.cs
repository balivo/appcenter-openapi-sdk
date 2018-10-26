// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Status of the usage record creation
    /// </summary>
    public partial class UsageRecordStatus
    {
        /// <summary>
        /// Initializes a new instance of the UsageRecordStatus class.
        /// </summary>
        public UsageRecordStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageRecordStatus class.
        /// </summary>
        /// <param name="expectedLatestBuildExists">Is the age of the most
        /// recent Build service usage record within expected limits</param>
        /// <param name="expectedLatestPushExists">Is the age of the most
        /// recent Push service usage record within expected limits</param>
        /// <param name="expectedLatestTestExists">Is the age of the most
        /// recent Test service usage record within expected limits</param>
        /// <param name="latestBuildUsageRecordTime">The time of the most
        /// recent Build service usage record</param>
        /// <param name="latestPushUsageRecordTime">The time of the most recent
        /// Push service usage record</param>
        /// <param name="latestTestUsageRecordTime">The time of the most recent
        /// Test service usage record</param>
        public UsageRecordStatus(bool? expectedLatestBuildExists = default(bool?), bool? expectedLatestPushExists = default(bool?), bool? expectedLatestTestExists = default(bool?), string latestBuildUsageRecordTime = default(string), string latestPushUsageRecordTime = default(string), string latestTestUsageRecordTime = default(string))
        {
            ExpectedLatestBuildExists = expectedLatestBuildExists;
            ExpectedLatestPushExists = expectedLatestPushExists;
            ExpectedLatestTestExists = expectedLatestTestExists;
            LatestBuildUsageRecordTime = latestBuildUsageRecordTime;
            LatestPushUsageRecordTime = latestPushUsageRecordTime;
            LatestTestUsageRecordTime = latestTestUsageRecordTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets is the age of the most recent Build service usage
        /// record within expected limits
        /// </summary>
        [JsonProperty(PropertyName = "expectedLatestBuildExists")]
        public bool? ExpectedLatestBuildExists { get; set; }

        /// <summary>
        /// Gets or sets is the age of the most recent Push service usage
        /// record within expected limits
        /// </summary>
        [JsonProperty(PropertyName = "expectedLatestPushExists")]
        public bool? ExpectedLatestPushExists { get; set; }

        /// <summary>
        /// Gets or sets is the age of the most recent Test service usage
        /// record within expected limits
        /// </summary>
        [JsonProperty(PropertyName = "expectedLatestTestExists")]
        public bool? ExpectedLatestTestExists { get; set; }

        /// <summary>
        /// Gets or sets the time of the most recent Build service usage record
        /// </summary>
        [JsonProperty(PropertyName = "latestBuildUsageRecordTime")]
        public string LatestBuildUsageRecordTime { get; set; }

        /// <summary>
        /// Gets or sets the time of the most recent Push service usage record
        /// </summary>
        [JsonProperty(PropertyName = "latestPushUsageRecordTime")]
        public string LatestPushUsageRecordTime { get; set; }

        /// <summary>
        /// Gets or sets the time of the most recent Test service usage record
        /// </summary>
        [JsonProperty(PropertyName = "latestTestUsageRecordTime")]
        public string LatestTestUsageRecordTime { get; set; }

    }
}