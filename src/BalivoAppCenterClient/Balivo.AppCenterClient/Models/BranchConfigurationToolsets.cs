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
    /// The branch build configuration for each toolset
    /// </summary>
    public partial class BranchConfigurationToolsets
    {
        /// <summary>
        /// Initializes a new instance of the BranchConfigurationToolsets
        /// class.
        /// </summary>
        public BranchConfigurationToolsets()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BranchConfigurationToolsets
        /// class.
        /// </summary>
        public BranchConfigurationToolsets(XcodeBranchConfigurationProperties xcode = default(XcodeBranchConfigurationProperties), JavaScriptBranchConfigurationProperties javascript = default(JavaScriptBranchConfigurationProperties), XamarinBranchConfigurationProperties xamarin = default(XamarinBranchConfigurationProperties), AndroidBranchConfigurationProperties android = default(AndroidBranchConfigurationProperties))
        {
            Xcode = xcode;
            Javascript = javascript;
            Xamarin = xamarin;
            Android = android;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "xcode")]
        public XcodeBranchConfigurationProperties Xcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "javascript")]
        public JavaScriptBranchConfigurationProperties Javascript { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "xamarin")]
        public XamarinBranchConfigurationProperties Xamarin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "android")]
        public AndroidBranchConfigurationProperties Android { get; set; }

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
        }
    }
}