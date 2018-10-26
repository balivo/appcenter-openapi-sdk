// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DistributionGroupAADGroupPostResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupAADGroupPostResponse class.
        /// </summary>
        public DistributionGroupAADGroupPostResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupAADGroupPostResponse class.
        /// </summary>
        /// <param name="id">The internal unique id (UUID) of the AAD
        /// group.</param>
        /// <param name="aadGroupId">The AAD unique id (UUID) of the AAD
        /// group.</param>
        /// <param name="displayName">The display name of the AAD group</param>
        public DistributionGroupAADGroupPostResponse(System.Guid? id = default(System.Guid?), System.Guid? aadGroupId = default(System.Guid?), string displayName = default(string))
        {
            Id = id;
            AadGroupId = aadGroupId;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the internal unique id (UUID) of the AAD group.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets the AAD unique id (UUID) of the AAD group.
        /// </summary>
        [JsonProperty(PropertyName = "aad_group_id")]
        public System.Guid? AadGroupId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the AAD group
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

    }
}