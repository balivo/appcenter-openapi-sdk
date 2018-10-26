// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class StoreDestinationDetails
    {
        /// <summary>
        /// Initializes a new instance of the StoreDestinationDetails class.
        /// </summary>
        public StoreDestinationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StoreDestinationDetails class.
        /// </summary>
        /// <param name="destPublishId">destination ID identifying a unique id
        /// in distribution store.</param>
        /// <param name="storeType">type of store. Possible values include:
        /// 'intune', 'windows'</param>
        /// <param name="appId">app id of application.</param>
        public StoreDestinationDetails(string destPublishId = default(string), string storeType = default(string), string appId = default(string))
        {
            DestPublishId = destPublishId;
            StoreType = storeType;
            AppId = appId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets destination ID identifying a unique id in distribution
        /// store.
        /// </summary>
        [JsonProperty(PropertyName = "dest_publish_id")]
        public string DestPublishId { get; set; }

        /// <summary>
        /// Gets or sets type of store. Possible values include: 'intune',
        /// 'windows'
        /// </summary>
        [JsonProperty(PropertyName = "store_type")]
        public string StoreType { get; set; }

        /// <summary>
        /// Gets or sets app id of application.
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

    }
}