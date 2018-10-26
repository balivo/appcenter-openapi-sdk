// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DataSubjectRightResponse
    {
        /// <summary>
        /// Initializes a new instance of the DataSubjectRightResponse class.
        /// </summary>
        public DataSubjectRightResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataSubjectRightResponse class.
        /// </summary>
        /// <param name="token">Unique request identifier</param>
        /// <param name="createdAt">ISO 8601 format timestamp of when request
        /// was created.</param>
        public DataSubjectRightResponse(System.Guid token, System.DateTime createdAt)
        {
            Token = token;
            CreatedAt = createdAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique request identifier
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public System.Guid Token { get; set; }

        /// <summary>
        /// Gets or sets ISO 8601 format timestamp of when request was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
