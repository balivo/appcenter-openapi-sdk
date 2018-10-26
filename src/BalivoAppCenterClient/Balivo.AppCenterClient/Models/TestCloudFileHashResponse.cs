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
    /// Test Cloud File Hash Response
    /// </summary>
    /// <remarks>
    /// Response message for single uploaded file hash
    /// </remarks>
    public partial class TestCloudFileHashResponse
    {
        /// <summary>
        /// Initializes a new instance of the TestCloudFileHashResponse class.
        /// </summary>
        public TestCloudFileHashResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestCloudFileHashResponse class.
        /// </summary>
        /// <param name="fileType">Type of the file. Possible values include:
        /// 'dsym-file', 'app-file', 'test-file'</param>
        /// <param name="checksum">SHA256 hash of the file</param>
        /// <param name="uploadStatus">Status of the upload</param>
        /// <param name="relativePath">Relative path of the file</param>
        public TestCloudFileHashResponse(string fileType, string checksum, TestCloudHashUploadStatus uploadStatus, string relativePath = default(string))
        {
            FileType = fileType;
            Checksum = checksum;
            RelativePath = relativePath;
            UploadStatus = uploadStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the file. Possible values include:
        /// 'dsym-file', 'app-file', 'test-file'
        /// </summary>
        [JsonProperty(PropertyName = "fileType")]
        public string FileType { get; set; }

        /// <summary>
        /// Gets or sets SHA256 hash of the file
        /// </summary>
        [JsonProperty(PropertyName = "checksum")]
        public string Checksum { get; set; }

        /// <summary>
        /// Gets or sets relative path of the file
        /// </summary>
        [JsonProperty(PropertyName = "relativePath")]
        public string RelativePath { get; set; }

        /// <summary>
        /// Gets or sets status of the upload
        /// </summary>
        [JsonProperty(PropertyName = "uploadStatus")]
        public TestCloudHashUploadStatus UploadStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileType");
            }
            if (Checksum == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Checksum");
            }
            if (UploadStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UploadStatus");
            }
            if (UploadStatus != null)
            {
                UploadStatus.Validate();
            }
        }
    }
}
