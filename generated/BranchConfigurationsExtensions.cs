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
    /// Extension methods for BranchConfigurations.
    /// </summary>
    public static partial class BranchConfigurationsExtensions
    {
            /// <summary>
            /// Gets the branch configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='branch'>
            /// The branch name
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static BranchConfiguration Get(this IBranchConfigurations operations, string branch, string ownerName, string appName)
            {
                return operations.GetAsync(branch, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the branch configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='branch'>
            /// The branch name
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
            public static async Task<BranchConfiguration> GetAsync(this IBranchConfigurations operations, string branch, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(branch, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Configures the branch for build
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='branch'>
            /// The branch name
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static BranchConfiguration Create(this IBranchConfigurations operations, string branch, string ownerName, string appName)
            {
                return operations.CreateAsync(branch, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Configures the branch for build
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='branch'>
            /// The branch name
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
            public static async Task<BranchConfiguration> CreateAsync(this IBranchConfigurations operations, string branch, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(branch, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Reconfigures the branch for build
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='branch'>
            /// The branch name
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static BranchConfiguration Update(this IBranchConfigurations operations, string branch, string ownerName, string appName)
            {
                return operations.UpdateAsync(branch, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reconfigures the branch for build
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='branch'>
            /// The branch name
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
            public static async Task<BranchConfiguration> UpdateAsync(this IBranchConfigurations operations, string branch, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(branch, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the branch build configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='branch'>
            /// The branch name
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static SuccessResponse Delete(this IBranchConfigurations operations, string branch, string ownerName, string appName)
            {
                return operations.DeleteAsync(branch, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the branch build configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='branch'>
            /// The branch name
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
            public static async Task<SuccessResponse> DeleteAsync(this IBranchConfigurations operations, string branch, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(branch, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
