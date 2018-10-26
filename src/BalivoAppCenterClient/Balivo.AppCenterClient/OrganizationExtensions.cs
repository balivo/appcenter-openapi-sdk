// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Organization.
    /// </summary>
    public static partial class OrganizationExtensions
    {
            /// <summary>
            /// Sets the organization avatar
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            /// <param name='avatar'>
            /// The image for an Organization avatar to upload.
            /// </param>
            public static OrganizationResponse UpdateAvatar(this IOrganization operations, string orgName, string avatar = default(string))
            {
                return operations.UpdateAvatarAsync(orgName, avatar).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the organization avatar
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            /// <param name='avatar'>
            /// The image for an Organization avatar to upload.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrganizationResponse> UpdateAvatarAsync(this IOrganization operations, string orgName, string avatar = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateAvatarWithHttpMessagesAsync(orgName, avatar, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the uploaded organization avatar
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orgName'>
            /// The organization's name
            /// </param>
            public static OrganizationResponse DeleteAvatar(this IOrganization operations, string orgName)
            {
                return operations.DeleteAvatarAsync(orgName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the uploaded organization avatar
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
            public static async Task<OrganizationResponse> DeleteAvatarAsync(this IOrganization operations, string orgName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteAvatarWithHttpMessagesAsync(orgName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
