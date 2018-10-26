// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using System.Linq;

    /// <summary>
    /// Apple connection secrets
    /// </summary>
    public partial class AppleConnectionSecretRequest : SharedConnectionRequest
    {
        /// <summary>
        /// Initializes a new instance of the AppleConnectionSecretRequest
        /// class.
        /// </summary>
        public AppleConnectionSecretRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppleConnectionSecretRequest
        /// class.
        /// </summary>
        /// <param name="displayName">display name of shared connection</param>
        /// <param name="credentialType">credential type of the shared
        /// connection. Values can be credentials|certificate. Possible values
        /// include: 'credentials', 'certificate'</param>
        public AppleConnectionSecretRequest(string displayName = default(string), string credentialType = default(string))
            : base(displayName, credentialType)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
