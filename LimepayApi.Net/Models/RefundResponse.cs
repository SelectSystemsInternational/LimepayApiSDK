/* 
 * Limepay API
 *
 * Initial build 2022-07-23
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://selectsystems.com.au
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LimepayApi.Net.Models
{
    /// <summary>
    /// Order
    /// </summary>
    [DataContract]
    public partial class RefundResponse :  IEquatable<RefundResponse>, IValidatableObject
    {

        [JsonConstructorAttribute]
        protected RefundResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundResponse" /> class.
        /// </summary>
        /// <param name="RefundId">RefundId</param>
        public RefundResponse(string RefundId = default(string))
        {
            this.RefundId = RefundId;
        }

        /// <summary>
        /// Gets or Sets RefundId;
        /// </summary>
        [DataMember(Name = "refundId", EmitDefaultValue = false)]
        public string RefundId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundResponse {\n");
            sb.Append("  RefundId: ").Append(RefundId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RefundResponse);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.RefundId == other.RefundId ||
                    this.RefundId != null &&
                    this.RefundId.Equals(other.RefundId)
                );
        }
        

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.RefundId != null)
                    hash = hash * 59 + this.RefundId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
