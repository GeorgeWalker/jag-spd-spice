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
    /// Label
    /// </summary>
    public partial class MicrosoftDynamicsCRMLabel
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMLabel class.
        /// </summary>
        public MicrosoftDynamicsCRMLabel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMLabel class.
        /// </summary>
        public MicrosoftDynamicsCRMLabel(IList<MicrosoftDynamicsCRMLocalizedLabel> localizedLabels = default(IList<MicrosoftDynamicsCRMLocalizedLabel>), MicrosoftDynamicsCRMLocalizedLabel userLocalizedLabel = default(MicrosoftDynamicsCRMLocalizedLabel))
        {
            LocalizedLabels = localizedLabels;
            UserLocalizedLabel = userLocalizedLabel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LocalizedLabels")]
        public IList<MicrosoftDynamicsCRMLocalizedLabel> LocalizedLabels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserLocalizedLabel")]
        public MicrosoftDynamicsCRMLocalizedLabel UserLocalizedLabel { get; set; }

    }
}
