// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReleaseUpdateResponseDestinationsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReleaseUpdateResponseDestinationsItem class.
        /// </summary>
        public ReleaseUpdateResponseDestinationsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ReleaseUpdateResponseDestinationsItem class.
        /// </summary>
        public ReleaseUpdateResponseDestinationsItem(string id = default(string), string name = default(string))
        {
            Id = id;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}