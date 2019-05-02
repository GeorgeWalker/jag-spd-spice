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
    /// territory
    /// </summary>
    public partial class MicrosoftDynamicsCRMterritory
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMterritory
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMterritory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMterritory
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMterritory(string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _manageridValue = default(string), string _transactioncurrencyidValue = default(string), long? versionnumber = default(long?), string territoryid = default(string), string description = default(string), string name = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string entityimageid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), long? entityimageTimestamp = default(long?), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), object exchangerate = default(object), object entityimage = default(object), string entityimageUrl = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> territorySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> territoryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> territoryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> territoryProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> territoryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> territoryPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> territoryConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> territoryConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser managerid = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsystemuser> territorySystemUsers = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMaccount> territoryAccounts = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMduplicaterecord> territoryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> territoryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>))
        {
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._manageridValue = _manageridValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Versionnumber = versionnumber;
            Territoryid = territoryid;
            Description = description;
            Name = name;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Entityimageid = entityimageid;
            Overriddencreatedon = overriddencreatedon;
            EntityimageTimestamp = entityimageTimestamp;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Exchangerate = exchangerate;
            Entityimage = entityimage;
            EntityimageUrl = entityimageUrl;
            Importsequencenumber = importsequencenumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            TerritorySyncErrors = territorySyncErrors;
            TerritoryAsyncOperations = territoryAsyncOperations;
            TerritoryMailboxTrackingFolders = territoryMailboxTrackingFolders;
            TerritoryProcessSessions = territoryProcessSessions;
            TerritoryBulkDeleteFailures = territoryBulkDeleteFailures;
            TerritoryPrincipalobjectattributeaccess = territoryPrincipalobjectattributeaccess;
            TerritoryConnections1 = territoryConnections1;
            TerritoryConnections2 = territoryConnections2;
            Transactioncurrencyid = transactioncurrencyid;
            Managerid = managerid;
            TerritorySystemUsers = territorySystemUsers;
            TerritoryAccounts = territoryAccounts;
            TerritoryDuplicateBaseRecord = territoryDuplicateBaseRecord;
            TerritoryDuplicateMatchingRecord = territoryDuplicateMatchingRecord;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_managerid_value")]
        public string _manageridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territoryid")]
        public string Territoryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

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
        [JsonProperty(PropertyName = "Territory_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TerritorySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> TerritoryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> TerritoryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> TerritoryProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> TerritoryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> TerritoryPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> TerritoryConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> TerritoryConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "managerid")]
        public MicrosoftDynamicsCRMsystemuser Managerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_system_users")]
        public IList<MicrosoftDynamicsCRMsystemuser> TerritorySystemUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory_accounts")]
        public IList<MicrosoftDynamicsCRMaccount> TerritoryAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> TerritoryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Territory_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> TerritoryDuplicateMatchingRecord { get; set; }

    }
}
