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
    /// Billing Plan with a version
    /// </summary>
    public partial class VersionedBillingPlan
    {
        /// <summary>
        /// Initializes a new instance of the VersionedBillingPlan class.
        /// </summary>
        public VersionedBillingPlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VersionedBillingPlan class.
        /// </summary>
        /// <param name="etag">The version of the object</param>
        public VersionedBillingPlan(BillingPlan document = default(BillingPlan), string etag = default(string))
        {
            Document = document;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "document")]
        public BillingPlan Document { get; set; }

        /// <summary>
        /// Gets or sets the version of the object
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
