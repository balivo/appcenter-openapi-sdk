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

    /// <summary>
    /// parked crash
    /// </summary>
    public partial class ParkedCrash
    {
        /// <summary>
        /// Initializes a new instance of the ParkedCrash class.
        /// </summary>
        public ParkedCrash()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ParkedCrash class.
        /// </summary>
        /// <param name="appId">application id</param>
        /// <param name="appVer">application version</param>
        /// <param name="appBuild">application build</param>
        /// <param name="missingSymbols">list of missing symbols</param>
        /// <param name="crashId">id of the crash</param>
        /// <param name="sdkPlatform">platform of the sdk that sent
        /// crash</param>
        /// <param name="location">crash location</param>
        /// <param name="sdkWrapper">name of the sdk wrapper that sent
        /// crash</param>
        public ParkedCrash(string appId, string appVer, string appBuild, IList<MissingSymbol> missingSymbols, string crashId, string sdkPlatform, CrashLocation location, string sdkWrapper = default(string))
        {
            AppId = appId;
            AppVer = appVer;
            AppBuild = appBuild;
            MissingSymbols = missingSymbols;
            CrashId = crashId;
            SdkPlatform = sdkPlatform;
            SdkWrapper = sdkWrapper;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets application id
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets application version
        /// </summary>
        [JsonProperty(PropertyName = "app_ver")]
        public string AppVer { get; set; }

        /// <summary>
        /// Gets or sets application build
        /// </summary>
        [JsonProperty(PropertyName = "app_build")]
        public string AppBuild { get; set; }

        /// <summary>
        /// Gets or sets list of missing symbols
        /// </summary>
        [JsonProperty(PropertyName = "missing_symbols")]
        public IList<MissingSymbol> MissingSymbols { get; set; }

        /// <summary>
        /// Gets or sets id of the crash
        /// </summary>
        [JsonProperty(PropertyName = "crash_id")]
        public string CrashId { get; set; }

        /// <summary>
        /// Gets or sets platform of the sdk that sent crash
        /// </summary>
        [JsonProperty(PropertyName = "sdk_platform")]
        public string SdkPlatform { get; set; }

        /// <summary>
        /// Gets or sets name of the sdk wrapper that sent crash
        /// </summary>
        [JsonProperty(PropertyName = "sdk_wrapper")]
        public string SdkWrapper { get; set; }

        /// <summary>
        /// Gets or sets crash location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public CrashLocation Location { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppId");
            }
            if (AppVer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppVer");
            }
            if (AppBuild == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppBuild");
            }
            if (MissingSymbols == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MissingSymbols");
            }
            if (CrashId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CrashId");
            }
            if (SdkPlatform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SdkPlatform");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (MissingSymbols != null)
            {
                foreach (var element in MissingSymbols)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Location != null)
            {
                Location.Validate();
            }
        }
    }
}
