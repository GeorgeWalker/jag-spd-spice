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
    /// Collection of mobileofflineprofileitems
    /// </summary>
    public partial class MobileofflineprofileitemsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MobileofflineprofileitemsGetResponseModel class.
        /// </summary>
        public MobileofflineprofileitemsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MobileofflineprofileitemsGetResponseModel class.
        /// </summary>
        public MobileofflineprofileitemsGetResponseModel(IList<MicrosoftDynamicsCRMmobileofflineprofileitem> value = default(IList<MicrosoftDynamicsCRMmobileofflineprofileitem>))
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
        public IList<MicrosoftDynamicsCRMmobileofflineprofileitem> Value { get; set; }

    }
}
