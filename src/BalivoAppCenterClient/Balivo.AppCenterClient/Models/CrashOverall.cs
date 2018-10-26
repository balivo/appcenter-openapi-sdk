// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CrashOverall
    {
        /// <summary>
        /// Initializes a new instance of the CrashOverall class.
        /// </summary>
        public CrashOverall()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrashOverall class.
        /// </summary>
        public CrashOverall(long? crashCount = default(long?), long? deviceCount = default(long?))
        {
            CrashCount = crashCount;
            DeviceCount = deviceCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_count")]
        public long? CrashCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_count")]
        public long? DeviceCount { get; set; }

    }
}