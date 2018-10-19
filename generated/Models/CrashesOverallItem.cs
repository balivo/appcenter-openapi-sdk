// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CrashesOverallItem
    {
        /// <summary>
        /// Initializes a new instance of the CrashesOverallItem class.
        /// </summary>
        public CrashesOverallItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrashesOverallItem class.
        /// </summary>
        public CrashesOverallItem(string crashGroupId = default(string), string appVersion = default(string), CrashOverall overall = default(CrashOverall))
        {
            CrashGroupId = crashGroupId;
            AppVersion = appVersion;
            Overall = overall;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_group_id")]
        public string CrashGroupId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overall")]
        public CrashOverall Overall { get; set; }

    }
}