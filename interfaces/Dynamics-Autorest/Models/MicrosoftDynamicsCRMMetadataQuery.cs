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
    /// MetadataQuery
    /// </summary>
    public partial class MicrosoftDynamicsCRMMetadataQuery
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMMetadataQuery
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMMetadataQuery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMMetadataQuery
        /// class.
        /// </summary>
        /// <param name="dependencyDepth">Possible values include: 'Unknown',
        /// 'OnDemandWithContext', 'OnDemandWithoutContext',
        /// 'OnDemandContextOnly', 'Offline', 'Mobile', 'UserContext'</param>
        public MicrosoftDynamicsCRMMetadataQuery(string metadataType = default(string), string metadataSubtype = default(string), string entityLogicalName = default(string), string metadataId = default(string), string metadataName = default(string), IList<string> metadataNames = default(IList<string>), bool? getDefault = default(bool?), string dependencyDepth = default(string), string changedAfter = default(string), IList<string> exclude = default(IList<string>), string appId = default(string), string userMetadataDelta = default(string), string systemMetadataDelta = default(string))
        {
            MetadataType = metadataType;
            MetadataSubtype = metadataSubtype;
            EntityLogicalName = entityLogicalName;
            MetadataId = metadataId;
            MetadataName = metadataName;
            MetadataNames = metadataNames;
            GetDefault = getDefault;
            DependencyDepth = dependencyDepth;
            ChangedAfter = changedAfter;
            Exclude = exclude;
            AppId = appId;
            UserMetadataDelta = userMetadataDelta;
            SystemMetadataDelta = systemMetadataDelta;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataType")]
        public string MetadataType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataSubtype")]
        public string MetadataSubtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityLogicalName")]
        public string EntityLogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataName")]
        public string MetadataName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataNames")]
        public IList<string> MetadataNames { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GetDefault")]
        public bool? GetDefault { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Unknown',
        /// 'OnDemandWithContext', 'OnDemandWithoutContext',
        /// 'OnDemandContextOnly', 'Offline', 'Mobile', 'UserContext'
        /// </summary>
        [JsonProperty(PropertyName = "DependencyDepth")]
        public string DependencyDepth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChangedAfter")]
        public string ChangedAfter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Exclude")]
        public IList<string> Exclude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AppId")]
        public string AppId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserMetadataDelta")]
        public string UserMetadataDelta { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SystemMetadataDelta")]
        public string SystemMetadataDelta { get; set; }

    }
}
