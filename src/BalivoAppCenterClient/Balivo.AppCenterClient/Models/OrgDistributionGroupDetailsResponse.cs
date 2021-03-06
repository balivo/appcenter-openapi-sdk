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

    public partial class OrgDistributionGroupDetailsResponse : DistributionGroupResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OrgDistributionGroupDetailsResponse class.
        /// </summary>
        public OrgDistributionGroupDetailsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OrgDistributionGroupDetailsResponse class.
        /// </summary>
        /// <param name="id">The unique ID of the distribution group</param>
        /// <param name="name">The name of the distribution group used in
        /// URLs</param>
        /// <param name="origin">The creation origin of this distribution
        /// group. Possible values include: 'appcenter', 'hockeyapp'</param>
        /// <param name="isPublic">Whether the distribution group is
        /// public</param>
        /// <param name="totalAppsCount">The count of apps associated with this
        /// distribution group</param>
        /// <param name="totalUsersCount">The count of users in the
        /// distribution group</param>
        /// <param name="apps">The apps associated with the distribution
        /// group</param>
        public OrgDistributionGroupDetailsResponse(System.Guid id, string name, string origin, bool isPublic, double totalAppsCount, double totalUsersCount, IList<AppResponse> apps)
            : base(id, name, origin, isPublic)
        {
            TotalAppsCount = totalAppsCount;
            TotalUsersCount = totalUsersCount;
            Apps = apps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the count of apps associated with this distribution
        /// group
        /// </summary>
        [JsonProperty(PropertyName = "total_apps_count")]
        public double TotalAppsCount { get; set; }

        /// <summary>
        /// Gets or sets the count of users in the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "total_users_count")]
        public double TotalUsersCount { get; set; }

        /// <summary>
        /// Gets or sets the apps associated with the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "apps")]
        public IList<AppResponse> Apps { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Apps == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Apps");
            }
            if (Apps != null)
            {
                foreach (var element in Apps)
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
