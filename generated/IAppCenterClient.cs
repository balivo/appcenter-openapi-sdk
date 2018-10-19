// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Microsoft Visual Studio App Center API
    /// </summary>
    public partial interface IAppCenterClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IDevices.
        /// </summary>
        IDevices Devices { get; }

        /// <summary>
        /// Gets the INotifications.
        /// </summary>
        INotifications Notifications { get; }

        /// <summary>
        /// Gets the IOrgInvitations.
        /// </summary>
        IOrgInvitations OrgInvitations { get; }

        /// <summary>
        /// Gets the IDistributionGroupInvitations.
        /// </summary>
        IDistributionGroupInvitations DistributionGroupInvitations { get; }

        /// <summary>
        /// Gets the IAppInvitations.
        /// </summary>
        IAppInvitations AppInvitations { get; }

        /// <summary>
        /// Gets the ISharedconnection.
        /// </summary>
        ISharedconnection Sharedconnection { get; }

        /// <summary>
        /// Gets the IDataSubjectRight.
        /// </summary>
        IDataSubjectRight DataSubjectRight { get; }

        /// <summary>
        /// Gets the IUsers.
        /// </summary>
        IUsers Users { get; }

        /// <summary>
        /// Gets the IReleases.
        /// </summary>
        IReleases Releases { get; }

        /// <summary>
        /// Gets the IBuilds.
        /// </summary>
        IBuilds Builds { get; }

        /// <summary>
        /// Gets the ICodePushAcquisition.
        /// </summary>
        ICodePushAcquisition CodePushAcquisition { get; }

        /// <summary>
        /// Gets the IDistibutionReleases.
        /// </summary>
        IDistibutionReleases DistibutionReleases { get; }

        /// <summary>
        /// Gets the IDistributionGroups.
        /// </summary>
        IDistributionGroups DistributionGroups { get; }

        /// <summary>
        /// Gets the ITeams.
        /// </summary>
        ITeams Teams { get; }

        /// <summary>
        /// Gets the IAzureSubscription.
        /// </summary>
        IAzureSubscription AzureSubscription { get; }

        /// <summary>
        /// Gets the IOrganization.
        /// </summary>
        IOrganization Organization { get; }

        /// <summary>
        /// Gets the IApps.
        /// </summary>
        IApps Apps { get; }

        /// <summary>
        /// Gets the IOrganizations.
        /// </summary>
        IOrganizations Organizations { get; }

        /// <summary>
        /// Gets the IInvitations.
        /// </summary>
        IInvitations Invitations { get; }

        /// <summary>
        /// Gets the INpsSurvey.
        /// </summary>
        INpsSurvey NpsSurvey { get; }

        /// <summary>
        /// Gets the IHappinessSurvey.
        /// </summary>
        IHappinessSurvey HappinessSurvey { get; }

        /// <summary>
        /// Gets the IWebhooks.
        /// </summary>
        IWebhooks Webhooks { get; }

        /// <summary>
        /// Gets the ICrashes.
        /// </summary>
        ICrashes Crashes { get; }

        /// <summary>
        /// Gets the ITest.
        /// </summary>
        ITest Test { get; }

        /// <summary>
        /// Gets the ISymbols.
        /// </summary>
        ISymbols Symbols { get; }

        /// <summary>
        /// Gets the ISymbolUploads.
        /// </summary>
        ISymbolUploads SymbolUploads { get; }

        /// <summary>
        /// Gets the IMissingSymbolGroups.
        /// </summary>
        IMissingSymbolGroups MissingSymbolGroups { get; }

        /// <summary>
        /// Gets the IRepositories.
        /// </summary>
        IRepositories Repositories { get; }

        /// <summary>
        /// Gets the IRepositoryConfigurations.
        /// </summary>
        IRepositoryConfigurations RepositoryConfigurations { get; }

        /// <summary>
        /// Gets the IProvisioning.
        /// </summary>
        IProvisioning Provisioning { get; }

        /// <summary>
        /// Gets the IReleaseUploads.
        /// </summary>
        IReleaseUploads ReleaseUploads { get; }

        /// <summary>
        /// Gets the IPush.
        /// </summary>
        IPush Push { get; }

        /// <summary>
        /// Gets the IFileAssets.
        /// </summary>
        IFileAssets FileAssets { get; }

        /// <summary>
        /// Gets the IExportConfigurations.
        /// </summary>
        IExportConfigurations ExportConfigurations { get; }

        /// <summary>
        /// Gets the IErrors.
        /// </summary>
        IErrors Errors { get; }

        /// <summary>
        /// Gets the IStoreReleases.
        /// </summary>
        IStoreReleases StoreReleases { get; }

        /// <summary>
        /// Gets the IStores.
        /// </summary>
        IStores Stores { get; }

        /// <summary>
        /// Gets the IApp.
        /// </summary>
        IApp App { get; }

        /// <summary>
        /// Gets the ICodePushDeploymentRelease.
        /// </summary>
        ICodePushDeploymentRelease CodePushDeploymentRelease { get; }

        /// <summary>
        /// Gets the IDeploymentReleases.
        /// </summary>
        IDeploymentReleases DeploymentReleases { get; }

        /// <summary>
        /// Gets the ICodePushDeploymentReleases.
        /// </summary>
        ICodePushDeploymentReleases CodePushDeploymentReleases { get; }

        /// <summary>
        /// Gets the ICodePushDeployments.
        /// </summary>
        ICodePushDeployments CodePushDeployments { get; }

        /// <summary>
        /// Gets the ICodePushDeploymentMetrics.
        /// </summary>
        ICodePushDeploymentMetrics CodePushDeploymentMetrics { get; }

        /// <summary>
        /// Gets the ICrashGroups.
        /// </summary>
        ICrashGroups CrashGroups { get; }

        /// <summary>
        /// Gets the ICommits.
        /// </summary>
        ICommits Commits { get; }

        /// <summary>
        /// Gets the IBugTracker.
        /// </summary>
        IBugTracker BugTracker { get; }

        /// <summary>
        /// Gets the IBranchConfigurations.
        /// </summary>
        IBranchConfigurations BranchConfigurations { get; }

        /// <summary>
        /// Gets the IAppleMapping.
        /// </summary>
        IAppleMapping AppleMapping { get; }

        /// <summary>
        /// Gets the IAnalytics.
        /// </summary>
        IAnalytics Analytics { get; }

        /// <summary>
        /// Gets the IApiTokens.
        /// </summary>
        IApiTokens ApiTokens { get; }

    }
}
