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
    /// RetrieveUserLicenseInfoResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveUserLicenseInfoResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveUserLicenseInfoResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveUserLicenseInfoResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveUserLicenseInfoResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveUserLicenseInfoResponse(MicrosoftDynamicsCRMUserLicenseInfo licenseInfo = default(MicrosoftDynamicsCRMUserLicenseInfo))
        {
            LicenseInfo = licenseInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "licenseInfo")]
        public MicrosoftDynamicsCRMUserLicenseInfo LicenseInfo { get; set; }

    }
}
