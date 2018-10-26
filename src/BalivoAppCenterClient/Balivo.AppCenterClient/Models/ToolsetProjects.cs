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
    /// A collection of projects for each type of toolset
    /// </summary>
    public partial class ToolsetProjects
    {
        /// <summary>
        /// Initializes a new instance of the ToolsetProjects class.
        /// </summary>
        public ToolsetProjects()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ToolsetProjects class.
        /// </summary>
        /// <param name="commit">The commit hash of the analyzed commit</param>
        public ToolsetProjects(string commit = default(string), XcodeToolset xcode = default(XcodeToolset), JavaScriptToolset javascript = default(JavaScriptToolset), XamarinToolset xamarin = default(XamarinToolset), AndroidProject android = default(AndroidProject), IDictionary<string, ToolsetProject> buildscripts = default(IDictionary<string, ToolsetProject>), UWPToolset uwp = default(UWPToolset), TestCloudToolset testcloud = default(TestCloudToolset))
        {
            Commit = commit;
            Xcode = xcode;
            Javascript = javascript;
            Xamarin = xamarin;
            Android = android;
            Buildscripts = buildscripts;
            Uwp = uwp;
            Testcloud = testcloud;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the commit hash of the analyzed commit
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public string Commit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "xcode")]
        public XcodeToolset Xcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "javascript")]
        public JavaScriptToolset Javascript { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "xamarin")]
        public XamarinToolset Xamarin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "android")]
        public AndroidProject Android { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "buildscripts")]
        public IDictionary<string, ToolsetProject> Buildscripts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uwp")]
        public UWPToolset Uwp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testcloud")]
        public TestCloudToolset Testcloud { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Xcode != null)
            {
                Xcode.Validate();
            }
            if (Javascript != null)
            {
                Javascript.Validate();
            }
            if (Xamarin != null)
            {
                Xamarin.Validate();
            }
            if (Android != null)
            {
                Android.Validate();
            }
            if (Uwp != null)
            {
                Uwp.Validate();
            }
            if (Testcloud != null)
            {
                Testcloud.Validate();
            }
        }
    }
}
