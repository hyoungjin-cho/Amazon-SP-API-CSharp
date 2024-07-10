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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// A light-weight inbound plan.
    /// </summary>
    [DataContract]
    public partial class InboundPlanSummary :  IEquatable<InboundPlanSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPlanSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundPlanSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPlanSummary" /> class.
        /// </summary>
        /// <param name="contactInformation">contactInformation (required).</param>
        /// <param name="createdAt">The ISO 8601 datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;. (required).</param>
        /// <param name="inboundPlanId">Identifier to an inbound plan. (required).</param>
        /// <param name="lastUpdatedAt">ISO 8601 datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;. (required).</param>
        /// <param name="marketplaceIds">Marketplace IDs. (required).</param>
        /// <param name="name">Human-readable name of the inbound plan. (required).</param>
        /// <param name="sourceAddress">sourceAddress (required).</param>
        /// <param name="status">Current status of the inbound plan. Can be &#39;ACTIVE&#39;, &#39;VOIDED&#39;, or &#39;SHIPPED&#39;. (required).</param>
        public InboundPlanSummary(ContactInformation contactInformation = default(ContactInformation), DateTime? createdAt = default(DateTime?), string inboundPlanId = default(string), DateTime? lastUpdatedAt = default(DateTime?), List<string> marketplaceIds = default(List<string>), string name = default(string), Address sourceAddress = default(Address), string status = default(string))
        {
            // to ensure "contactInformation" is required (not null)
            if (contactInformation == null)
            {
                throw new InvalidDataException("contactInformation is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.ContactInformation = contactInformation;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "inboundPlanId" is required (not null)
            if (inboundPlanId == null)
            {
                throw new InvalidDataException("inboundPlanId is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.InboundPlanId = inboundPlanId;
            }
            // to ensure "lastUpdatedAt" is required (not null)
            if (lastUpdatedAt == null)
            {
                throw new InvalidDataException("lastUpdatedAt is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.LastUpdatedAt = lastUpdatedAt;
            }
            // to ensure "marketplaceIds" is required (not null)
            if (marketplaceIds == null)
            {
                throw new InvalidDataException("marketplaceIds is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.MarketplaceIds = marketplaceIds;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "sourceAddress" is required (not null)
            if (sourceAddress == null)
            {
                throw new InvalidDataException("sourceAddress is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.SourceAddress = sourceAddress;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for InboundPlanSummary and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }
        
        /// <summary>
        /// Gets or Sets ContactInformation
        /// </summary>
        [DataMember(Name="contactInformation", EmitDefaultValue=false)]
        public ContactInformation ContactInformation { get; set; }

        /// <summary>
        /// The ISO 8601 datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;.
        /// </summary>
        /// <value>The ISO 8601 datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Identifier to an inbound plan.
        /// </summary>
        /// <value>Identifier to an inbound plan.</value>
        [DataMember(Name="inboundPlanId", EmitDefaultValue=false)]
        public string InboundPlanId { get; set; }

        /// <summary>
        /// ISO 8601 datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;.
        /// </summary>
        /// <value>ISO 8601 datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;.</value>
        [DataMember(Name="lastUpdatedAt", EmitDefaultValue=false)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Marketplace IDs.
        /// </summary>
        /// <value>Marketplace IDs.</value>
        [DataMember(Name="marketplaceIds", EmitDefaultValue=false)]
        public List<string> MarketplaceIds { get; set; }

        /// <summary>
        /// Human-readable name of the inbound plan.
        /// </summary>
        /// <value>Human-readable name of the inbound plan.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SourceAddress
        /// </summary>
        [DataMember(Name="sourceAddress", EmitDefaultValue=false)]
        public Address SourceAddress { get; set; }

        /// <summary>
        /// Current status of the inbound plan. Can be &#39;ACTIVE&#39;, &#39;VOIDED&#39;, or &#39;SHIPPED&#39;.
        /// </summary>
        /// <value>Current status of the inbound plan. Can be &#39;ACTIVE&#39;, &#39;VOIDED&#39;, or &#39;SHIPPED&#39;.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboundPlanSummary {\n");
            sb.Append("  ContactInformation: ").Append(ContactInformation).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  InboundPlanId: ").Append(InboundPlanId).Append("\n");
            sb.Append("  LastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
            sb.Append("  MarketplaceIds: ").Append(MarketplaceIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SourceAddress: ").Append(SourceAddress).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as InboundPlanSummary);
        }

        /// <summary>
        /// Returns true if InboundPlanSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundPlanSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundPlanSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactInformation == input.ContactInformation ||
                    (this.ContactInformation != null &&
                    this.ContactInformation.Equals(input.ContactInformation))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.InboundPlanId == input.InboundPlanId ||
                    (this.InboundPlanId != null &&
                    this.InboundPlanId.Equals(input.InboundPlanId))
                ) && 
                (
                    this.LastUpdatedAt == input.LastUpdatedAt ||
                    (this.LastUpdatedAt != null &&
                    this.LastUpdatedAt.Equals(input.LastUpdatedAt))
                ) && 
                (
                    this.MarketplaceIds == input.MarketplaceIds ||
                    this.MarketplaceIds != null &&
                    this.MarketplaceIds.SequenceEqual(input.MarketplaceIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SourceAddress == input.SourceAddress ||
                    (this.SourceAddress != null &&
                    this.SourceAddress.Equals(input.SourceAddress))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ContactInformation != null)
                    hashCode = hashCode * 59 + this.ContactInformation.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.InboundPlanId != null)
                    hashCode = hashCode * 59 + this.InboundPlanId.GetHashCode();
                if (this.LastUpdatedAt != null)
                    hashCode = hashCode * 59 + this.LastUpdatedAt.GetHashCode();
                if (this.MarketplaceIds != null)
                    hashCode = hashCode * 59 + this.MarketplaceIds.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SourceAddress != null)
                    hashCode = hashCode * 59 + this.SourceAddress.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            // InboundPlanId (string) maxLength
            if(this.InboundPlanId != null && this.InboundPlanId.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InboundPlanId, length must be less than 38.", new [] { "InboundPlanId" });
            }

            // InboundPlanId (string) minLength
            if(this.InboundPlanId != null && this.InboundPlanId.Length < 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InboundPlanId, length must be greater than 38.", new [] { "InboundPlanId" });
            }

            // InboundPlanId (string) pattern
            Regex regexInboundPlanId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
            if (false == regexInboundPlanId.Match(this.InboundPlanId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InboundPlanId, must match a pattern of " + regexInboundPlanId, new [] { "InboundPlanId" });
            }

            // Status (string) maxLength
            if(this.Status != null && this.Status.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be less than 1024.", new [] { "Status" });
            }

            // Status (string) minLength
            if(this.Status != null && this.Status.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            yield break;
        }
    }

}
