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
    /// AddUserToRecordTeamResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMAddUserToRecordTeamResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAddUserToRecordTeamResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMAddUserToRecordTeamResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAddUserToRecordTeamResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMAddUserToRecordTeamResponse(string accessTeamId = default(string))
        {
            AccessTeamId = accessTeamId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessTeamId")]
        public string AccessTeamId { get; set; }

    }
}
