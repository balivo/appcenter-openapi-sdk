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
    /// a single frame of a stack trace
    /// </summary>
    public partial class StackFrame
    {
        /// <summary>
        /// Initializes a new instance of the StackFrame class.
        /// </summary>
        public StackFrame()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StackFrame class.
        /// </summary>
        /// <param name="appCode">this line isn't from any framework</param>
        /// <param name="codeRaw">Raw frame string</param>
        /// <param name="codeFormatted">Formatted frame string</param>
        /// <param name="address">address of the frame</param>
        /// <param name="className">name of the class</param>
        /// <param name="method">name of the method</param>
        /// <param name="classMethod">is a class method</param>
        /// <param name="file">name of the file</param>
        /// <param name="line">line number</param>
        /// <param name="frameworkName">Name of the framework</param>
        /// <param name="language">programming language of the frame. Possible
        /// values include: 'JavaScript', 'CSharp', 'Objective-C',
        /// 'Objective-Cpp', 'Cpp', 'C', 'Swift', 'Java', 'Unknown'</param>
        /// <param name="relevant">frame should be shown always</param>
        /// <param name="methodParams">parameters of the frames method</param>
        public StackFrame(bool appCode, string codeRaw, string codeFormatted, string address = default(string), string className = default(string), string method = default(string), bool? classMethod = default(bool?), string file = default(string), int? line = default(int?), string frameworkName = default(string), string language = default(string), bool? relevant = default(bool?), string methodParams = default(string))
        {
            Address = address;
            ClassName = className;
            Method = method;
            ClassMethod = classMethod;
            File = file;
            Line = line;
            AppCode = appCode;
            FrameworkName = frameworkName;
            CodeRaw = codeRaw;
            CodeFormatted = codeFormatted;
            Language = language;
            Relevant = relevant;
            MethodParams = methodParams;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets address of the frame
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets name of the class
        /// </summary>
        [JsonProperty(PropertyName = "class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets name of the method
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets is a class method
        /// </summary>
        [JsonProperty(PropertyName = "class_method")]
        public bool? ClassMethod { get; set; }

        /// <summary>
        /// Gets or sets name of the file
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public string File { get; set; }

        /// <summary>
        /// Gets or sets line number
        /// </summary>
        [JsonProperty(PropertyName = "line")]
        public int? Line { get; set; }

        /// <summary>
        /// Gets or sets this line isn't from any framework
        /// </summary>
        [JsonProperty(PropertyName = "app_code")]
        public bool AppCode { get; set; }

        /// <summary>
        /// Gets or sets name of the framework
        /// </summary>
        [JsonProperty(PropertyName = "framework_name")]
        public string FrameworkName { get; set; }

        /// <summary>
        /// Gets or sets raw frame string
        /// </summary>
        [JsonProperty(PropertyName = "code_raw")]
        public string CodeRaw { get; set; }

        /// <summary>
        /// Gets or sets formatted frame string
        /// </summary>
        [JsonProperty(PropertyName = "code_formatted")]
        public string CodeFormatted { get; set; }

        /// <summary>
        /// Gets or sets programming language of the frame. Possible values
        /// include: 'JavaScript', 'CSharp', 'Objective-C', 'Objective-Cpp',
        /// 'Cpp', 'C', 'Swift', 'Java', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets frame should be shown always
        /// </summary>
        [JsonProperty(PropertyName = "relevant")]
        public bool? Relevant { get; set; }

        /// <summary>
        /// Gets or sets parameters of the frames method
        /// </summary>
        [JsonProperty(PropertyName = "method_params")]
        public string MethodParams { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CodeRaw == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CodeRaw");
            }
            if (CodeFormatted == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CodeFormatted");
            }
        }
    }
}
