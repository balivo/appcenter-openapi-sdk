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

    public partial class DeleteReleasesContainer
    {
        /// <summary>
        /// Initializes a new instance of the DeleteReleasesContainer class.
        /// </summary>
        public DeleteReleasesContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteReleasesContainer class.
        /// </summary>
        public DeleteReleasesContainer(IList<Release> releases)
        {
            Releases = releases;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "releases")]
        public IList<Release> Releases { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Releases == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Releases");
            }
            if (Releases != null)
            {
                if (Releases.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Releases", 1);
                }
                foreach (var element in Releases)
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