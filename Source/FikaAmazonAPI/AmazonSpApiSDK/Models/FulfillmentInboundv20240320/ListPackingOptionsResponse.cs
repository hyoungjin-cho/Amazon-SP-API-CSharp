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
    /// &#x60;listPackingOptions&#x60; response.
    /// </summary>
    [DataContract]
    public partial class ListPackingOptionsResponse :  IEquatable<ListPackingOptionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPackingOptionsResponse" /> class.
        /// </summary>
        /// <param name="packingOptions">List of packing options. (required).</param>
        /// <param name="pagination">pagination.</param>
        public ListPackingOptionsResponse(List<PackingOption> packingOptions = default(List<PackingOption>), Pagination pagination = default(Pagination))
        {
            // to ensure "packingOptions" is required (not null)
            if (packingOptions == null)
            {
                throw new InvalidDataException("packingOptions is a required property for ListPackingOptionsResponse and cannot be null");
            }
            else
            {
                this.PackingOptions = packingOptions;
            }
            this.Pagination = pagination;
        }
        public ListPackingOptionsResponse()
        {
            this.PackingOptions = default(List<PackingOption>);
            this.Pagination = default(Pagination);
        }

        /// <summary>
        /// List of packing options.
        /// </summary>
        /// <value>List of packing options.</value>
        [DataMember(Name="packingOptions", EmitDefaultValue=false)]
        public List<PackingOption> PackingOptions { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPackingOptionsResponse {\n");
            sb.Append("  PackingOptions: ").Append(PackingOptions).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as ListPackingOptionsResponse);
        }

        /// <summary>
        /// Returns true if ListPackingOptionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListPackingOptionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListPackingOptionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackingOptions == input.PackingOptions ||
                    this.PackingOptions != null &&
                    this.PackingOptions.SequenceEqual(input.PackingOptions)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.PackingOptions != null)
                    hashCode = hashCode * 59 + this.PackingOptions.GetHashCode();
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
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
            yield break;
        }
    }

}
