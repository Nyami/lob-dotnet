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
    /// CheckEditable
    /// </summary>
    [DataContract(Name = "check_editable")]
    public partial class CheckEditable : IEquatable<CheckEditable>, IValidatableObject
    {
        /// <summary>
        /// Checks must be sent &#x60;usps_first_class&#x60;
        /// </summary>
        /// <value>Checks must be sent &#x60;usps_first_class&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MailTypeEnum
        {
            /// <summary>
            /// Enum UspsFirstClass for value: usps_first_class
            /// </summary>
            [EnumMember(Value = "usps_first_class")]
            UspsFirstClass = 1
            

        }


        /// <summary>
        /// Checks must be sent &#x60;usps_first_class&#x60;
        /// </summary>
        /// <value>Checks must be sent &#x60;usps_first_class&#x60;</value>
        [DataMember(Name = "mail_type", EmitDefaultValue = false)]
        public MailTypeEnum? MailType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckEditable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckEditable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckEditable" /> class.
        /// </summary>
        /// <param name="from">Must either be an address ID or an inline object with correct address parameters. (required).</param>
        /// <param name="to">Must either be an address ID or an inline object with correct address parameters. (required).</param>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="amount">The payment amount to be sent in US dollars. (required).</param>
        /// <param name="logo">Accepts a remote URL or local file upload to an image to print (in grayscale) in the upper-left corner of your check..</param>
        /// <param name="checkBottom">The artwork to use on the bottom of the check page.  Notes: - HTML merge variables should not include delimiting whitespace. - PDF, PNG, and JPGs must be sized at 8.5\&quot;x11\&quot; at 300 DPI, while supplied HTML will be rendered and trimmed to fit on a 8.5\&quot;x11\&quot; page. - The check bottom will always be printed in black &amp; white. - Must conform to [this template](https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/check_bottom_template.pdf).  Need more help? Consult our [HTML examples](#section/HTML-Examples)..</param>
        /// <param name="attachment">A document to include with the check..</param>
        /// <param name="description">An internal description that identifies this resource. Must be no longer than 255 characters. .</param>
        /// <param name="metadata">Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="mergeVariables">You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string..</param>
        /// <param name="sendDate">A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC..</param>
        /// <param name="mailType">Checks must be sent &#x60;usps_first_class&#x60; (default to MailTypeEnum.UspsFirstClass).</param>
        /// <param name="memo">Text to include on the memo line of the check..</param>
        /// <param name="checkNumber">An integer that designates the check number..</param>
        /// <param name="message">Max of 400 characters to be included at the bottom of the check page..</param>
        /// <param name="billingGroupId">An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information..</param>
        public CheckEditable(string from = default(string), string to = default(string), string bankAccount = default(string), float amount = default(float), string logo = default(string), string checkBottom = default(string), string attachment = default(string), string description = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), Object mergeVariables = default(Object), DateTime sendDate = default(DateTime), MailTypeEnum? mailType = MailTypeEnum.UspsFirstClass, string memo = default(string), int checkNumber = default(int), string message = default(string), string billingGroupId = default(string))
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for CheckEditable and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for CheckEditable and cannot be null");
            }
            this.To = to;
            // to ensure "bankAccount" is required (not null)
            if (bankAccount == null)
            {
                throw new ArgumentNullException("bankAccount is a required property for CheckEditable and cannot be null");
            }
            this.BankAccount = bankAccount;
            this.Amount = amount;
            this.Logo = logo;
            this.CheckBottom = checkBottom;
            this.Attachment = attachment;
            this.Description = description;
            this.Metadata = metadata;
            this.MergeVariables = mergeVariables;
            this.SendDate = sendDate;
            this.MailType = mailType;
            this.Memo = memo;
            this.CheckNumber = checkNumber;
            this.Message = message;
            this.BillingGroupId = billingGroupId;
        }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters.
        /// </summary>
        /// <value>Must either be an address ID or an inline object with correct address parameters.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters.
        /// </summary>
        /// <value>Must either be an address ID or an inline object with correct address parameters.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", IsRequired = true, EmitDefaultValue = false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// The payment amount to be sent in US dollars.
        /// </summary>
        /// <value>The payment amount to be sent in US dollars.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public float Amount { get; set; }

        /// <summary>
        /// Accepts a remote URL or local file upload to an image to print (in grayscale) in the upper-left corner of your check.
        /// </summary>
        /// <value>Accepts a remote URL or local file upload to an image to print (in grayscale) in the upper-left corner of your check.</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// The artwork to use on the bottom of the check page.  Notes: - HTML merge variables should not include delimiting whitespace. - PDF, PNG, and JPGs must be sized at 8.5\&quot;x11\&quot; at 300 DPI, while supplied HTML will be rendered and trimmed to fit on a 8.5\&quot;x11\&quot; page. - The check bottom will always be printed in black &amp; white. - Must conform to [this template](https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/check_bottom_template.pdf).  Need more help? Consult our [HTML examples](#section/HTML-Examples).
        /// </summary>
        /// <value>The artwork to use on the bottom of the check page.  Notes: - HTML merge variables should not include delimiting whitespace. - PDF, PNG, and JPGs must be sized at 8.5\&quot;x11\&quot; at 300 DPI, while supplied HTML will be rendered and trimmed to fit on a 8.5\&quot;x11\&quot; page. - The check bottom will always be printed in black &amp; white. - Must conform to [this template](https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/check_bottom_template.pdf).  Need more help? Consult our [HTML examples](#section/HTML-Examples).</value>
        [DataMember(Name = "check_bottom", EmitDefaultValue = false)]
        public string CheckBottom { get; set; }

        /// <summary>
        /// A document to include with the check.
        /// </summary>
        /// <value>A document to include with the check.</value>
        [DataMember(Name = "attachment", EmitDefaultValue = false)]
        public string Attachment { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters. 
        /// </summary>
        /// <value>An internal description that identifies this resource. Must be no longer than 255 characters. </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        /// <value>Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.
        /// </summary>
        /// <value>You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.</value>
        [DataMember(Name = "merge_variables", EmitDefaultValue = false)]
        public Object MergeVariables { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC.</value>
        [DataMember(Name = "send_date", EmitDefaultValue = false)]
        public DateTime SendDate { get; set; }

        /// <summary>
        /// Text to include on the memo line of the check.
        /// </summary>
        /// <value>Text to include on the memo line of the check.</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// An integer that designates the check number.
        /// </summary>
        /// <value>An integer that designates the check number.</value>
        [DataMember(Name = "check_number", EmitDefaultValue = false)]
        public int CheckNumber { get; set; }

        /// <summary>
        /// Max of 400 characters to be included at the bottom of the check page.
        /// </summary>
        /// <value>Max of 400 characters to be included at the bottom of the check page.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information.
        /// </summary>
        /// <value>An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information.</value>
        [DataMember(Name = "billing_group_id", EmitDefaultValue = false)]
        public string BillingGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckEditable {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  CheckBottom: ").Append(CheckBottom).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MergeVariables: ").Append(MergeVariables).Append("\n");
            sb.Append("  SendDate: ").Append(SendDate).Append("\n");
            sb.Append("  MailType: ").Append(MailType).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  BillingGroupId: ").Append(BillingGroupId).Append("\n");
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
            return this.Equals(input as CheckEditable);
        }

        /// <summary>
        /// Returns true if CheckEditable instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckEditable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckEditable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.CheckBottom == input.CheckBottom ||
                    (this.CheckBottom != null &&
                    this.CheckBottom.Equals(input.CheckBottom))
                ) && 
                (
                    this.Attachment == input.Attachment ||
                    (this.Attachment != null &&
                    this.Attachment.Equals(input.Attachment))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.MergeVariables == input.MergeVariables ||
                    (this.MergeVariables != null &&
                    this.MergeVariables.Equals(input.MergeVariables))
                ) && 
                (
                    this.SendDate == input.SendDate ||
                    (this.SendDate != null &&
                    this.SendDate.Equals(input.SendDate))
                ) && 
                (
                    this.MailType == input.MailType ||
                    this.MailType.Equals(input.MailType)
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.CheckNumber == input.CheckNumber ||
                    this.CheckNumber.Equals(input.CheckNumber)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.BillingGroupId == input.BillingGroupId ||
                    (this.BillingGroupId != null &&
                    this.BillingGroupId.Equals(input.BillingGroupId))
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
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.CheckBottom != null)
                {
                    hashCode = (hashCode * 59) + this.CheckBottom.GetHashCode();
                }
                if (this.Attachment != null)
                {
                    hashCode = (hashCode * 59) + this.Attachment.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.MergeVariables != null)
                {
                    hashCode = (hashCode * 59) + this.MergeVariables.GetHashCode();
                }
                if (this.SendDate != null)
                {
                    hashCode = (hashCode * 59) + this.SendDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MailType.GetHashCode();
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CheckNumber.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.BillingGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.BillingGroupId.GetHashCode();
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
            // Amount (float) maximum
            if (this.Amount > (float)999999.99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value less than or equal to 999999.99.", new [] { "Amount" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            // Memo (string) maxLength
            if (this.Memo != null && this.Memo.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Memo, length must be less than 40.", new [] { "Memo" });
            }

            // CheckNumber (int) maximum
            if (this.CheckNumber > (int)500000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckNumber, must be a value less than or equal to 500000000.", new [] { "CheckNumber" });
            }

            // CheckNumber (int) minimum
            if (this.CheckNumber < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckNumber, must be a value greater than or equal to 1.", new [] { "CheckNumber" });
            }

            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 400.", new [] { "Message" });
            }

            yield break;
        }
    }

}
