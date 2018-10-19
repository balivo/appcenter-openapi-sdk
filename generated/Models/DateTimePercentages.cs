// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DateTimePercentages
    {
        /// <summary>
        /// Initializes a new instance of the DateTimePercentages class.
        /// </summary>
        public DateTimePercentages()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DateTimePercentages class.
        /// </summary>
        /// <param name="datetime">the ISO 8601 datetime</param>
        /// <param name="percentage">percentage of the object</param>
        public DateTimePercentages(string datetime = default(string), double? percentage = default(double?))
        {
            Datetime = datetime;
            Percentage = percentage;
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
        /// Gets or sets percentage of the object
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        public double? Percentage { get; set; }

    }
}
