// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CrashGroupPlace
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroupPlace class.
        /// </summary>
        public CrashGroupPlace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrashGroupPlace class.
        /// </summary>
        /// <param name="placeName">Place name</param>
        /// <param name="crashCount">count of places</param>
        public CrashGroupPlace(string placeName = default(string), long? crashCount = default(long?))
        {
            PlaceName = placeName;
            CrashCount = crashCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets place name
        /// </summary>
        [JsonProperty(PropertyName = "place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// Gets or sets count of places
        /// </summary>
        [JsonProperty(PropertyName = "crash_count")]
        public long? CrashCount { get; set; }

    }
}
