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
    /// UsVerification
    /// </summary>
    [DataContract(Name = "us_verification")]
    public partial class UsVerification : IEquatable<UsVerification>, IValidatableObject
    {
        /// <summary>
        /// Summarizes the deliverability of the &#x60;us_verification&#x60; object. For full details, see the &#x60;deliverability_analysis&#x60; field. Possible values are: * &#x60;deliverable&#x60; – The address is deliverable by the USPS. * &#x60;deliverable_unnecessary_unit&#x60; – The address is deliverable, but the secondary unit information is unnecessary. * &#x60;deliverable_incorrect_unit&#x60; – The address is deliverable to the building&#39;s default address but the secondary unit provided may not exist. There is a chance the mail will not reach the intended recipient. * &#x60;deliverable_missing_unit&#x60; – The address is deliverable to the building&#39;s default address but is missing secondary unit information. There is a chance the mail will not reach the intended recipient. * &#x60;undeliverable&#x60; – The address is not deliverable according to the USPS. 
        /// </summary>
        /// <value>Summarizes the deliverability of the &#x60;us_verification&#x60; object. For full details, see the &#x60;deliverability_analysis&#x60; field. Possible values are: * &#x60;deliverable&#x60; – The address is deliverable by the USPS. * &#x60;deliverable_unnecessary_unit&#x60; – The address is deliverable, but the secondary unit information is unnecessary. * &#x60;deliverable_incorrect_unit&#x60; – The address is deliverable to the building&#39;s default address but the secondary unit provided may not exist. There is a chance the mail will not reach the intended recipient. * &#x60;deliverable_missing_unit&#x60; – The address is deliverable to the building&#39;s default address but is missing secondary unit information. There is a chance the mail will not reach the intended recipient. * &#x60;undeliverable&#x60; – The address is not deliverable according to the USPS. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliverabilityEnum
        {
            /// <summary>
            /// Enum Deliverable for value: deliverable
            /// </summary>
            [EnumMember(Value = "deliverable")]
            Deliverable = 1,

            /// <summary>
            /// Enum DeliverableUnnecessaryUnit for value: deliverable_unnecessary_unit
            /// </summary>
            [EnumMember(Value = "deliverable_unnecessary_unit")]
            DeliverableUnnecessaryUnit = 2,

            /// <summary>
            /// Enum DeliverableIncorrectUnit for value: deliverable_incorrect_unit
            /// </summary>
            [EnumMember(Value = "deliverable_incorrect_unit")]
            DeliverableIncorrectUnit = 3,

            /// <summary>
            /// Enum DeliverableMissingUnit for value: deliverable_missing_unit
            /// </summary>
            [EnumMember(Value = "deliverable_missing_unit")]
            DeliverableMissingUnit = 4,

            /// <summary>
            /// Enum Undeliverable for value: undeliverable
            /// </summary>
            [EnumMember(Value = "undeliverable")]
            Undeliverable = 5

        }


        /// <summary>
        /// Summarizes the deliverability of the &#x60;us_verification&#x60; object. For full details, see the &#x60;deliverability_analysis&#x60; field. Possible values are: * &#x60;deliverable&#x60; – The address is deliverable by the USPS. * &#x60;deliverable_unnecessary_unit&#x60; – The address is deliverable, but the secondary unit information is unnecessary. * &#x60;deliverable_incorrect_unit&#x60; – The address is deliverable to the building&#39;s default address but the secondary unit provided may not exist. There is a chance the mail will not reach the intended recipient. * &#x60;deliverable_missing_unit&#x60; – The address is deliverable to the building&#39;s default address but is missing secondary unit information. There is a chance the mail will not reach the intended recipient. * &#x60;undeliverable&#x60; – The address is not deliverable according to the USPS. 
        /// </summary>
        /// <value>Summarizes the deliverability of the &#x60;us_verification&#x60; object. For full details, see the &#x60;deliverability_analysis&#x60; field. Possible values are: * &#x60;deliverable&#x60; – The address is deliverable by the USPS. * &#x60;deliverable_unnecessary_unit&#x60; – The address is deliverable, but the secondary unit information is unnecessary. * &#x60;deliverable_incorrect_unit&#x60; – The address is deliverable to the building&#39;s default address but the secondary unit provided may not exist. There is a chance the mail will not reach the intended recipient. * &#x60;deliverable_missing_unit&#x60; – The address is deliverable to the building&#39;s default address but is missing secondary unit information. There is a chance the mail will not reach the intended recipient. * &#x60;undeliverable&#x60; – The address is not deliverable according to the USPS. </value>
        [DataMember(Name = "deliverability", EmitDefaultValue = false)]
        public DeliverabilityEnum? Deliverability { get; set; }
        /// <summary>
        /// Defines Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum UsVerification for value: us_verification
            /// </summary>
            [EnumMember(Value = "us_verification")]
            UsVerification = 1

        }


        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsVerification" /> class.
        /// </summary>
        /// <param name="id">Unique identifier prefixed with &#x60;us_ver_&#x60;..</param>
        /// <param name="recipient">The intended recipient, typically a person&#39;s or firm&#39;s name..</param>
        /// <param name="primaryLine">The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60;: * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60; .</param>
        /// <param name="secondaryLine">The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. .</param>
        /// <param name="urbanization">Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See [USPS documentation](https://pe.usps.com/text/pub28/28api_008.htm#:~:text&#x3D;I51.,-4%20Urbanizations&amp;text&#x3D;In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name.) for clarification. .</param>
        /// <param name="lastLine">Combination of the following applicable &#x60;components&#x60;: * City (&#x60;city&#x60;) * State (&#x60;state&#x60;) * ZIP code (&#x60;zip_code&#x60;) * ZIP+4 (&#x60;zip_code_plus_4&#x60;) .</param>
        /// <param name="deliverability">Summarizes the deliverability of the &#x60;us_verification&#x60; object. For full details, see the &#x60;deliverability_analysis&#x60; field. Possible values are: * &#x60;deliverable&#x60; – The address is deliverable by the USPS. * &#x60;deliverable_unnecessary_unit&#x60; – The address is deliverable, but the secondary unit information is unnecessary. * &#x60;deliverable_incorrect_unit&#x60; – The address is deliverable to the building&#39;s default address but the secondary unit provided may not exist. There is a chance the mail will not reach the intended recipient. * &#x60;deliverable_missing_unit&#x60; – The address is deliverable to the building&#39;s default address but is missing secondary unit information. There is a chance the mail will not reach the intended recipient. * &#x60;undeliverable&#x60; – The address is not deliverable according to the USPS. .</param>
        /// <param name="components">components.</param>
        /// <param name="deliverabilityAnalysis">deliverabilityAnalysis.</param>
        /// <param name="lobConfidenceScore">lobConfidenceScore.</param>
        /// <param name="_object">_object (default to ObjectEnum.UsVerification).</param>
        public UsVerification(string id = default(string), string recipient = default(string), string primaryLine = default(string), string secondaryLine = default(string), string urbanization = default(string), string lastLine = default(string), DeliverabilityEnum? deliverability = default(DeliverabilityEnum?), UsComponents components = default(UsComponents), DeliverabilityAnalysis deliverabilityAnalysis = default(DeliverabilityAnalysis), LobConfidenceScore lobConfidenceScore = default(LobConfidenceScore), ObjectEnum? _object = ObjectEnum.UsVerification)
        {
            this.Id = id;
            this.Recipient = recipient;
            this.PrimaryLine = primaryLine;
            this.SecondaryLine = secondaryLine;
            this.Urbanization = urbanization;
            this.LastLine = lastLine;
            this.Deliverability = deliverability;
            this.Components = components;
            this.DeliverabilityAnalysis = deliverabilityAnalysis;
            this.LobConfidenceScore = lobConfidenceScore;
            this.Object = _object;
        }

        /// <summary>
        /// Unique identifier prefixed with &#x60;us_ver_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;us_ver_&#x60;.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The intended recipient, typically a person&#39;s or firm&#39;s name.
        /// </summary>
        /// <value>The intended recipient, typically a person&#39;s or firm&#39;s name.</value>
        [DataMember(Name = "recipient", EmitDefaultValue = true)]
        public string Recipient { get; set; }

        /// <summary>
        /// The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60;: * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60; 
        /// </summary>
        /// <value>The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60;: * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60; </value>
        [DataMember(Name = "primary_line", EmitDefaultValue = false)]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. 
        /// </summary>
        /// <value>The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. </value>
        [DataMember(Name = "secondary_line", EmitDefaultValue = false)]
        public string SecondaryLine { get; set; }

        /// <summary>
        /// Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See [USPS documentation](https://pe.usps.com/text/pub28/28api_008.htm#:~:text&#x3D;I51.,-4%20Urbanizations&amp;text&#x3D;In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name.) for clarification. 
        /// </summary>
        /// <value>Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See [USPS documentation](https://pe.usps.com/text/pub28/28api_008.htm#:~:text&#x3D;I51.,-4%20Urbanizations&amp;text&#x3D;In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name.) for clarification. </value>
        [DataMember(Name = "urbanization", EmitDefaultValue = false)]
        public string Urbanization { get; set; }

        /// <summary>
        /// Combination of the following applicable &#x60;components&#x60;: * City (&#x60;city&#x60;) * State (&#x60;state&#x60;) * ZIP code (&#x60;zip_code&#x60;) * ZIP+4 (&#x60;zip_code_plus_4&#x60;) 
        /// </summary>
        /// <value>Combination of the following applicable &#x60;components&#x60;: * City (&#x60;city&#x60;) * State (&#x60;state&#x60;) * ZIP code (&#x60;zip_code&#x60;) * ZIP+4 (&#x60;zip_code_plus_4&#x60;) </value>
        [DataMember(Name = "last_line", EmitDefaultValue = false)]
        public string LastLine { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        public UsComponents Components { get; set; }

        /// <summary>
        /// Gets or Sets DeliverabilityAnalysis
        /// </summary>
        [DataMember(Name = "deliverability_analysis", EmitDefaultValue = false)]
        public DeliverabilityAnalysis DeliverabilityAnalysis { get; set; }

        /// <summary>
        /// Gets or Sets LobConfidenceScore
        /// </summary>
        [DataMember(Name = "lob_confidence_score", EmitDefaultValue = false)]
        public LobConfidenceScore LobConfidenceScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsVerification {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  PrimaryLine: ").Append(PrimaryLine).Append("\n");
            sb.Append("  SecondaryLine: ").Append(SecondaryLine).Append("\n");
            sb.Append("  Urbanization: ").Append(Urbanization).Append("\n");
            sb.Append("  LastLine: ").Append(LastLine).Append("\n");
            sb.Append("  Deliverability: ").Append(Deliverability).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  DeliverabilityAnalysis: ").Append(DeliverabilityAnalysis).Append("\n");
            sb.Append("  LobConfidenceScore: ").Append(LobConfidenceScore).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as UsVerification);
        }

        /// <summary>
        /// Returns true if UsVerification instances are equal
        /// </summary>
        /// <param name="input">Instance of UsVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsVerification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.PrimaryLine == input.PrimaryLine ||
                    (this.PrimaryLine != null &&
                    this.PrimaryLine.Equals(input.PrimaryLine))
                ) && 
                (
                    this.SecondaryLine == input.SecondaryLine ||
                    (this.SecondaryLine != null &&
                    this.SecondaryLine.Equals(input.SecondaryLine))
                ) && 
                (
                    this.Urbanization == input.Urbanization ||
                    (this.Urbanization != null &&
                    this.Urbanization.Equals(input.Urbanization))
                ) && 
                (
                    this.LastLine == input.LastLine ||
                    (this.LastLine != null &&
                    this.LastLine.Equals(input.LastLine))
                ) && 
                (
                    this.Deliverability == input.Deliverability ||
                    this.Deliverability.Equals(input.Deliverability)
                ) && 
                (
                    this.Components == input.Components ||
                    (this.Components != null &&
                    this.Components.Equals(input.Components))
                ) && 
                (
                    this.DeliverabilityAnalysis == input.DeliverabilityAnalysis ||
                    (this.DeliverabilityAnalysis != null &&
                    this.DeliverabilityAnalysis.Equals(input.DeliverabilityAnalysis))
                ) && 
                (
                    this.LobConfidenceScore == input.LobConfidenceScore ||
                    (this.LobConfidenceScore != null &&
                    this.LobConfidenceScore.Equals(input.LobConfidenceScore))
                ) && 
                (
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.PrimaryLine != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryLine.GetHashCode();
                }
                if (this.SecondaryLine != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryLine.GetHashCode();
                }
                if (this.Urbanization != null)
                {
                    hashCode = (hashCode * 59) + this.Urbanization.GetHashCode();
                }
                if (this.LastLine != null)
                {
                    hashCode = (hashCode * 59) + this.LastLine.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deliverability.GetHashCode();
                if (this.Components != null)
                {
                    hashCode = (hashCode * 59) + this.Components.GetHashCode();
                }
                if (this.DeliverabilityAnalysis != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverabilityAnalysis.GetHashCode();
                }
                if (this.LobConfidenceScore != null)
                {
                    hashCode = (hashCode * 59) + this.LobConfidenceScore.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"^us_ver_[a-zA-Z0-9_]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // Recipient (string) maxLength
            if (this.Recipient != null && this.Recipient.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Recipient, length must be less than 500.", new [] { "Recipient" });
            }

            // PrimaryLine (string) maxLength
            if (this.PrimaryLine != null && this.PrimaryLine.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrimaryLine, length must be less than 500.", new [] { "PrimaryLine" });
            }

            // SecondaryLine (string) maxLength
            if (this.SecondaryLine != null && this.SecondaryLine.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondaryLine, length must be less than 500.", new [] { "SecondaryLine" });
            }

            // Urbanization (string) maxLength
            if (this.Urbanization != null && this.Urbanization.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Urbanization, length must be less than 500.", new [] { "Urbanization" });
            }

            yield break;
        }
    }

}