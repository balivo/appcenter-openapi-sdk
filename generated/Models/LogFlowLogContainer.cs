// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LogFlowLogContainer
    {
        /// <summary>
        /// Initializes a new instance of the LogFlowLogContainer class.
        /// </summary>
        public LogFlowLogContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogFlowLogContainer class.
        /// </summary>
        /// <param name="logs">the list of logs</param>
        /// <param name="exceededMaxLimit">indicates if the number of available
        /// logs are more than the max allowed return limit(100).</param>
        /// <param name="lastReceivedLogTimestamp">the timestamp of the last
        /// log received. This value can be used as the start time parameter in
        /// the consecutive API call.</param>
        public LogFlowLogContainer(IList<LogFlowLog> logs, bool? exceededMaxLimit = default(bool?), System.DateTime? lastReceivedLogTimestamp = default(System.DateTime?))
        {
            ExceededMaxLimit = exceededMaxLimit;
            LastReceivedLogTimestamp = lastReceivedLogTimestamp;
            Logs = logs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates if the number of available logs are more
        /// than the max allowed return limit(100).
        /// </summary>
        [JsonProperty(PropertyName = "exceeded_max_limit")]
        public bool? ExceededMaxLimit { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the last log received. This value can
        /// be used as the start time parameter in the consecutive API call.
        /// </summary>
        [JsonProperty(PropertyName = "last_received_log_timestamp")]
        public System.DateTime? LastReceivedLogTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the list of logs
        /// </summary>
        [JsonProperty(PropertyName = "logs")]
        public IList<LogFlowLog> Logs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Logs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Logs");
            }
            if (Logs != null)
            {
                if (Logs.Count < 0)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Logs", 0);
                }
                foreach (var element in Logs)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
