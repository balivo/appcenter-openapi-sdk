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
    /// supported feature
    /// </summary>
    public partial class AppBuildFeature
    {
        /// <summary>
        /// Initializes a new instance of the AppBuildFeature class.
        /// </summary>
        public AppBuildFeature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppBuildFeature class.
        /// </summary>
        public AppBuildFeature(string name = default(string), bool? value = default(bool?))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public bool? Value { get; set; }

    }
}
