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
    /// RetrieveAttributeChangeHistoryResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveAttributeChangeHistoryResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveAttributeChangeHistoryResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveAttributeChangeHistoryResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveAttributeChangeHistoryResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveAttributeChangeHistoryResponse(MicrosoftDynamicsCRMAuditDetailCollection auditDetailCollection = default(MicrosoftDynamicsCRMAuditDetailCollection))
        {
            AuditDetailCollection = auditDetailCollection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AuditDetailCollection")]
        public MicrosoftDynamicsCRMAuditDetailCollection AuditDetailCollection { get; set; }

    }
}
