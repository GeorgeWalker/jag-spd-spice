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
    /// Collection of kbarticles
    /// </summary>
    public partial class KbarticlesGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the KbarticlesGetResponseModel class.
        /// </summary>
        public KbarticlesGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KbarticlesGetResponseModel class.
        /// </summary>
        public KbarticlesGetResponseModel(IList<MicrosoftDynamicsCRMkbarticle> value = default(IList<MicrosoftDynamicsCRMkbarticle>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMkbarticle> Value { get; set; }

    }
}
