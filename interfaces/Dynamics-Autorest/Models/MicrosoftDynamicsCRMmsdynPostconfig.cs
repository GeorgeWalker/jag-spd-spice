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
    /// msdyn_postconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynPostconfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPostconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPostconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPostconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPostconfig(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), bool? msdynConfigurewall = default(bool?), string msdynFollowingviewid2 = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? msdynOtc = default(int?), string msdynStatus = default(string), int? importsequencenumber = default(int?), string msdynEntitydisplayname = default(string), string msdynPostconfigid = default(string), int? timezoneruleversionnumber = default(int?), int? statuscode = default(int?), int? utcconversiontimezonecode = default(int?), int? statecode = default(int?), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), string msdynEntityname = default(string), string _createdonbehalfbyValue = default(string), long? versionnumber = default(long?), string msdynFollowingviewid = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> msdynPostconfigSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynPostconfigAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynPostconfigMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynPostconfigProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynPostconfigBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynPostconfigPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMmsdynPostruleconfig> msdynPostconfigMsdynPostruleconfig = default(IList<MicrosoftDynamicsCRMmsdynPostruleconfig>), IList<MicrosoftDynamicsCRMmsdynWallsavedquery> msdynPostconfigWallsavedquery = default(IList<MicrosoftDynamicsCRMmsdynWallsavedquery>))
        {
            Overriddencreatedon = overriddencreatedon;
            this._modifiedbyValue = _modifiedbyValue;
            MsdynConfigurewall = msdynConfigurewall;
            MsdynFollowingviewid2 = msdynFollowingviewid2;
            Modifiedon = modifiedon;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            MsdynOtc = msdynOtc;
            MsdynStatus = msdynStatus;
            Importsequencenumber = importsequencenumber;
            MsdynEntitydisplayname = msdynEntitydisplayname;
            MsdynPostconfigid = msdynPostconfigid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statuscode = statuscode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statecode = statecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            MsdynEntityname = msdynEntityname;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            MsdynFollowingviewid = msdynFollowingviewid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            MsdynPostconfigSyncErrors = msdynPostconfigSyncErrors;
            MsdynPostconfigAsyncOperations = msdynPostconfigAsyncOperations;
            MsdynPostconfigMailboxTrackingFolders = msdynPostconfigMailboxTrackingFolders;
            MsdynPostconfigProcessSession = msdynPostconfigProcessSession;
            MsdynPostconfigBulkDeleteFailures = msdynPostconfigBulkDeleteFailures;
            MsdynPostconfigPrincipalObjectAttributeAccesses = msdynPostconfigPrincipalObjectAttributeAccesses;
            MsdynPostconfigMsdynPostruleconfig = msdynPostconfigMsdynPostruleconfig;
            MsdynPostconfigWallsavedquery = msdynPostconfigWallsavedquery;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_configurewall")]
        public bool? MsdynConfigurewall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_followingviewid2")]
        public string MsdynFollowingviewid2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_otc")]
        public int? MsdynOtc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_status")]
        public string MsdynStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_entitydisplayname")]
        public string MsdynEntitydisplayname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfigid")]
        public string MsdynPostconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_entityname")]
        public string MsdynEntityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_followingviewid")]
        public string MsdynFollowingviewid { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfig_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynPostconfigSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfig_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynPostconfigAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfig_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynPostconfigMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfig_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynPostconfigProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfig_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynPostconfigBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfig_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynPostconfigPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfig_msdyn_postruleconfig")]
        public IList<MicrosoftDynamicsCRMmsdynPostruleconfig> MsdynPostconfigMsdynPostruleconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postconfig_wallsavedquery")]
        public IList<MicrosoftDynamicsCRMmsdynWallsavedquery> MsdynPostconfigWallsavedquery { get; set; }

    }
}
