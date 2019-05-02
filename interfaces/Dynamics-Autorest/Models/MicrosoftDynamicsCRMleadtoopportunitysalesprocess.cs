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
    /// leadtoopportunitysalesprocess
    /// </summary>
    public partial class MicrosoftDynamicsCRMleadtoopportunitysalesprocess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMleadtoopportunitysalesprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMleadtoopportunitysalesprocess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMleadtoopportunitysalesprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMleadtoopportunitysalesprocess(string businessprocessflowinstanceid = default(string), string _organizationidValue = default(string), string traversedpath = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), string name = default(string), string _transactioncurrencyidValue = default(string), string _activestageidValue = default(string), int? duration = default(int?), long? versionnumber = default(long?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _processidValue = default(string), object exchangerate = default(object), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), int? statecode = default(int?), int? statuscode = default(int?), string _createdonbehalfbyValue = default(string), string _opportunityidValue = default(string), string _leadidValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMprocessstage activestageid = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> leadToOpportunitySalesProcessSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> leadtoopportunitysalesprocessAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMworkflowlog> workflowlogsLeadtoopportunitysalesprocess = default(IList<MicrosoftDynamicsCRMworkflowlog>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> leadtoopportunitysalesprocessMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> leadtoopportunitysalesprocessProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> leadtoopportunitysalesprocessBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> leadtoopportunitysalesprocessPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMopportunity opportunityId = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMlead leadId = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            this._organizationidValue = _organizationidValue;
            Traversedpath = traversedpath;
            Completedon = completedon;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Activestagestartedon = activestagestartedon;
            Name = name;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._activestageidValue = _activestageidValue;
            Duration = duration;
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            this._processidValue = _processidValue;
            Exchangerate = exchangerate;
            Createdon = createdon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statecode = statecode;
            Statuscode = statuscode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._opportunityidValue = _opportunityidValue;
            this._leadidValue = _leadidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            Activestageid = activestageid;
            Processid = processid;
            LeadToOpportunitySalesProcessSyncErrors = leadToOpportunitySalesProcessSyncErrors;
            LeadtoopportunitysalesprocessAsyncOperations = leadtoopportunitysalesprocessAsyncOperations;
            WorkflowlogsLeadtoopportunitysalesprocess = workflowlogsLeadtoopportunitysalesprocess;
            LeadtoopportunitysalesprocessMailboxTrackingFolders = leadtoopportunitysalesprocessMailboxTrackingFolders;
            LeadtoopportunitysalesprocessProcessSession = leadtoopportunitysalesprocessProcessSession;
            LeadtoopportunitysalesprocessBulkDeleteFailures = leadtoopportunitysalesprocessBulkDeleteFailures;
            LeadtoopportunitysalesprocessPrincipalObjectAttributeAccesses = leadtoopportunitysalesprocessPrincipalObjectAttributeAccesses;
            OpportunityId = opportunityId;
            LeadId = leadId;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

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
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_leadid_value")]
        public string _leadidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageid")]
        public MicrosoftDynamicsCRMprocessstage Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LeadToOpportunitySalesProcess_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> LeadToOpportunitySalesProcessSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadtoopportunitysalesprocess_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> LeadtoopportunitysalesprocessAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowlogs_leadtoopportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMworkflowlog> WorkflowlogsLeadtoopportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadtoopportunitysalesprocess_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> LeadtoopportunitysalesprocessMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadtoopportunitysalesprocess_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> LeadtoopportunitysalesprocessProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadtoopportunitysalesprocess_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> LeadtoopportunitysalesprocessBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> LeadtoopportunitysalesprocessPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityId")]
        public MicrosoftDynamicsCRMopportunity OpportunityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadId")]
        public MicrosoftDynamicsCRMlead LeadId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
