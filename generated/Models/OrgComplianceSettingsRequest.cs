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
    /// org settings Request
    /// </summary>
    public partial class OrgComplianceSettingsRequest
    {
        /// <summary>
        /// Initializes a new instance of the OrgComplianceSettingsRequest
        /// class.
        /// </summary>
        public OrgComplianceSettingsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrgComplianceSettingsRequest
        /// class.
        /// </summary>
        /// <param name="certificateConnectionId">certificate connection id to
        /// wrap and resign the app after wrapping</param>
        public OrgComplianceSettingsRequest(string certificateConnectionId)
        {
            CertificateConnectionId = certificateConnectionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate connection id to wrap and resign the app
        /// after wrapping
        /// </summary>
        [JsonProperty(PropertyName = "certificate_connection_id")]
        public string CertificateConnectionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CertificateConnectionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CertificateConnectionId");
            }
        }
    }
}
