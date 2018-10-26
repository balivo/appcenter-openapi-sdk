// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DistributionGroups operations.
    /// </summary>
    public partial interface IDistributionGroups
    {
        /// <summary>
        /// Returns a unique list of users including the whole organization
        /// members plus testers in any shared group of that org
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DistributionGroupTesterGetResponse>>> ListAllTestersForOrgWithHttpMessagesAsync(string orgName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of distribution groups with details for an
        /// organization
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='appsLimit'>
        /// The max number of apps to include in the response
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<OrgDistributionGroupDetailsResponse>>> DetailsForOrgWithHttpMessagesAsync(string orgName, double? appsLimit = default(double?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resend shared distribution group invite notification to previously
        /// invited testers
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='members'>
        /// The list of members to add
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> ResendSharedInviteWithHttpMessagesAsync(string orgName, string distributionGroupName, DistributionGroupUserRequest members, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete apps from distribution group in an org
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='members'>
        /// The list of members to add
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> BulkDeleteUsersWithHttpMessagesAsync(string orgName, string distributionGroupName, DistributionGroupUserRequest members, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of member in the distribution group specified
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DistributionGroupUserGetResponse>>> ListUsersForOrgWithHttpMessagesAsync(string orgName, string distributionGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Accepts an array of user email addresses to get added to the
        /// specified group
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='memberEmails'>
        /// list of user email addresses that should get added as members to
        /// the specified group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DistributionGroupUserPostResponse>>> AddUsersForOrgWithHttpMessagesAsync(string orgName, string distributionGroupName, DistributionGroupUserRequest memberEmails, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete apps from distribution group in an org
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='apps'>
        /// The name of the apps to be deleted from the distribution group. The
        /// apps have to be owned by the organization.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> BulkDeleteAppsWithHttpMessagesAsync(string orgName, string distributionGroupName, DistributionGroupAppsDeleteRequest apps, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get apps from a distribution group in an org
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<OrgDistributionGroupAppResponse>>> GetAppsWithHttpMessagesAsync(string orgName, string distributionGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add apps to distribution group in an org
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='apps'>
        /// The name of the apps to be added to the distribution group. The
        /// apps have to be owned by the organization.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddAppsWithHttpMessagesAsync(string orgName, string distributionGroupName, DistributionGroupAppAddRequest apps, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a single distribution group in org for a given distribution
        /// group name
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DistributionGroupResponse>> GetForOrgWithHttpMessagesAsync(string orgName, string distributionGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update one given distribution group name in an org
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='distributionGroup'>
        /// The attributes to update for the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DistributionGroupResponse>> PatchForOrgWithHttpMessagesAsync(string orgName, string distributionGroupName, DistributionGroupPatchRequest distributionGroup, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a single distribution group from an org with a given
        /// distribution group name
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteForOrgWithHttpMessagesAsync(string orgName, string distributionGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a disribution goup which can be shared across apps under an
        /// organization
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='distributionGroup'>
        /// The attributes to update for the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DistributionGroupResponse>> CreateForOrgWithHttpMessagesAsync(string orgName, DistributionGroupRequest distributionGroup, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of distribution groups in the org specified
        /// </summary>
        /// <param name='orgName'>
        /// The organization's name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DistributionGroupResponse>>> ListForOrgWithHttpMessagesAsync(string orgName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resend distribution group app invite notification to previously
        /// invited testers
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='members'>
        /// The list of members to add
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> ResendInviteWithHttpMessagesAsync(string ownerName, string appName, string distributionGroupName, DistributionGroupUserRequest members, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove the users from the distribution group
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='members'>
        /// The list of members to add
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DistributionGroupUserDeleteResponse>>> RemoveUserWithHttpMessagesAsync(string ownerName, string appName, string distributionGroupName, DistributionGroupUserRequest members, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of member details in the distribution group
        /// specified
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='excludePendingInvitations'>
        /// Whether to exclude pending invitations in the response
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DistributionGroupUserGetResponse>>> ListUsersWithHttpMessagesAsync(string ownerName, string appName, string distributionGroupName, bool? excludePendingInvitations = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds the members to the specified distribution group
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='members'>
        /// The list of members to add
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DistributionGroupUserPostResponse>>> AddUserWithHttpMessagesAsync(string ownerName, string appName, string distributionGroupName, DistributionGroupUserRequest members, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a single distribution group for a given distribution group
        /// name
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DistributionGroupResponse>> GetWithHttpMessagesAsync(string ownerName, string appName, string distributionGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the attributes of distribution group
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='distributionGroup'>
        /// The attributes to update for the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DistributionGroupResponse>> UpdateWithHttpMessagesAsync(string ownerName, string appName, string distributionGroupName, DistributionGroupPatchRequest distributionGroup, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a distribution group
        /// </summary>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='distributionGroupName'>
        /// The name of the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string appName, string ownerName, string distributionGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of distribution groups in the app specified
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DistributionGroupResponse>>> ListWithHttpMessagesAsync(string ownerName, string appName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new distribution group and returns it to the caller
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='distributionGroup'>
        /// The attributes to update for the distribution group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DistributionGroupResponse>> CreateWithHttpMessagesAsync(string ownerName, string appName, DistributionGroupRequest distributionGroup, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
