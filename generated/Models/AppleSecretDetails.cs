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
    /// Apple secret details
    /// </summary>
    public partial class AppleSecretDetails
    {
        /// <summary>
        /// Initializes a new instance of the AppleSecretDetails class.
        /// </summary>
        public AppleSecretDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppleSecretDetails class.
        /// </summary>
        /// <param name="username">username to connect to apple store.</param>
        /// <param name="authCode">6 digit auth code</param>
        /// <param name="password">password to connect to apple store.</param>
        public AppleSecretDetails(string username = default(string), string authCode = default(string), string password = default(string))
        {
            Username = username;
            AuthCode = authCode;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets username to connect to apple store.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets 6 digit auth code
        /// </summary>
        [JsonProperty(PropertyName = "authCode")]
        public string AuthCode { get; set; }

        /// <summary>
        /// Gets or sets password to connect to apple store.
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
            if (AuthCode != null)
            {
                if (AuthCode.Length > 6)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AuthCode", 6);
                }
                if (AuthCode.Length < 6)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AuthCode", 6);
                }
            }
        }
    }
}