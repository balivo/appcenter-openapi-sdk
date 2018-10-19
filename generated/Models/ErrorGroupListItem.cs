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

    public partial class ErrorGroupListItem : ErrorGroupState
    {
        /// <summary>
        /// Initializes a new instance of the ErrorGroupListItem class.
        /// </summary>
        public ErrorGroupListItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorGroupListItem class.
        /// </summary>
        /// <param name="state">Possible values include: 'open', 'closed',
        /// 'ignored'</param>
        public ErrorGroupListItem(string state, string errorGroupId, string appVersion, long count, long deviceCount, System.DateTime lastOccurrence, string annotation = default(string), string appBuild = default(string), string exceptionType = default(string), string exceptionMessage = default(string), string exceptionClassName = default(string), bool? exceptionClassMethod = default(bool?), string exceptionMethod = default(string), bool? exceptionAppCode = default(bool?), string exceptionFile = default(string), string exceptionLine = default(string), string codeRaw = default(string))
            : base(state, annotation)
        {
            ErrorGroupId = errorGroupId;
            AppVersion = appVersion;
            AppBuild = appBuild;
            Count = count;
            DeviceCount = deviceCount;
            LastOccurrence = lastOccurrence;
            ExceptionType = exceptionType;
            ExceptionMessage = exceptionMessage;
            ExceptionClassName = exceptionClassName;
            ExceptionClassMethod = exceptionClassMethod;
            ExceptionMethod = exceptionMethod;
            ExceptionAppCode = exceptionAppCode;
            ExceptionFile = exceptionFile;
            ExceptionLine = exceptionLine;
            CodeRaw = codeRaw;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorGroupId")]
        public string ErrorGroupId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appVersion")]
        public string AppVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appBuild")]
        public string AppBuild { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceCount")]
        public long DeviceCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastOccurrence")]
        public System.DateTime LastOccurrence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionType")]
        public string ExceptionType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionMessage")]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionClassName")]
        public string ExceptionClassName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionClassMethod")]
        public bool? ExceptionClassMethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionMethod")]
        public string ExceptionMethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionAppCode")]
        public bool? ExceptionAppCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionFile")]
        public string ExceptionFile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptionLine")]
        public string ExceptionLine { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "codeRaw")]
        public string CodeRaw { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ErrorGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ErrorGroupId");
            }
            if (AppVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppVersion");
            }
        }
    }
}
