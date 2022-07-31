using System.Runtime.Serialization;
using LimepayApi.Net.Models;

namespace LimepayApi.Net.Wrappers
{
    [DataContract]
    public class DataWrapper
    {
        [DataMember(Name = "parcel", EmitDefaultValue = false, IsRequired = false)]
        public CreateParcel Parcel { get; set; }

        [DataMember(Name = "parcels", EmitDefaultValue = false, IsRequired = false)]
        public CreateParcel[] Parcels { get; set; }

        [DataMember(Name = "label", EmitDefaultValue = false, IsRequired = false)]
        public Label Label { get; set; }
    }
}
