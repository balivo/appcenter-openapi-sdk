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
    /// Boolean property.
    /// </summary>
    [Newtonsoft.Json.JsonObject("boolean")]
    public partial class BooleanPropertyDiagnostics : CustomPropertyDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the BooleanPropertyDiagnostics class.
        /// </summary>
        public BooleanPropertyDiagnostics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BooleanPropertyDiagnostics class.
        /// </summary>
        /// <param name="value">Boolean property value.</param>
        public BooleanPropertyDiagnostics(string name, bool value)
            : base(name)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets boolean property value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public bool Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
