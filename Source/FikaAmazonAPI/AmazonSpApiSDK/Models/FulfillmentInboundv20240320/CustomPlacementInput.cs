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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Provide units going to the warehouse.
    /// </summary>
    [DataContract]
    public partial class CustomPlacementInput :  IEquatable<CustomPlacementInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPlacementInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomPlacementInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPlacementInput" /> class.
        /// </summary>
        /// <param name="items">Items included while creating Inbound Plan. (required).</param>
        /// <param name="warehouseId">Warehouse Id. (required).</param>
        public CustomPlacementInput(List<ItemInput> items = default(List<ItemInput>), string warehouseId = default(string))
        {
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for CustomPlacementInput and cannot be null");
            }
            else
            {
                this.Items = items;
            }
            // to ensure "warehouseId" is required (not null)
            if (warehouseId == null)
            {
                throw new InvalidDataException("warehouseId is a required property for CustomPlacementInput and cannot be null");
            }
            else
            {
                this.WarehouseId = warehouseId;
            }
        }
        
        /// <summary>
        /// Items included while creating Inbound Plan.
        /// </summary>
        /// <value>Items included while creating Inbound Plan.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ItemInput> Items { get; set; }

        /// <summary>
        /// Warehouse Id.
        /// </summary>
        /// <value>Warehouse Id.</value>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public string WarehouseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomPlacementInput {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
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
            return this.Equals(input as CustomPlacementInput);
        }

        /// <summary>
        /// Returns true if CustomPlacementInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomPlacementInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomPlacementInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
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
            // WarehouseId (string) maxLength
            if(this.WarehouseId != null && this.WarehouseId.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WarehouseId, length must be less than 1024.", new [] { "WarehouseId" });
            }

            // WarehouseId (string) minLength
            if(this.WarehouseId != null && this.WarehouseId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WarehouseId, length must be greater than 1.", new [] { "WarehouseId" });
            }

            yield break;
        }
    }

}
