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

    public partial class ErrorFreeDevicePercentages
    {
        /// <summary>
        /// Initializes a new instance of the ErrorFreeDevicePercentages class.
        /// </summary>
        public ErrorFreeDevicePercentages()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorFreeDevicePercentages class.
        /// </summary>
        /// <param name="averagePercentage">Average percentage</param>
        /// <param name="dailyPercentages">The error-free percentage per
        /// day.</param>
        public ErrorFreeDevicePercentages(double? averagePercentage = default(double?), IList<ErrorDateTimePercentages> dailyPercentages = default(IList<ErrorDateTimePercentages>))
        {
            AveragePercentage = averagePercentage;
            DailyPercentages = dailyPercentages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets average percentage
        /// </summary>
        [JsonProperty(PropertyName = "averagePercentage")]
        public double? AveragePercentage { get; set; }

        /// <summary>
        /// Gets or sets the error-free percentage per day.
        /// </summary>
        [JsonProperty(PropertyName = "dailyPercentages")]
        public IList<ErrorDateTimePercentages> DailyPercentages { get; set; }

    }
}
