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
    /// Response for provisioning a release
    /// </summary>
    public partial class ReleaseProvisionResponse
    {
        /// <summary>
        /// Initializes a new instance of the ReleaseProvisionResponse class.
        /// </summary>
        public ReleaseProvisionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReleaseProvisionResponse class.
        /// </summary>
        /// <param name="statusUrl">The url to check provisioning
        /// status.</param>
        public ReleaseProvisionResponse(string statusUrl = default(string))
        {
            StatusUrl = statusUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the url to check provisioning status.
        /// </summary>
        [JsonProperty(PropertyName = "status_url")]
        public string StatusUrl { get; set; }

    }
}
