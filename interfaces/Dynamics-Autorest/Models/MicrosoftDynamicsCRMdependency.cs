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
    /// dependency
    /// </summary>
    public partial class MicrosoftDynamicsCRMdependency
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdependency
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdependency()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdependency
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdependency(string requiredcomponentobjectid = default(string), long? versionnumber = default(long?), string requiredcomponentparentid = default(string), string dependentcomponentbasesolutionid = default(string), int? dependentcomponenttype = default(int?), string dependencyid = default(string), string dependentcomponentparentid = default(string), string _requiredcomponentnodeidValue = default(string), string _dependentcomponentnodeidValue = default(string), string requiredcomponentbasesolutionid = default(string), int? dependencytype = default(int?), string dependentcomponentobjectid = default(string), double? requiredcomponentintroducedversion = default(double?), int? requiredcomponenttype = default(int?))
        {
            Requiredcomponentobjectid = requiredcomponentobjectid;
            Versionnumber = versionnumber;
            Requiredcomponentparentid = requiredcomponentparentid;
            Dependentcomponentbasesolutionid = dependentcomponentbasesolutionid;
            Dependentcomponenttype = dependentcomponenttype;
            Dependencyid = dependencyid;
            Dependentcomponentparentid = dependentcomponentparentid;
            this._requiredcomponentnodeidValue = _requiredcomponentnodeidValue;
            this._dependentcomponentnodeidValue = _dependentcomponentnodeidValue;
            Requiredcomponentbasesolutionid = requiredcomponentbasesolutionid;
            Dependencytype = dependencytype;
            Dependentcomponentobjectid = dependentcomponentobjectid;
            Requiredcomponentintroducedversion = requiredcomponentintroducedversion;
            Requiredcomponenttype = requiredcomponenttype;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredcomponentobjectid")]
        public string Requiredcomponentobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredcomponentparentid")]
        public string Requiredcomponentparentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dependentcomponentbasesolutionid")]
        public string Dependentcomponentbasesolutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dependentcomponenttype")]
        public int? Dependentcomponenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dependencyid")]
        public string Dependencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dependentcomponentparentid")]
        public string Dependentcomponentparentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_requiredcomponentnodeid_value")]
        public string _requiredcomponentnodeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_dependentcomponentnodeid_value")]
        public string _dependentcomponentnodeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredcomponentbasesolutionid")]
        public string Requiredcomponentbasesolutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dependencytype")]
        public int? Dependencytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dependentcomponentobjectid")]
        public string Dependentcomponentobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredcomponentintroducedversion")]
        public double? Requiredcomponentintroducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredcomponenttype")]
        public int? Requiredcomponenttype { get; set; }

    }
}
