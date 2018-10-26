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
    /// GDPR tests verification result
    /// </summary>
    public partial class GdprVerificationResult
    {
        /// <summary>
        /// Initializes a new instance of the GdprVerificationResult class.
        /// </summary>
        public GdprVerificationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GdprVerificationResult class.
        /// </summary>
        /// <param name="status">Verification status. True means that the
        /// verification was successfull.</param>
        /// <param name="message">Optional error message if the verification
        /// failed.</param>
        public GdprVerificationResult(bool? status = default(bool?), string message = default(string))
        {
            Status = status;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets verification status. True means that the verification
        /// was successfull.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public bool? Status { get; set; }

        /// <summary>
        /// Gets or sets optional error message if the verification failed.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
