// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Notification send succeeded.
    /// </summary>
    public partial class NotificationSendSucceededResult
    {
        /// <summary>
        /// Initializes a new instance of the NotificationSendSucceededResult
        /// class.
        /// </summary>
        public NotificationSendSucceededResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationSendSucceededResult
        /// class.
        /// </summary>
        /// <param name="notificationId">The unique notification
        /// identifier.</param>
        public NotificationSendSucceededResult(string notificationId)
        {
            NotificationId = notificationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique notification identifier.
        /// </summary>
        [JsonProperty(PropertyName = "notification_id")]
        public string NotificationId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NotificationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NotificationId");
            }
        }
    }
}
