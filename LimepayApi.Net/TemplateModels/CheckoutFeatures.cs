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
    /// Specific checkout features
    /// </summary>
    [DataContract]
    public partial class CheckoutFeatures :  IEquatable<CheckoutFeatures>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutFeatures" /> class.
        /// </summary>
        /// <param name="Tokenisation">Tokenisation.</param>
        public CheckoutFeatures(CheckoutFeaturesTokenisation Tokenisation = default(CheckoutFeaturesTokenisation))
        {
            this.Tokenisation = Tokenisation;
        }
        
        /// <summary>
        /// Gets or Sets Tokenisation
        /// </summary>
        [DataMember(Name="tokenisation", EmitDefaultValue=false)]
        public CheckoutFeaturesTokenisation Tokenisation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutFeatures {\n");
            sb.Append("  Tokenisation: ").Append(Tokenisation).Append("\n");
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
            return this.Equals(obj as CheckoutFeatures);
        }

        /// <summary>
        /// Returns true if CheckoutFeatures instances are equal
        /// </summary>
        /// <param name="other">Instance of CheckoutFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutFeatures other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tokenisation == other.Tokenisation ||
                    this.Tokenisation != null &&
                    this.Tokenisation.Equals(other.Tokenisation)
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
                if (this.Tokenisation != null)
                    hash = hash * 59 + this.Tokenisation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
