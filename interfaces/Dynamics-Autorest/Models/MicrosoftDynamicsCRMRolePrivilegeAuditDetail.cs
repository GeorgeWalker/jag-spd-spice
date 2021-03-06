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
    /// RolePrivilegeAuditDetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMRolePrivilegeAuditDetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRolePrivilegeAuditDetail class.
        /// </summary>
        public MicrosoftDynamicsCRMRolePrivilegeAuditDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRolePrivilegeAuditDetail class.
        /// </summary>
        public MicrosoftDynamicsCRMRolePrivilegeAuditDetail(IList<MicrosoftDynamicsCRMRolePrivilege> oldRolePrivileges = default(IList<MicrosoftDynamicsCRMRolePrivilege>), IList<MicrosoftDynamicsCRMRolePrivilege> newRolePrivileges = default(IList<MicrosoftDynamicsCRMRolePrivilege>), IList<string> invalidNewPrivileges = default(IList<string>), object auditRecord = default(object))
        {
            OldRolePrivileges = oldRolePrivileges;
            NewRolePrivileges = newRolePrivileges;
            InvalidNewPrivileges = invalidNewPrivileges;
            AuditRecord = auditRecord;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OldRolePrivileges")]
        public IList<MicrosoftDynamicsCRMRolePrivilege> OldRolePrivileges { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NewRolePrivileges")]
        public IList<MicrosoftDynamicsCRMRolePrivilege> NewRolePrivileges { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvalidNewPrivileges")]
        public IList<string> InvalidNewPrivileges { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AuditRecord")]
        public object AuditRecord { get; set; }

    }
}
