// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CodePushReleaseLabel
    {
        /// <summary>
        /// Initializes a new instance of the CodePushReleaseLabel class.
        /// </summary>
        public CodePushReleaseLabel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CodePushReleaseLabel class.
        /// </summary>
        public CodePushReleaseLabel(string label = default(string))
        {
            Label = label;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

    }
}
