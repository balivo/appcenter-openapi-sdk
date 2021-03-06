// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AndroidProject
    {
        /// <summary>
        /// Initializes a new instance of the AndroidProject class.
        /// </summary>
        public AndroidProject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AndroidProject class.
        /// </summary>
        /// <param name="androidModules">Android Gradle modules</param>
        /// <param name="gradleWrapperPath">The path of the Gradle
        /// wrapper</param>
        public AndroidProject(IList<AndroidModule> androidModules, string gradleWrapperPath = default(string))
        {
            AndroidModules = androidModules;
            GradleWrapperPath = gradleWrapperPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets android Gradle modules
        /// </summary>
        [JsonProperty(PropertyName = "androidModules")]
        public IList<AndroidModule> AndroidModules { get; set; }

        /// <summary>
        /// Gets or sets the path of the Gradle wrapper
        /// </summary>
        [JsonProperty(PropertyName = "gradleWrapperPath")]
        public string GradleWrapperPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AndroidModules == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AndroidModules");
            }
            if (AndroidModules != null)
            {
                foreach (var element in AndroidModules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
