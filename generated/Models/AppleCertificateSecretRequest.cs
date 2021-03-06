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
    /// Apple certificate secrets
    /// </summary>
    public partial class AppleCertificateSecretRequest : AppleConnectionSecretRequest
    {
        /// <summary>
        /// Initializes a new instance of the AppleCertificateSecretRequest
        /// class.
        /// </summary>
        public AppleCertificateSecretRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppleCertificateSecretRequest
        /// class.
        /// </summary>
        /// <param name="data">apple secret details</param>
        /// <param name="displayName">display name of shared connection</param>
        /// <param name="credentialType">credential type of the shared
        /// connection. Values can be credentials|certificate. Possible values
        /// include: 'credentials', 'certificate'</param>
        public AppleCertificateSecretRequest(AppleCertificateDetails data, string displayName = default(string), string credentialType = default(string))
            : base(displayName, credentialType)
        {
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets apple secret details
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public AppleCertificateDetails Data { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Data == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Data");
            }
            if (Data != null)
            {
                Data.Validate();
            }
        }
    }
}
