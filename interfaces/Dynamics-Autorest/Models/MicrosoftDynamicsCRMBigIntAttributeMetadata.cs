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
    /// BigIntAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMBigIntAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBigIntAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMBigIntAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBigIntAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMBigIntAttributeMetadata(long? maxValue = default(long?), long? minValue = default(long?))
        {
            MaxValue = maxValue;
            MinValue = minValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxValue")]
        public long? MaxValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MinValue")]
        public long? MinValue { get; set; }

    }
}
