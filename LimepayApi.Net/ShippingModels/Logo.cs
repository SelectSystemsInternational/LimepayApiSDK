using System.Runtime.Serialization;

namespace LimepayApi.Net.Models
{
    [DataContract]
    public class Logo
    {
        [DataMember(Name = "url", EmitDefaultValue = false, IsRequired = false)]
        public string Url { get; set; }

    }
}
