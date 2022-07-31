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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace LimepayApi.Net.Models
{
    /// <summary>
    /// CreateChargeRequest
    /// </summary>
    [DataContract]
    public partial class CreateChargeRequest :  IEquatable<CreateChargeRequest>, IValidatableObject
    {

        /// <summary>
        /// The currency
        /// </summary>
        /// <value>The currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateChargeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest" /> class.
        /// </summary>
        /// <param name="Authority">Authority (required).</param>
        /// <param name="Reference">The reference for this charge (unique payment reference in your store).</param>
        /// <param name="Amount">The amount of the charge (required).</param>
        /// <param name="Currency">The currency (required).</param>
        /// <param name="Capture">If true this will be a direct capture, pass false to perform an authorisation only (default to true).</param>
        /// <param name="Order">Order.</param>
        /// <param name="Metadata">Metadata.</param>
        public CreateChargeRequest(AuthorityRequest Authority = default(AuthorityRequest), 
            string Reference = default(string), decimal? Amount = default(decimal?), 
            string Currency = default(string), bool? Capture = true, ChargeOrder Order = default(ChargeOrder), Object Metadata = default(Object))
        {
            // to ensure "Authority" is required (not null)
            if (Authority == null)
            {
                throw new InvalidDataException("Authority is a required property for CreateChargeRequest and cannot be null");
            }
            else
            {
                this.Authority = Authority;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for CreateChargeRequest and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for CreateChargeRequest and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            this.Reference = Reference;
            // use default value if no "Capture" provided
            if (Capture == null)
            {
                this.Capture = true;
            }
            else
            {
                this.Capture = Capture;
            }
            this.Order = Order;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// Gets or Sets Authority
        /// </summary>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public AuthorityRequest Authority { get; set; }
        /// <summary>
        /// The reference for this charge (unique payment reference in your store)
        /// </summary>
        /// <value>The reference for this charge (unique payment reference in your store)</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }
        /// <summary>
        /// The amount of the charge
        /// </summary>
        /// <value>The amount of the charge</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// If true this will be a direct capture, pass false to perform an authorisation only
        /// </summary>
        /// <value>If true this will be a direct capture, pass false to perform an authorisation only</value>
        [DataMember(Name="capture", EmitDefaultValue=false)]
        public bool? Capture { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public ChargeOrder Order { get; set; }
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChargeRequest {\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Capture: ").Append(Capture).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as CreateChargeRequest);
        }

        /// <summary>
        /// Returns true if CreateChargeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateChargeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateChargeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Authority == other.Authority ||
                    this.Authority != null &&
                    this.Authority.Equals(other.Authority)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Capture == other.Capture ||
                    this.Capture != null &&
                    this.Capture.Equals(other.Capture)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Authority != null)
                    hash = hash * 59 + this.Authority.GetHashCode();
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Capture != null)
                    hash = hash * 59 + this.Capture.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
