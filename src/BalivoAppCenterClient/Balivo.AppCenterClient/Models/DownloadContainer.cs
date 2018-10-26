// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A download reference
    /// </summary>
    public partial class DownloadContainer
    {
        /// <summary>
        /// Initializes a new instance of the DownloadContainer class.
        /// </summary>
        public DownloadContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DownloadContainer class.
        /// </summary>
        /// <param name="uri">Download URI</param>
        public DownloadContainer(string uri)
        {
            Uri = uri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets download URI
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
        }
    }
}