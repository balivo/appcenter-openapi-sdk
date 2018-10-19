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
    /// The repository which is accessiable by GitHub App Installation
    /// </summary>
    public partial class GitHubInstallationRepository
    {
        /// <summary>
        /// Initializes a new instance of the GitHubInstallationRepository
        /// class.
        /// </summary>
        public GitHubInstallationRepository()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GitHubInstallationRepository
        /// class.
        /// </summary>
        /// <param name="name">The repository name</param>
        /// <param name="description">The discription of repository</param>
        /// <param name="cloneUrl">URL used to clone the repository</param>
        /// <param name="defaultBranch">The default branch for the repo</param>
        /// <param name="language">The language in the repository</param>
        /// <param name="updatedAt">The repository updated time</param>
        /// <param name="fork">Whether the repository is a fork</param>
        public GitHubInstallationRepository(string name = default(string), string description = default(string), string cloneUrl = default(string), string defaultBranch = default(string), string language = default(string), string updatedAt = default(string), object fork = default(object))
        {
            Name = name;
            Description = description;
            CloneUrl = cloneUrl;
            DefaultBranch = defaultBranch;
            Language = language;
            UpdatedAt = updatedAt;
            Fork = fork;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the repository name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the discription of repository
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets URL used to clone the repository
        /// </summary>
        [JsonProperty(PropertyName = "clone_url")]
        public string CloneUrl { get; set; }

        /// <summary>
        /// Gets or sets the default branch for the repo
        /// </summary>
        [JsonProperty(PropertyName = "default_branch")]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// Gets or sets the language in the repository
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the repository updated time
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets whether the repository is a fork
        /// </summary>
        [JsonProperty(PropertyName = "fork")]
        public object Fork { get; set; }

    }
}
