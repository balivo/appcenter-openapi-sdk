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
    /// Extension methods for DistibutionReleases.
    /// </summary>
    public static partial class DistibutionReleasesExtensions
    {
            /// <summary>
            /// Notify download(s) for the provided distribution release(s).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the app owner
            /// </param>
            /// <param name='appName'>
            /// The name of the app
            /// </param>
            /// <param name='body'>
            /// The install analytics request payload
            /// </param>
            public static void InstallAnalytics(this IDistibutionReleases operations, string ownerName, string appName, AnalyticsReleasesResponse body)
            {
                operations.InstallAnalyticsAsync(ownerName, appName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Notify download(s) for the provided distribution release(s).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the app owner
            /// </param>
            /// <param name='appName'>
            /// The name of the app
            /// </param>
            /// <param name='body'>
            /// The install analytics request payload
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task InstallAnalyticsAsync(this IDistibutionReleases operations, string ownerName, string appName, AnalyticsReleasesResponse body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.InstallAnalyticsWithHttpMessagesAsync(ownerName, appName, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
