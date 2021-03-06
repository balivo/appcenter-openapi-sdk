// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Organizations.
    /// </summary>
    public static partial class OrganizationsExtensions
    {
            /// <summary>
            /// Returns the details of a single organization
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            public static OrganizationResponse Get(this IOrganizations operations, string orgName)
            {
                return operations.GetAsync(orgName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the details of a single organization
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrganizationResponse> GetAsync(this IOrganizations operations, string orgName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(orgName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of organizations the requesting user has access to
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            /// <param name='org'>
            /// The data for the org
            /// </param>
            public static OrganizationResponse Update(this IOrganizations operations, string orgName, OrganizationPatchRequest org)
            {
                return operations.UpdateAsync(orgName, org).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of organizations the requesting user has access to
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            /// <param name='org'>
            /// The data for the org
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrganizationResponse> UpdateAsync(this IOrganizations operations, string orgName, OrganizationPatchRequest org, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(orgName, org, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a single organization
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            public static void Delete(this IOrganizations operations, string orgName)
            {
                operations.DeleteAsync(orgName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a single organization
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IOrganizations operations, string orgName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(orgName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new organization and returns it to the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='organization'>
            /// The organization data
            /// </param>
            public static OrganizationResponse CreateOrUpdate(this IOrganizations operations, OrganizationRequest organization)
            {
                return operations.CreateOrUpdateAsync(organization).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new organization and returns it to the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='organization'>
            /// The organization data
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrganizationResponse> CreateOrUpdateAsync(this IOrganizations operations, OrganizationRequest organization, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(organization, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of organizations the requesting user has access to
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<ListOKResponseItem> List(this IOrganizations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of organizations the requesting user has access to
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ListOKResponseItem>> ListAsync(this IOrganizations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
