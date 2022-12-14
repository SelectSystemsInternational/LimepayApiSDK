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
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LimepayApi.Net.Models
{
    /// <summary>
    /// Refund
    /// </summary>
    [DataContract]
    public partial class UpdateOrder :  IEquatable<UpdateOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrder" /> class.
        /// </summary>
        /// <param name="Id">The id of the refund (required).</param>
        /// <param name="ChargeId">The original charge that relates to this refund.</param>
        /// <param name="Reason">The reason for the refund (required).</param>
        /// <param name="Amount">The amount that was refunded (required).</param>
        /// <param name="Created">The date the refund was created (required).</param>
        /// <param name="Metadata">Any additional metadata.</param>
        public UpdateOrder(string InternalOrderId = default(string))
        {
            // to ensure "InternalOrderId" is required (not null)
            if (InternalOrderId == null)
            {
                throw new InvalidDataException("InternalOrderId is a required property for Refund and cannot be null");
            }

            this.InternalOrderId = InternalOrderId;

        }
        
        /// <summary>
        /// The id of the refund
        /// </summary>
        /// <value>The id of the refund</value>
        [DataMember(Name= "internalOrderId", EmitDefaultValue=false)]
        public string InternalOrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Refund {\n");
            sb.Append("  InternalOrderId: ").Append(InternalOrderId).Append("\n");
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
            return this.Equals(obj as UpdateOrder);
        }

        /// <summary>
        /// Returns true if Refund instances are equal
        /// </summary>
        /// <param name="other">Instance of Refund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InternalOrderId == other.InternalOrderId ||
                    this.InternalOrderId != null &&
                    this.InternalOrderId.Equals(other.InternalOrderId)
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
                if (this.InternalOrderId != null)
                    hash = hash * 59 + this.InternalOrderId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
