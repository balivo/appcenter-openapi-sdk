// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class FilterVersionsContainer
    {
        /// <summary>
        /// Initializes a new instance of the FilterVersionsContainer class.
        /// </summary>
        public FilterVersionsContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FilterVersionsContainer class.
        /// </summary>
        public FilterVersionsContainer(IList<FilterVersionsContainerVersionsItem> versions = default(IList<FilterVersionsContainerVersionsItem>))
        {
            Versions = versions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<FilterVersionsContainerVersionsItem> Versions { get; set; }

    }
}
