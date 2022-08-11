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
    /// PlaceholderModel
    /// </summary>
    [DataContract(Name = "placeholder_model")]
    public partial class PlaceholderModel : IEquatable<PlaceholderModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceholderModel" /> class.
        /// </summary>
        /// <param name="returnEnvelope">returnEnvelope.</param>
        /// <param name="addressDomestic">addressDomestic.</param>
        public PlaceholderModel(ReturnEnvelope returnEnvelope = default(ReturnEnvelope), AddressDomestic addressDomestic = default(AddressDomestic))
        {
            this.ReturnEnvelope = returnEnvelope;
            this.AddressDomestic = addressDomestic;
        }

        /// <summary>
        /// Gets or Sets ReturnEnvelope
        /// </summary>
        [DataMember(Name = "return_envelope", EmitDefaultValue = false)]
        public ReturnEnvelope ReturnEnvelope { get; set; }

        /// <summary>
        /// Gets or Sets AddressDomestic
        /// </summary>
        [DataMember(Name = "address_domestic", EmitDefaultValue = false)]
        public AddressDomestic AddressDomestic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlaceholderModel {\n");
            sb.Append("  ReturnEnvelope: ").Append(ReturnEnvelope).Append("\n");
            sb.Append("  AddressDomestic: ").Append(AddressDomestic).Append("\n");
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
            return this.Equals(input as PlaceholderModel);
        }

        /// <summary>
        /// Returns true if PlaceholderModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PlaceholderModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaceholderModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReturnEnvelope == input.ReturnEnvelope ||
                    (this.ReturnEnvelope != null &&
                    this.ReturnEnvelope.Equals(input.ReturnEnvelope))
                ) && 
                (
                    this.AddressDomestic == input.AddressDomestic ||
                    (this.AddressDomestic != null &&
                    this.AddressDomestic.Equals(input.AddressDomestic))
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
                if (this.ReturnEnvelope != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnEnvelope.GetHashCode();
                }
                if (this.AddressDomestic != null)
                {
                    hashCode = (hashCode * 59) + this.AddressDomestic.GetHashCode();
                }
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