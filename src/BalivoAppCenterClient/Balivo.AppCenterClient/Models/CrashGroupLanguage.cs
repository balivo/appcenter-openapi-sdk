// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CrashGroupLanguage
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroupLanguage class.
        /// </summary>
        public CrashGroupLanguage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrashGroupLanguage class.
        /// </summary>
        /// <param name="languageName">language name</param>
        /// <param name="crashCount">count of languages</param>
        public CrashGroupLanguage(string languageName = default(string), long? crashCount = default(long?))
        {
            LanguageName = languageName;
            CrashCount = crashCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets language name
        /// </summary>
        [JsonProperty(PropertyName = "language_name")]
        public string LanguageName { get; set; }

        /// <summary>
        /// Gets or sets count of languages
        /// </summary>
        [JsonProperty(PropertyName = "crash_count")]
        public long? CrashCount { get; set; }

    }
}