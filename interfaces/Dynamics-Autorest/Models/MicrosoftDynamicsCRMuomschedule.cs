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
    /// uomschedule
    /// </summary>
    public partial class MicrosoftDynamicsCRMuomschedule
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuomschedule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuomschedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuomschedule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuomschedule(int? timezoneruleversionnumber = default(int?), int? statecode = default(int?), string uomscheduleid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string baseuomname = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string name = default(string), string _createdonbehalfbyValue = default(string), string _organizationidValue = default(string), int? statuscode = default(int?), string _createdbyexternalpartyValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string description = default(string), string _modifiedonbehalfbyValue = default(string), string _modifiedbyexternalpartyValue = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> uoMScheduleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> uoMScheduleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> uomscheduleMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> uoMScheduleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> uomschedulePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMproduct> unitOfMeasurementScheduleProducts = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMuom> unitOfMeasureScheduleConversions = default(IList<MicrosoftDynamicsCRMuom>), IList<MicrosoftDynamicsCRMproductpricelevel> unitOfMeasureScheduleProductPriceLevel = default(IList<MicrosoftDynamicsCRMproductpricelevel>), IList<MicrosoftDynamicsCRMcontractdetail> contractDetailUnitOfMeasureSchedule = default(IList<MicrosoftDynamicsCRMcontractdetail>))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statecode = statecode;
            Uomscheduleid = uomscheduleid;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Baseuomname = baseuomname;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Versionnumber = versionnumber;
            Name = name;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Statuscode = statuscode;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            this._createdbyValue = _createdbyValue;
            Overriddencreatedon = overriddencreatedon;
            Description = description;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            Importsequencenumber = importsequencenumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            UoMScheduleSyncErrors = uoMScheduleSyncErrors;
            UoMScheduleAsyncOperations = uoMScheduleAsyncOperations;
            UomscheduleMailboxTrackingFolders = uomscheduleMailboxTrackingFolders;
            UoMScheduleBulkDeleteFailures = uoMScheduleBulkDeleteFailures;
            UomschedulePrincipalObjectAttributeAccesses = uomschedulePrincipalObjectAttributeAccesses;
            UnitOfMeasurementScheduleProducts = unitOfMeasurementScheduleProducts;
            UnitOfMeasureScheduleConversions = unitOfMeasureScheduleConversions;
            UnitOfMeasureScheduleProductPriceLevel = unitOfMeasureScheduleProductPriceLevel;
            ContractDetailUnitOfMeasureSchedule = contractDetailUnitOfMeasureSchedule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public string Uomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseuomname")]
        public string Baseuomname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public string _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public string _modifiedbyexternalpartyValue { get; set; }

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
        [JsonProperty(PropertyName = "UoMSchedule_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> UoMScheduleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoMSchedule_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> UoMScheduleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomschedule_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> UomscheduleMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoMSchedule_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> UoMScheduleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomschedule_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> UomschedulePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_schedule_products")]
        public IList<MicrosoftDynamicsCRMproduct> UnitOfMeasurementScheduleProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measure_schedule_conversions")]
        public IList<MicrosoftDynamicsCRMuom> UnitOfMeasureScheduleConversions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measure_schedule_product_price_level")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> UnitOfMeasureScheduleProductPriceLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_detail_unit_of_measure_schedule")]
        public IList<MicrosoftDynamicsCRMcontractdetail> ContractDetailUnitOfMeasureSchedule { get; set; }

    }
}
