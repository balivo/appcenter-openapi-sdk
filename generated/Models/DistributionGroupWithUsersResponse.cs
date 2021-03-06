// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DistributionGroupWithUsersResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupWithUsersResponse class.
        /// </summary>
        public DistributionGroupWithUsersResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupWithUsersResponse class.
        /// </summary>
        /// <param name="id">The unique ID of the distribution group</param>
        /// <param name="name">The name of the distribution group used in
        /// URLs</param>
        /// <param name="totalUserCount">The count of users in the distribution
        /// group</param>
        /// <param name="notifiedUserCount">The count of non-pending users in
        /// the distribution group who will be notified by new releases</param>
        /// <param name="users">The distribution group users</param>
        /// <param name="totalGroupsCount">The count of aad groups in the
        /// distribution group</param>
        /// <param name="isPublic">Whether the distribution group is
        /// public</param>
        /// <param name="aadGroups">The distribution group aad groups</param>
        public DistributionGroupWithUsersResponse(System.Guid id, string name, double totalUserCount, double notifiedUserCount, IList<DistributionGroupUserGetResponse> users, double? totalGroupsCount = default(double?), bool? isPublic = default(bool?), IList<DistributionGroupAADGroupPostResponse> aadGroups = default(IList<DistributionGroupAADGroupPostResponse>))
        {
            Id = id;
            Name = name;
            TotalUserCount = totalUserCount;
            TotalGroupsCount = totalGroupsCount;
            NotifiedUserCount = notifiedUserCount;
            IsPublic = isPublic;
            Users = users;
            AadGroups = aadGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique ID of the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the distribution group used in URLs
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the count of users in the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "total_user_count")]
        public double TotalUserCount { get; set; }

        /// <summary>
        /// Gets or sets the count of aad groups in the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "total_groups_count")]
        public double? TotalGroupsCount { get; set; }

        /// <summary>
        /// Gets or sets the count of non-pending users in the distribution
        /// group who will be notified by new releases
        /// </summary>
        [JsonProperty(PropertyName = "notified_user_count")]
        public double NotifiedUserCount { get; set; }

        /// <summary>
        /// Gets or sets whether the distribution group is public
        /// </summary>
        [JsonProperty(PropertyName = "is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Gets or sets the distribution group users
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<DistributionGroupUserGetResponse> Users { get; set; }

        /// <summary>
        /// Gets or sets the distribution group aad groups
        /// </summary>
        [JsonProperty(PropertyName = "aad_groups")]
        public IList<DistributionGroupAADGroupPostResponse> AadGroups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Users == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Users");
            }
            if (Users != null)
            {
                foreach (var element in Users)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
