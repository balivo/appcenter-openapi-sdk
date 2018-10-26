// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Updates the status of the resign request
    /// </summary>
    public partial class UpdateResignStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateResignStatusRequest class.
        /// </summary>
        public UpdateResignStatusRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateResignStatusRequest class.
        /// </summary>
        /// <param name="status">The updated status for the resigning
        /// request.</param>
        /// <param name="errorCode">Error code if an error occured in the
        /// resigning operation.</param>
        /// <param name="errorMessage">Error message if an error occured in the
        /// resigning operation.</param>
        public UpdateResignStatusRequest(string status, string errorCode = default(string), string errorMessage = default(string))
        {
            Status = status;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the updated status for the resigning request.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets error code if an error occured in the resigning
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets error message if an error occured in the resigning
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}