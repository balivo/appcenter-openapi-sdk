// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AppResponseInternal : AppResponse
    {
        /// <summary>
        /// Initializes a new instance of the AppResponseInternal class.
        /// </summary>
        public AppResponseInternal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppResponseInternal class.
        /// </summary>
        /// <param name="id">The unique ID (UUID) of the app</param>
        /// <param name="displayName">The display name of the app</param>
        /// <param name="name">The name of the app used in URLs</param>
        /// <param name="os">The OS the app will be running on. Possible values
        /// include: 'Android', 'iOS', 'macOS', 'Tizen', 'tvOS', 'Windows',
        /// 'Custom'</param>
        /// <param name="appSecret">A unique and secret key used to identify
        /// the app in communication with the ingestion endpoint for crash
        /// reporting and analytics</param>
        /// <param name="platform">The platform of the app. Possible values
        /// include: 'Java', 'Objective-C-Swift', 'UWP', 'Cordova',
        /// 'React-Native', 'Unity', 'Xamarin', 'Unknown'</param>
        /// <param name="origin">The creation origin of this app. Possible
        /// values include: 'appcenter', 'hockeyapp', 'codepush'</param>
        /// <param name="description">The description of the app</param>
        /// <param name="iconUrl">The string representation of the URL pointing
        /// to the app's icon</param>
        /// <param name="iconSource">The string representation of the source of
        /// the app's icon</param>
        /// <param name="createdAt">The created date of this app</param>
        /// <param name="updatedAt">The last updated date of this app</param>
        /// <param name="memberPermissions">The permissions of the calling
        /// user</param>
        /// <param name="featureFlags">The feature flags that are enabled for
        /// this app</param>
        /// <param name="repositories">The repositories associated with this
        /// app</param>
        public AppResponseInternal(System.Guid id, string displayName, string name, string os, Owner owner, string appSecret, string platform, string origin, string description = default(string), string iconUrl = default(string), string iconSource = default(string), AzureSubscriptionResponse azureSubscription = default(AzureSubscriptionResponse), string createdAt = default(string), string updatedAt = default(string), IList<string> memberPermissions = default(IList<string>), IList<string> featureFlags = default(IList<string>), IList<AppResponseInternalRepositoriesItem> repositories = default(IList<AppResponseInternalRepositoriesItem>))
            : base(id, displayName, name, os, owner, appSecret, platform, origin, description, iconUrl, iconSource, azureSubscription, createdAt, updatedAt, memberPermissions)
        {
            FeatureFlags = featureFlags;
            Repositories = repositories;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the feature flags that are enabled for this app
        /// </summary>
        [JsonProperty(PropertyName = "feature_flags")]
        public IList<string> FeatureFlags { get; set; }

        /// <summary>
        /// Gets or sets the repositories associated with this app
        /// </summary>
        [JsonProperty(PropertyName = "repositories")]
        public IList<AppResponseInternalRepositoriesItem> Repositories { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
