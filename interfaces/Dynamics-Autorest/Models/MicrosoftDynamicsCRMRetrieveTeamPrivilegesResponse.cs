// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// RetrieveTeamPrivilegesResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveTeamPrivilegesResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveTeamPrivilegesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveTeamPrivilegesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveTeamPrivilegesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveTeamPrivilegesResponse(IList<MicrosoftDynamicsCRMRolePrivilege> rolePrivileges = default(IList<MicrosoftDynamicsCRMRolePrivilege>))
        {
            RolePrivileges = rolePrivileges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RolePrivileges")]
        public IList<MicrosoftDynamicsCRMRolePrivilege> RolePrivileges { get; set; }

    }
}
