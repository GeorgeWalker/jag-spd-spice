// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RetrieveVersionResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveVersionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveVersionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveVersionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveVersionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveVersionResponse(string version = default(string))
        {
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; set; }

    }
}
