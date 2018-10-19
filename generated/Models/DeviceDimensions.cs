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
    /// Physical device dimensions
    /// </summary>
    public partial class DeviceDimensions
    {
        /// <summary>
        /// Initializes a new instance of the DeviceDimensions class.
        /// </summary>
        public DeviceDimensions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceDimensions class.
        /// </summary>
        public DeviceDimensions(object depth = default(object), object height = default(object), object width = default(object))
        {
            Depth = depth;
            Height = height;
            Width = width;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "depth")]
        public object Depth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public object Height { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public object Width { get; set; }

    }
}
