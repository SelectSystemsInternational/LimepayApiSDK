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
    /// Authority
    /// </summary>
    [DataContract]
    public partial class AuthorityRequest :  IEquatable<AuthorityRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of authority (checkout_id, account_token, store_code)
        /// </summary>
        /// <value>The type of authority (checkout_id, account_token, store_code)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum client_credentials for authorization token request
            /// </summary>
            [EnumMember(Value = "client_credentials")]
            ClientCredentials        
        }

        /// <summary>
        /// The type of authority (client_credentials)
        /// </summary>
        /// <value>The type of authority (checkout_id, account_token, store_code)</value>
        [DataMember(Name="grant_type", EmitDefaultValue=false)]
        public TypeEnum? GrantType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Authority" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthorityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Authority" /> class.
        /// </summary>
        /// <param name="Type">The type of authority (checkout_id, account_token, store_code) (required).</param>
        /// <param name="Value">The authority value/token (required).</param>
        public AuthorityRequest(TypeEnum? GrantType = default(TypeEnum?), string Audience = default(string), string Publishablekey = default(string), string SecretKey = default(string))
        {
            // to ensure "GrantType" is required (not null)
            if (GrantType == null)
            {
                throw new InvalidDataException("GrantType is a required property for Authority and cannot be null");
            }
            else
            {
                this.GrantType = GrantType;
            }
            // to ensure "Audience" is required (not null)
            if (Audience == null)
            {
                throw new InvalidDataException("Audience is a required property for Authority and cannot be null");
            }
            else
            {
                this.Audience = Audience;
            }
            // to ensure "Publishablekey" is required (not null)
            if (Publishablekey == null)
            {
                throw new InvalidDataException("Publishablekey is a required property for Authority and cannot be null");
            }
            else
            {
                this.Publishablekey = Publishablekey;
            }
            // to ensure "SecretKey" is required (not null)
            if (SecretKey == null)
            {
                throw new InvalidDataException("SecretKey is a required property for Authority and cannot be null");
            }
            else
            {
                this.SecretKey = SecretKey;
            }
        }
        
        /// <summary>
        /// The authority value/token
        /// </summary>
        /// <value>The authority value/token</value>
        [DataMember(Name = "audience", EmitDefaultValue=false)]
        public string Audience { get; set; }

        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string Publishablekey { get; set; }

        [DataMember(Name = "client_secret", EmitDefaultValue = false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Authority {\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  Publishablekey: ").Append(Publishablekey).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
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
            return this.Equals(obj as AuthorityRequest);
        }

        /// <summary>
        /// Returns true if Authority instances are equal
        /// </summary>
        /// <param name="other">Instance of Authority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorityRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GrantType == other.GrantType ||
                    this.GrantType != null &&
                    this.GrantType.Equals(other.GrantType)
                ) && 
                (
                    this.Audience == other.Audience ||
                    this.Audience != null &&
                    this.Audience.Equals(other.Audience)
                ) &&
                (
                    this.Publishablekey == other.Publishablekey ||
                    this.Publishablekey != null &&
                    this.Publishablekey.Equals(other.Publishablekey)
                ) &&
                (
                    this.SecretKey == other.SecretKey ||
                    this.SecretKey != null &&
                    this.SecretKey.Equals(other.SecretKey)
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
                if (this.GrantType != null)
                    hash = hash * 59 + this.GrantType.GetHashCode();
                if (this.Audience != null)
                    hash = hash * 59 + this.Audience.GetHashCode();
                if (this.Publishablekey != null)
                    hash = hash * 59 + this.Publishablekey.GetHashCode();
                if (this.SecretKey != null)
                    hash = hash * 59 + this.SecretKey.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}