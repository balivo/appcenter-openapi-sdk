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

    public partial class RepoConfig
    {
        /// <summary>
        /// Initializes a new instance of the RepoConfig class.
        /// </summary>
        public RepoConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepoConfig class.
        /// </summary>
        /// <param name="type">Type of repository</param>
        /// <param name="state">State of the configuration. Possible values
        /// include: 'unauthorized', 'inactive', 'active'</param>
        /// <param name="repoUrl">URL of the repository</param>
        /// <param name="id">Repository identifier</param>
        public RepoConfig(string type, string state, string repoUrl = default(string), string id = default(string))
        {
            Type = type;
            State = state;
            RepoUrl = repoUrl;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of repository
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets state of the configuration. Possible values include:
        /// 'unauthorized', 'inactive', 'active'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets URL of the repository
        /// </summary>
        [JsonProperty(PropertyName = "repo_url")]
        public string RepoUrl { get; set; }

        /// <summary>
        /// Gets or sets repository identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
        }
    }
}
