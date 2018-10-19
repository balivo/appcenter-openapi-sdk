// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GDPRPurgeVerifyResponse
    {
        /// <summary>
        /// Initializes a new instance of the GDPRPurgeVerifyResponse class.
        /// </summary>
        public GDPRPurgeVerifyResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GDPRPurgeVerifyResponse class.
        /// </summary>
        /// <param name="success">indicate whether GDPR purge operation
        /// succeeds or not</param>
        public GDPRPurgeVerifyResponse(bool success)
        {
            Success = success;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicate whether GDPR purge operation succeeds or not
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}