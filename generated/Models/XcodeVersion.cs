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
    /// The Xcode version
    /// </summary>
    public partial class XcodeVersion
    {
        /// <summary>
        /// Initializes a new instance of the XcodeVersion class.
        /// </summary>
        public XcodeVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the XcodeVersion class.
        /// </summary>
        /// <param name="name">The version name</param>
        /// <param name="current">If the Xcode is latest stable</param>
        public XcodeVersion(string name = default(string), bool? current = default(bool?))
        {
            Name = name;
            Current = current;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if the Xcode is latest stable
        /// </summary>
        [JsonProperty(PropertyName = "current")]
        public bool? Current { get; set; }

    }
}