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

    /// <summary>
    /// Test Run State
    /// </summary>
    /// <remarks>
    /// Current status of a test run
    /// </remarks>
    public partial class TestRunState
    {
        /// <summary>
        /// Initializes a new instance of the TestRunState class.
        /// </summary>
        public TestRunState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestRunState class.
        /// </summary>
        /// <param name="message">Multi-line message that describes the
        /// status</param>
        /// <param name="waitTime">Time (in seconds) that the client should
        /// wait for before checking the status again</param>
        /// <param name="exitCode">The exit code that the client should use
        /// when exiting. Used for indicating status to the caller of the
        /// client.
        /// 0: test run completes with no failing tests
        /// 1: test run completes with at least one failing test
        /// 2: test run failed to complete. Status for test run is unknown
        /// </param>
        public TestRunState(IList<string> message = default(IList<string>), int? waitTime = default(int?), int? exitCode = default(int?))
        {
            Message = message;
            WaitTime = waitTime;
            ExitCode = exitCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets multi-line message that describes the status
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public IList<string> Message { get; set; }

        /// <summary>
        /// Gets or sets time (in seconds) that the client should wait for
        /// before checking the status again
        /// </summary>
        [JsonProperty(PropertyName = "wait_time")]
        public int? WaitTime { get; set; }

        /// <summary>
        /// Gets or sets the exit code that the client should use when exiting.
        /// Used for indicating status to the caller of the client.
        /// 0: test run completes with no failing tests
        /// 1: test run completes with at least one failing test
        /// 2: test run failed to complete. Status for test run is unknown
        ///
        /// </summary>
        [JsonProperty(PropertyName = "exit_code")]
        public int? ExitCode { get; set; }

    }
}
