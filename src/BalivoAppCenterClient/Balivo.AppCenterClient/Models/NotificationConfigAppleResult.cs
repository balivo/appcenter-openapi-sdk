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
    /// Apple notification certificate configuration result.
    /// </summary>
    [Newtonsoft.Json.JsonObject("apns_config")]
    public partial class NotificationConfigAppleResult : NotificationConfigResult
    {
        /// <summary>
        /// Initializes a new instance of the NotificationConfigAppleResult
        /// class.
        /// </summary>
        public NotificationConfigAppleResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationConfigAppleResult
        /// class.
        /// </summary>
        /// <param name="endpointType">Possible values include: 'production',
        /// 'sandbox'</param>
        /// <param name="certExpiration">Certificate expiration date.</param>
        /// <param name="certFilename">Certificate file name</param>
        public NotificationConfigAppleResult(string endpointType, System.DateTime certExpiration, string certFilename)
        {
            EndpointType = endpointType;
            CertExpiration = certExpiration;
            CertFilename = certFilename;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'production', 'sandbox'
        /// </summary>
        [JsonProperty(PropertyName = "endpoint_type")]
        public string EndpointType { get; set; }

        /// <summary>
        /// Gets or sets certificate expiration date.
        /// </summary>
        [JsonProperty(PropertyName = "cert_expiration")]
        public System.DateTime CertExpiration { get; set; }

        /// <summary>
        /// Gets or sets certificate file name
        /// </summary>
        [JsonProperty(PropertyName = "cert_filename")]
        public string CertFilename { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EndpointType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndpointType");
            }
            if (CertFilename == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CertFilename");
            }
        }
    }
}