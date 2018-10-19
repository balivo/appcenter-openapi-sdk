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
    /// A request containing information pertaining to completing a symbol
    /// upload process
    /// </summary>
    public partial class SymbolUploadEndRequest
    {
        /// <summary>
        /// Initializes a new instance of the SymbolUploadEndRequest class.
        /// </summary>
        public SymbolUploadEndRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SymbolUploadEndRequest class.
        /// </summary>
        /// <param name="status">The desired operation for the symbol upload.
        /// Possible values include: 'committed', 'aborted'</param>
        public SymbolUploadEndRequest(string status)
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the desired operation for the symbol upload. Possible
        /// values include: 'committed', 'aborted'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}
