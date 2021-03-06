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
    /// Apple connection secrets
    /// </summary>
    public partial class AppleCertificateSecretDetailsResponse : SharedConnectionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AppleCertificateSecretDetailsResponse class.
        /// </summary>
        public AppleCertificateSecretDetailsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AppleCertificateSecretDetailsResponse class.
        /// </summary>
        /// <param name="id">id of the shared connection</param>
        /// <param name="credentialType">the type of the credential. Possible
        /// values include: 'credentials', 'certificate'</param>
        /// <param name="data">apple certificate secret details.</param>
        /// <param name="displayName">display name of shared connection</param>
        /// <param name="isValid">whether the credentials are valid or
        /// not</param>
        /// <param name="is2FA">if the account is a 2FA account or not</param>
        public AppleCertificateSecretDetailsResponse(string id, string credentialType, AppleCertificateSecretDetails data, string displayName = default(string), bool? isValid = default(bool?), bool? is2FA = default(bool?))
            : base(id, credentialType, displayName, isValid, is2FA)
        {
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets apple certificate secret details.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public AppleCertificateSecretDetails Data { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
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
