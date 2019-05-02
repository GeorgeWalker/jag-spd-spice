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
    /// sdkmessagefilter
    /// </summary>
    public partial class MicrosoftDynamicsCRMsdkmessagefilter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessagefilter class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessagefilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessagefilter class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessagefilter(bool? ismanaged = default(bool?), string secondaryobjecttypecode = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string sdkmessagefilterid = default(string), string _modifiedonbehalfbyValue = default(string), int? customizationlevel = default(int?), string _sdkmessageidValue = default(string), bool? isvisible = default(bool?), bool? workflowsdkstepenabled = default(bool?), string primaryobjecttypecode = default(string), string introducedversion = default(string), string sdkmessagefilteridunique = default(string), long? versionnumber = default(long?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), int? componentstate = default(int?), string _modifiedbyValue = default(string), int? restrictionlevel = default(int?), string _createdbyValue = default(string), string solutionid = default(string), bool? iscustomprocessingstepallowed = default(bool?), int? availability = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> sdkmessagefilteridSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsdkmessage sdkmessageid = default(MicrosoftDynamicsCRMsdkmessage), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Ismanaged = ismanaged;
            Secondaryobjecttypecode = secondaryobjecttypecode;
            Overwritetime = overwritetime;
            Sdkmessagefilterid = sdkmessagefilterid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Customizationlevel = customizationlevel;
            this._sdkmessageidValue = _sdkmessageidValue;
            Isvisible = isvisible;
            Workflowsdkstepenabled = workflowsdkstepenabled;
            Primaryobjecttypecode = primaryobjecttypecode;
            Introducedversion = introducedversion;
            Sdkmessagefilteridunique = sdkmessagefilteridunique;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Componentstate = componentstate;
            this._modifiedbyValue = _modifiedbyValue;
            Restrictionlevel = restrictionlevel;
            this._createdbyValue = _createdbyValue;
            Solutionid = solutionid;
            Iscustomprocessingstepallowed = iscustomprocessingstepallowed;
            Availability = availability;
            Modifiedon = modifiedon;
            Organizationid = organizationid;
            SdkmessagefilteridSdkmessageprocessingstep = sdkmessagefilteridSdkmessageprocessingstep;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Sdkmessageid = sdkmessageid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secondaryobjecttypecode")]
        public string Secondaryobjecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessagefilterid")]
        public string Sdkmessagefilterid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessageid_value")]
        public string _sdkmessageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isvisible")]
        public bool? Isvisible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowsdkstepenabled")]
        public bool? Workflowsdkstepenabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryobjecttypecode")]
        public string Primaryobjecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessagefilteridunique")]
        public string Sdkmessagefilteridunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "restrictionlevel")]
        public int? Restrictionlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomprocessingstepallowed")]
        public bool? Iscustomprocessingstepallowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "availability")]
        public int? Availability { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessagefilterid_sdkmessageprocessingstep")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> SdkmessagefilteridSdkmessageprocessingstep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid")]
        public MicrosoftDynamicsCRMsdkmessage Sdkmessageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
