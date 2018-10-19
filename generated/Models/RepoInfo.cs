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

    public partial class RepoInfo
    {
        /// <summary>
        /// Initializes a new instance of the RepoInfo class.
        /// </summary>
        public RepoInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepoInfo class.
        /// </summary>
        /// <param name="repoUrl">The repository url</param>
        public RepoInfo(string repoUrl)
        {
            RepoUrl = repoUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the repository url
        /// </summary>
        [JsonProperty(PropertyName = "repo_url")]
        public string RepoUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RepoUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RepoUrl");
            }
        }
    }
}
