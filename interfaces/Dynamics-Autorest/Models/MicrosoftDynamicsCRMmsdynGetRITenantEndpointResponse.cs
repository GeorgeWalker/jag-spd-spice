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
    /// msdyn_GetRITenantEndpointResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynGetRITenantEndpointResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynGetRITenantEndpointResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynGetRITenantEndpointResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynGetRITenantEndpointResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynGetRITenantEndpointResponse(string tenantInfo = default(string))
        {
            TenantInfo = tenantInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TenantInfo")]
        public string TenantInfo { get; set; }

    }
}
