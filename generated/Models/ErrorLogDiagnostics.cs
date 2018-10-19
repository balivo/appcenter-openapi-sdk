// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error log.
    /// </summary>
    [Newtonsoft.Json.JsonObject("error")]
    public partial class ErrorLogDiagnostics : LogDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the ErrorLogDiagnostics class.
        /// </summary>
        public ErrorLogDiagnostics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorLogDiagnostics class.
        /// </summary>
        /// <param name="timestamp">Log creation timestamp.
        /// </param>
        /// <param name="installId">Install ID.
        /// </param>
        /// <param name="sessionId">Session ID.
        /// </param>
        /// <param name="id">Error identifier.</param>
        /// <param name="appLaunchToffset">Corresponds to the number of
        /// milliseconds elapsed between the time the error occurred and the
        /// app was launched.
        /// </param>
        public ErrorLogDiagnostics(System.DateTime timestamp, System.Guid installId, DeviceDiagnostics device, System.Guid sessionId, System.Guid id, long? appLaunchToffset = default(long?))
            : base(timestamp, installId, device)
        {
            SessionId = sessionId;
            Id = id;
            AppLaunchToffset = appLaunchToffset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets session ID.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        public System.Guid SessionId { get; set; }

        /// <summary>
        /// Gets or sets error identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets corresponds to the number of milliseconds elapsed
        /// between the time the error occurred and the app was launched.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "app_launch_toffset")]
        public long? AppLaunchToffset { get; set; }

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
