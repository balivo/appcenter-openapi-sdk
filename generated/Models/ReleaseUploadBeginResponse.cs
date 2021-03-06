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
    /// A response containing information pertaining to starting a release
    /// upload process
    /// </summary>
    public partial class ReleaseUploadBeginResponse
    {
        /// <summary>
        /// Initializes a new instance of the ReleaseUploadBeginResponse class.
        /// </summary>
        public ReleaseUploadBeginResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReleaseUploadBeginResponse class.
        /// </summary>
        /// <param name="uploadId">The ID for the current upload</param>
        /// <param name="uploadUrl">The URL where the client needs to upload
        /// the release to</param>
        /// <param name="assetId">The ID for the current upload, reserved for
        /// future use</param>
        /// <param name="assetDomain">The URL for the current upload, reserved
        /// for future use</param>
        /// <param name="assetToken">The token for the current upload, reserved
        /// for future use</param>
        public ReleaseUploadBeginResponse(string uploadId, string uploadUrl, string assetId = default(string), string assetDomain = default(string), string assetToken = default(string))
        {
            UploadId = uploadId;
            UploadUrl = uploadUrl;
            AssetId = assetId;
            AssetDomain = assetDomain;
            AssetToken = assetToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID for the current upload
        /// </summary>
        [JsonProperty(PropertyName = "upload_id")]
        public string UploadId { get; set; }

        /// <summary>
        /// Gets or sets the URL where the client needs to upload the release
        /// to
        /// </summary>
        [JsonProperty(PropertyName = "upload_url")]
        public string UploadUrl { get; set; }

        /// <summary>
        /// Gets or sets the ID for the current upload, reserved for future use
        /// </summary>
        [JsonProperty(PropertyName = "asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or sets the URL for the current upload, reserved for future
        /// use
        /// </summary>
        [JsonProperty(PropertyName = "asset_domain")]
        public string AssetDomain { get; set; }

        /// <summary>
        /// Gets or sets the token for the current upload, reserved for future
        /// use
        /// </summary>
        [JsonProperty(PropertyName = "asset_token")]
        public string AssetToken { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UploadId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UploadId");
            }
            if (UploadUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UploadUrl");
            }
        }
    }
}
