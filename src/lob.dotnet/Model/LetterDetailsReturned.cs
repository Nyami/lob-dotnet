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
    /// Properties that the letters in your Creative should have.
    /// </summary>
    [DataContract(Name = "letter_details_returned")]
    public partial class LetterDetailsReturned : IEquatable<LetterDetailsReturned>, IValidatableObject
    {
        /// <summary>
        /// Specifies the location of the address information that will show through the double-window envelope. 
        /// </summary>
        /// <value>Specifies the location of the address information that will show through the double-window envelope. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddressPlacementEnum
        {
            /// <summary>
            /// Enum TopFirstPage for value: top_first_page
            /// </summary>
            [EnumMember(Value = "top_first_page")]
            TopFirstPage = 1,
            

            /// <summary>
            /// Enum InsertBlankPage for value: insert_blank_page
            /// </summary>
            [EnumMember(Value = "insert_blank_page")]
            InsertBlankPage = 2,
            

            /// <summary>
            /// Enum BottomFirstPageCenter for value: bottom_first_page_center
            /// </summary>
            [EnumMember(Value = "bottom_first_page_center")]
            BottomFirstPageCenter = 3,
            

            /// <summary>
            /// Enum BottomFirstPage for value: bottom_first_page
            /// </summary>
            [EnumMember(Value = "bottom_first_page")]
            BottomFirstPage = 4
            

        }


        /// <summary>
        /// Specifies the location of the address information that will show through the double-window envelope. 
        /// </summary>
        /// <value>Specifies the location of the address information that will show through the double-window envelope. </value>
        [DataMember(Name = "address_placement", EmitDefaultValue = false)]
        public AddressPlacementEnum? AddressPlacement { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterDetailsReturned" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LetterDetailsReturned() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LetterDetailsReturned" /> class.
        /// </summary>
        /// <param name="color">Set this key to &#x60;true&#x60; if you would like to print in color, false for black and white. (required).</param>
        /// <param name="cards">A single-element array containing an existing card id in a string format. See [cards](#tag/Cards) for more information. (required).</param>
        /// <param name="addressPlacement">Specifies the location of the address information that will show through the double-window envelope.  (default to AddressPlacementEnum.TopFirstPage).</param>
        /// <param name="customEnvelope">customEnvelope.</param>
        /// <param name="doubleSided">Set this attribute to &#x60;true&#x60; for double sided printing,  &#x60;false&#x60; for for single sided printing. (default to true).</param>
        /// <param name="extraService">Add an extra service to your letter..</param>
        /// <param name="mailType">mailType.</param>
        /// <param name="returnEnvelope">returnEnvelope.</param>
        /// <param name="bleed">Allows for letter bleed. Enabled only with specific feature flags. (default to false).</param>
        /// <param name="fileOriginalUrl">fileOriginalUrl.</param>
        public LetterDetailsReturned(bool color = default(bool), List<string> cards = default(List<string>), AddressPlacementEnum? addressPlacement = AddressPlacementEnum.TopFirstPage, CustomEnvelopeReturned customEnvelope = default(CustomEnvelopeReturned), bool doubleSided = true, string extraService = default(string), MailType mailType = default(MailType), Object returnEnvelope = default(Object), bool bleed = false, string fileOriginalUrl = default(string))
        {
            this.Color = color;
            // to ensure "cards" is required (not null)
            if (cards == null)
            {
                throw new ArgumentNullException("cards is a required property for LetterDetailsReturned and cannot be null");
            }
            this.Cards = cards;
            this.AddressPlacement = addressPlacement;
            this.CustomEnvelope = customEnvelope;
            this.DoubleSided = doubleSided;
            this.ExtraService = extraService;
            this.MailType = mailType;
            this.ReturnEnvelope = returnEnvelope;
            this.Bleed = bleed;
            this.FileOriginalUrl = fileOriginalUrl;
        }

        /// <summary>
        /// Set this key to &#x60;true&#x60; if you would like to print in color, false for black and white.
        /// </summary>
        /// <value>Set this key to &#x60;true&#x60; if you would like to print in color, false for black and white.</value>
        [DataMember(Name = "color", IsRequired = true, EmitDefaultValue = true)]
        public bool Color { get; set; }

        /// <summary>
        /// A single-element array containing an existing card id in a string format. See [cards](#tag/Cards) for more information.
        /// </summary>
        /// <value>A single-element array containing an existing card id in a string format. See [cards](#tag/Cards) for more information.</value>
        [DataMember(Name = "cards", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Cards { get; set; }

        /// <summary>
        /// Gets or Sets CustomEnvelope
        /// </summary>
        [DataMember(Name = "custom_envelope", EmitDefaultValue = false)]
        public CustomEnvelopeReturned CustomEnvelope { get; set; }

        /// <summary>
        /// Set this attribute to &#x60;true&#x60; for double sided printing,  &#x60;false&#x60; for for single sided printing.
        /// </summary>
        /// <value>Set this attribute to &#x60;true&#x60; for double sided printing,  &#x60;false&#x60; for for single sided printing.</value>
        [DataMember(Name = "double_sided", EmitDefaultValue = true)]
        public bool DoubleSided { get; set; }

        /// <summary>
        /// Add an extra service to your letter.
        /// </summary>
        /// <value>Add an extra service to your letter.</value>
        [DataMember(Name = "extra_service", EmitDefaultValue = false)]
        public string ExtraService { get; set; }

        /// <summary>
        /// Gets or Sets MailType
        /// </summary>
        [DataMember(Name = "mail_type", EmitDefaultValue = false)]
        public MailType MailType { get; set; }

        /// <summary>
        /// Gets or Sets ReturnEnvelope
        /// </summary>
        [DataMember(Name = "return_envelope", EmitDefaultValue = false)]
        public Object ReturnEnvelope { get; set; }

        /// <summary>
        /// Allows for letter bleed. Enabled only with specific feature flags.
        /// </summary>
        /// <value>Allows for letter bleed. Enabled only with specific feature flags.</value>
        [DataMember(Name = "bleed", EmitDefaultValue = true)]
        public bool Bleed { get; set; }

        /// <summary>
        /// Gets or Sets FileOriginalUrl
        /// </summary>
        [DataMember(Name = "file_original_url", EmitDefaultValue = false)]
        public string FileOriginalUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LetterDetailsReturned {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
            sb.Append("  AddressPlacement: ").Append(AddressPlacement).Append("\n");
            sb.Append("  CustomEnvelope: ").Append(CustomEnvelope).Append("\n");
            sb.Append("  DoubleSided: ").Append(DoubleSided).Append("\n");
            sb.Append("  ExtraService: ").Append(ExtraService).Append("\n");
            sb.Append("  MailType: ").Append(MailType).Append("\n");
            sb.Append("  ReturnEnvelope: ").Append(ReturnEnvelope).Append("\n");
            sb.Append("  Bleed: ").Append(Bleed).Append("\n");
            sb.Append("  FileOriginalUrl: ").Append(FileOriginalUrl).Append("\n");
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
            return this.Equals(input as LetterDetailsReturned);
        }

        /// <summary>
        /// Returns true if LetterDetailsReturned instances are equal
        /// </summary>
        /// <param name="input">Instance of LetterDetailsReturned to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LetterDetailsReturned input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Color == input.Color ||
                    this.Color.Equals(input.Color)
                ) && 
                (
                    this.Cards == input.Cards ||
                    this.Cards != null &&
                    input.Cards != null &&
                    this.Cards.SequenceEqual(input.Cards)
                ) && 
                (
                    this.AddressPlacement == input.AddressPlacement ||
                    this.AddressPlacement.Equals(input.AddressPlacement)
                ) && 
                (
                    this.CustomEnvelope == input.CustomEnvelope ||
                    (this.CustomEnvelope != null &&
                    this.CustomEnvelope.Equals(input.CustomEnvelope))
                ) && 
                (
                    this.DoubleSided == input.DoubleSided ||
                    this.DoubleSided.Equals(input.DoubleSided)
                ) && 
                (
                    this.ExtraService == input.ExtraService ||
                    (this.ExtraService != null &&
                    this.ExtraService.Equals(input.ExtraService))
                ) && 
                (
                    this.MailType == input.MailType ||
                    (this.MailType != null &&
                    this.MailType.Equals(input.MailType))
                ) && 
                (
                    this.ReturnEnvelope == input.ReturnEnvelope ||
                    (this.ReturnEnvelope != null &&
                    this.ReturnEnvelope.Equals(input.ReturnEnvelope))
                ) && 
                (
                    this.Bleed == input.Bleed ||
                    this.Bleed.Equals(input.Bleed)
                ) && 
                (
                    this.FileOriginalUrl == input.FileOriginalUrl ||
                    (this.FileOriginalUrl != null &&
                    this.FileOriginalUrl.Equals(input.FileOriginalUrl))
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
                hashCode = (hashCode * 59) + this.Color.GetHashCode();
                if (this.Cards != null)
                {
                    hashCode = (hashCode * 59) + this.Cards.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AddressPlacement.GetHashCode();
                if (this.CustomEnvelope != null)
                {
                    hashCode = (hashCode * 59) + this.CustomEnvelope.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DoubleSided.GetHashCode();
                if (this.ExtraService != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraService.GetHashCode();
                }
                if (this.MailType != null)
                {
                    hashCode = (hashCode * 59) + this.MailType.GetHashCode();
                }
                if (this.ReturnEnvelope != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnEnvelope.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Bleed.GetHashCode();
                if (this.FileOriginalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileOriginalUrl.GetHashCode();
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
