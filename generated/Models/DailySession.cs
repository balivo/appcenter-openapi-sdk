// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DailySession
    {
        /// <summary>
        /// Initializes a new instance of the DailySession class.
        /// </summary>
        public DailySession()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DailySession class.
        /// </summary>
        /// <param name="datetime">the ISO 8601 datetime</param>
        public DailySession(string datetime = default(string), long? count = default(long?))
        {
            Datetime = datetime;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ISO 8601 datetime
        /// </summary>
        [JsonProperty(PropertyName = "datetime")]
        public string Datetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

    }
}
