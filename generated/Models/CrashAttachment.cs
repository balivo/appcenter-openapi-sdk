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

    public partial class CrashAttachment
    {
        /// <summary>
        /// Initializes a new instance of the CrashAttachment class.
        /// </summary>
        public CrashAttachment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrashAttachment class.
        /// </summary>
        public CrashAttachment(string appId, string attachmentId, string crashId, string blobLocation, string contentType, string fileName, System.DateTime createdTime, double size)
        {
            AppId = appId;
            AttachmentId = attachmentId;
            CrashId = crashId;
            BlobLocation = blobLocation;
            ContentType = contentType;
            FileName = fileName;
            CreatedTime = createdTime;
            Size = size;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachment_id")]
        public string AttachmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_id")]
        public string CrashId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "blob_location")]
        public string BlobLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created_time")]
        public System.DateTime CreatedTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public double Size { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppId");
            }
            if (AttachmentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AttachmentId");
            }
            if (CrashId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CrashId");
            }
            if (BlobLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BlobLocation");
            }
            if (ContentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentType");
            }
            if (FileName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileName");
            }
        }
    }
}
