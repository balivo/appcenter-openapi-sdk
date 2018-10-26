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
    /// Responses for requests that detect billing plans change type
    /// </summary>
    public partial class BillingPlansChangeTypeResponse
    {
        /// <summary>
        /// Initializes a new instance of the BillingPlansChangeTypeResponse
        /// class.
        /// </summary>
        public BillingPlansChangeTypeResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingPlansChangeTypeResponse
        /// class.
        /// </summary>
        /// <param name="result">Possible values include: 'NoChange',
        /// 'Downgrade', 'Upgrade'</param>
        public BillingPlansChangeTypeResponse(string result = default(string))
        {
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'NoChange', 'Downgrade',
        /// 'Upgrade'
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

    }
}
