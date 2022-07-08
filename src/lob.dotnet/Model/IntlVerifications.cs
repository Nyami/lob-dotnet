/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)? 
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = lob.dotnet.Client.OpenAPIDateConverter;

namespace lob.dotnet.Model
{
    /// <summary>
    /// IntlVerifications
    /// </summary>
    [DataContract(Name = "intl_verifications")]
    public partial class IntlVerifications : IEquatable<IntlVerifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlVerifications" /> class.
        /// </summary>
        /// <param name="addresses">addresses.</param>
        /// <param name="errors">Indicates whether any errors occurred during the verification process..</param>
        public IntlVerifications(List<IntlVerificationOrError> addresses = default(List<IntlVerificationOrError>), bool errors = default(bool))
        {
            this.Addresses = addresses;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<IntlVerificationOrError> Addresses { get; set; }

        /// <summary>
        /// Indicates whether any errors occurred during the verification process.
        /// </summary>
        /// <value>Indicates whether any errors occurred during the verification process.</value>
        [DataMember(Name = "errors", EmitDefaultValue = true)]
        public bool Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntlVerifications {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IntlVerifications);
        }

        /// <summary>
        /// Returns true if IntlVerifications instances are equal
        /// </summary>
        /// <param name="input">Instance of IntlVerifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntlVerifications input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors.Equals(input.Errors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}