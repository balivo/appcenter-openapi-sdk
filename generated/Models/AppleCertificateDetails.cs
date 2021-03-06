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
    /// Apple Certificate Details
    /// </summary>
    public partial class AppleCertificateDetails
    {
        /// <summary>
        /// Initializes a new instance of the AppleCertificateDetails class.
        /// </summary>
        public AppleCertificateDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppleCertificateDetails class.
        /// </summary>
        /// <param name="base64Certificate">The certificate contents in base 64
        /// encoded string</param>
        /// <param name="password">The password for the certificate</param>
        public AppleCertificateDetails(string base64Certificate, string password)
        {
            Base64Certificate = base64Certificate;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the certificate contents in base 64 encoded string
        /// </summary>
        [JsonProperty(PropertyName = "base64Certificate")]
        public string Base64Certificate { get; set; }

        /// <summary>
        /// Gets or sets the password for the certificate
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Base64Certificate == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Base64Certificate");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
