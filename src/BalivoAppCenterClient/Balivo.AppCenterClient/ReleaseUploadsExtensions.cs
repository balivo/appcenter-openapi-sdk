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
    /// Extension methods for ReleaseUploads.
    /// </summary>
    public static partial class ReleaseUploadsExtensions
    {
            /// <summary>
            /// Commits or aborts the upload process for a release for the specified
            /// application
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uploadId'>
            /// The ID of the upload
            /// </param>
            /// <param name='body'>
            /// The release information
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static ReleaseUploadEndResponse Complete(this IReleaseUploads operations, string uploadId, ReleaseUploadEndRequest body, string ownerName, string appName)
            {
                return operations.CompleteAsync(uploadId, body, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Commits or aborts the upload process for a release for the specified
            /// application
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uploadId'>
            /// The ID of the upload
            /// </param>
            /// <param name='body'>
            /// The release information
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReleaseUploadEndResponse> CompleteAsync(this IReleaseUploads operations, string uploadId, ReleaseUploadEndRequest body, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CompleteWithHttpMessagesAsync(uploadId, body, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Begins the upload process for a new release for the specified application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The release information
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static ReleaseUploadBeginResponse Create(this IReleaseUploads operations, ReleaseUploadBeginRequest body, string ownerName, string appName)
            {
                return operations.CreateAsync(body, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Begins the upload process for a new release for the specified application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The release information
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReleaseUploadBeginResponse> CreateAsync(this IReleaseUploads operations, ReleaseUploadBeginRequest body, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
