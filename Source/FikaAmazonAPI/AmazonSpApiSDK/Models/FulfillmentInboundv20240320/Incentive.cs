/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Contains details about cost related modifications to the placement cost.
    /// </summary>
    [DataContract]
    public partial class Incentive :  IEquatable<Incentive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Incentive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Incentive() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Incentive" /> class.
        /// </summary>
        /// <param name="description">Description of the incentive. (required).</param>
        /// <param name="target">Target of the incentive. Can be &#39;Placement Services&#39; or &#39;Fulfillment Fee Discount&#39;. (required).</param>
        /// <param name="type">Type of incentive. Can be &#x60;FEE&#x60; or &#x60;DISCOUNT&#x60;. (required).</param>
        /// <param name="value">value (required).</param>
        public Incentive(string description = default(string), string target = default(string), string type = default(string), Currency value = default(Currency))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Incentive and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "target" is required (not null)
            if (target == null)
            {
                throw new InvalidDataException("target is a required property for Incentive and cannot be null");
            }
            else
            {
                this.Target = target;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Incentive and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for Incentive and cannot be null");
            }
            else
            {
                this.Value = value;
            }
        }
        
        /// <summary>
        /// Description of the incentive.
        /// </summary>
        /// <value>Description of the incentive.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Target of the incentive. Can be &#39;Placement Services&#39; or &#39;Fulfillment Fee Discount&#39;.
        /// </summary>
        /// <value>Target of the incentive. Can be &#39;Placement Services&#39; or &#39;Fulfillment Fee Discount&#39;.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }

        /// <summary>
        /// Type of incentive. Can be &#x60;FEE&#x60; or &#x60;DISCOUNT&#x60;.
        /// </summary>
        /// <value>Type of incentive. Can be &#x60;FEE&#x60; or &#x60;DISCOUNT&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Currency Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Incentive {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Incentive);
        }

        /// <summary>
        /// Returns true if Incentive instances are equal
        /// </summary>
        /// <param name="input">Instance of Incentive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Incentive input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            // Target (string) maxLength
            if(this.Target != null && this.Target.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Target, length must be less than 1024.", new [] { "Target" });
            }

            // Target (string) minLength
            if(this.Target != null && this.Target.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Target, length must be greater than 1.", new [] { "Target" });
            }

            // Type (string) maxLength
            if(this.Type != null && this.Type.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be less than 1024.", new [] { "Type" });
            }

            // Type (string) minLength
            if(this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            yield break;
        }
    }

}
