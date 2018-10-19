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
    /// Configuration for export to Blob Storage with blob format
    /// </summary>
    [Newtonsoft.Json.JsonObject("export_blob_configuration")]
    public partial class ExportBlobConfiguration : ExportConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the ExportBlobConfiguration class.
        /// </summary>
        public ExportBlobConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportBlobConfiguration class.
        /// </summary>
        /// <param name="resourceName">The resource name on azure</param>
        /// <param name="resourceGroup">The resource group name on
        /// azure</param>
        /// <param name="blobPathFormatKind">The path to the blob when enum set
        /// to 'WithoutAppId' is 'year/month/day/hour/minute' and when set to
        /// 'WithAppId' is 'appId/year/month/day/hour/minute'. Possible values
        /// include: 'WithoutAppId', 'WithAppId'</param>
        public ExportBlobConfiguration(IList<ExportEntity?> exportEntities = default(IList<ExportEntity?>), string resourceName = default(string), string resourceGroup = default(string), BlobPathFormatKind? blobPathFormatKind = default(BlobPathFormatKind?))
            : base(exportEntities, resourceName, resourceGroup)
        {
            BlobPathFormatKind = blobPathFormatKind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path to the blob when enum set to 'WithoutAppId'
        /// is 'year/month/day/hour/minute' and when set to 'WithAppId' is
        /// 'appId/year/month/day/hour/minute'. Possible values include:
        /// 'WithoutAppId', 'WithAppId'
        /// </summary>
        [JsonProperty(PropertyName = "blob_path_format_kind")]
        public BlobPathFormatKind? BlobPathFormatKind { get; set; }

    }
}
