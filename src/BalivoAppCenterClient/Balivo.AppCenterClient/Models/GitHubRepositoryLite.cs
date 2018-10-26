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
    /// The lite version of GitHub repository
    /// </summary>
    public partial class GitHubRepositoryLite
    {
        /// <summary>
        /// Initializes a new instance of the GitHubRepositoryLite class.
        /// </summary>
        public GitHubRepositoryLite()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GitHubRepositoryLite class.
        /// </summary>
        /// <param name="id">The repository id</param>
        public GitHubRepositoryLite(double? id = default(double?))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the repository id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public double? Id { get; set; }

    }
}