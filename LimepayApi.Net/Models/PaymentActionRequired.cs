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
    /// The PaymentActionRequired object
    /// </summary>
    [DataContract]
    public partial class PaymentActionRequired :  IEquatable<PaymentActionRequired>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentActionRequired" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentActionRequired() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentActionRequired" /> class.
        /// </summary>
        /// <param name="ThreeDSAuthorisationId">ThreeDSAuthorisationId</param>
        /// <param name="RedirectURL">The redirect Url</param>
        public PaymentActionRequired(string ThreeDSAuthorisationId = default(string), string RedirectURL = default(string))
        {
            this.ThreeDSAuthorisationId = ThreeDSAuthorisationId;
            this.RedirectURL = RedirectURL;
        }

        /// <summary>
        /// Gets or Sets ThreeDSAuthorisationId
        /// </summary>
        [DataMember(Name= "threeDSAuthorisationId", EmitDefaultValue=false)]
        public string ThreeDSAuthorisationId { get; set; }

        /// <summary>
        /// Gets or Sets RedirectURL
        /// </summary>
        [DataMember(Name= "redirectURL", EmitDefaultValue=false)]
        public string RedirectURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Money {\n");
            sb.Append("  ThreeDSAuthorisationId: ").Append(ThreeDSAuthorisationId).Append("\n");
            sb.Append("  RedirectURL: ").Append(RedirectURL).Append("\n");
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
            return this.Equals(obj as PaymentActionRequired);
        }

        /// <summary>
        /// Returns true if AccessToken instances are equal
        /// </summary>
        /// <param name="other">Instance of AccessToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentActionRequired other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ThreeDSAuthorisationId == other.ThreeDSAuthorisationId ||
                    this.ThreeDSAuthorisationId != null &&
                    this.ThreeDSAuthorisationId.Equals(other.ThreeDSAuthorisationId)
                ) && 
                (
                    this.RedirectURL == other.RedirectURL ||
                    this.RedirectURL != null &&
                    this.RedirectURL.Equals(other.RedirectURL)
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

                if (this.ThreeDSAuthorisationId != null)
                    hash = hash * 59 + this.ThreeDSAuthorisationId.GetHashCode();
                if (this.RedirectURL != null)
                    hash = hash * 59 + this.RedirectURL.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
