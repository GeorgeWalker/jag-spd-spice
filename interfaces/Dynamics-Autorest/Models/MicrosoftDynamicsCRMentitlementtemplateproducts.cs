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
    /// entitlementtemplateproducts
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementtemplateproducts
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementtemplateproducts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementtemplateproducts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementtemplateproducts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementtemplateproducts(int? importsequencenumber = default(int?), string entitlementtemplateproductid = default(string), string name = default(string), string entitlementtemplateid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), long? versionnumber = default(long?), string productid = default(string), IList<MicrosoftDynamicsCRMasyncoperation> entitlementtemplateproductsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> entitlementtemplateproductsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementtemplateproductsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> entitlementtemplateproductsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Importsequencenumber = importsequencenumber;
            Entitlementtemplateproductid = entitlementtemplateproductid;
            Name = name;
            Entitlementtemplateid = entitlementtemplateid;
            Overriddencreatedon = overriddencreatedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            Productid = productid;
            EntitlementtemplateproductsAsyncOperations = entitlementtemplateproductsAsyncOperations;
            EntitlementtemplateproductsMailboxTrackingFolders = entitlementtemplateproductsMailboxTrackingFolders;
            EntitlementtemplateproductsBulkDeleteFailures = entitlementtemplateproductsBulkDeleteFailures;
            EntitlementtemplateproductsPrincipalObjectAttributeAccesses = entitlementtemplateproductsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateproductid")]
        public string Entitlementtemplateproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateid")]
        public string Entitlementtemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public string Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateproducts_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementtemplateproductsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateproducts_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> EntitlementtemplateproductsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateproducts_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementtemplateproductsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateproducts_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EntitlementtemplateproductsPrincipalObjectAttributeAccesses { get; set; }

    }
}
