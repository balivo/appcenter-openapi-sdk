// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DistributionGroupAadGroupsDeleteResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupAadGroupsDeleteResponse class.
        /// </summary>
        public DistributionGroupAadGroupsDeleteResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DistributionGroupAadGroupsDeleteResponse class.
        /// </summary>
        /// <param name="status">The status code of the result</param>
        /// <param name="code">The code of the result</param>
        /// <param name="message">The message of the result</param>
        /// <param name="aadGroupId">The aad id of the group</param>
        public DistributionGroupAadGroupsDeleteResponse(int status, string code = default(string), int? message = default(int?), System.Guid? aadGroupId = default(System.Guid?))
        {
            Code = code;
            Message = message;
            Status = status;
            AadGroupId = aadGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the code of the result
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the message of the result
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public int? Message { get; set; }

        /// <summary>
        /// Gets or sets the status code of the result
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the aad id of the group
        /// </summary>
        [JsonProperty(PropertyName = "aad_group_id")]
        public System.Guid? AadGroupId { get; set; }

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