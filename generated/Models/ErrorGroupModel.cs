// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorGroupModel
    {
        /// <summary>
        /// Initializes a new instance of the ErrorGroupModel class.
        /// </summary>
        public ErrorGroupModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorGroupModel class.
        /// </summary>
        /// <param name="modelName">model name</param>
        /// <param name="modelCode">model code</param>
        /// <param name="errorCount">count of errors in a model</param>
        public ErrorGroupModel(string modelName = default(string), string modelCode = default(string), long? errorCount = default(long?))
        {
            ModelName = modelName;
            ModelCode = modelCode;
            ErrorCount = errorCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets model name
        /// </summary>
        [JsonProperty(PropertyName = "modelName")]
        public string ModelName { get; set; }

        /// <summary>
        /// Gets or sets model code
        /// </summary>
        [JsonProperty(PropertyName = "modelCode")]
        public string ModelCode { get; set; }

        /// <summary>
        /// Gets or sets count of errors in a model
        /// </summary>
        [JsonProperty(PropertyName = "errorCount")]
        public long? ErrorCount { get; set; }

    }
}
