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
    /// The &#x60;updateShipmentTrackingDetails&#x60; request.
    /// </summary>
    [DataContract]
    public partial class UpdateShipmentTrackingDetailsRequest :  IEquatable<UpdateShipmentTrackingDetailsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShipmentTrackingDetailsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateShipmentTrackingDetailsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShipmentTrackingDetailsRequest" /> class.
        /// </summary>
        /// <param name="trackingDetails">trackingDetails (required).</param>
        public UpdateShipmentTrackingDetailsRequest(TrackingDetailsInput trackingDetails = default(TrackingDetailsInput))
        {
            // to ensure "trackingDetails" is required (not null)
            if (trackingDetails == null)
            {
                throw new InvalidDataException("trackingDetails is a required property for UpdateShipmentTrackingDetailsRequest and cannot be null");
            }
            else
            {
                this.TrackingDetails = trackingDetails;
            }
        }
        
        /// <summary>
        /// Gets or Sets TrackingDetails
        /// </summary>
        [DataMember(Name="trackingDetails", EmitDefaultValue=false)]
        public TrackingDetailsInput TrackingDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateShipmentTrackingDetailsRequest {\n");
            sb.Append("  TrackingDetails: ").Append(TrackingDetails).Append("\n");
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
            return this.Equals(input as UpdateShipmentTrackingDetailsRequest);
        }

        /// <summary>
        /// Returns true if UpdateShipmentTrackingDetailsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateShipmentTrackingDetailsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateShipmentTrackingDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrackingDetails == input.TrackingDetails ||
                    (this.TrackingDetails != null &&
                    this.TrackingDetails.Equals(input.TrackingDetails))
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
                if (this.TrackingDetails != null)
                    hashCode = hashCode * 59 + this.TrackingDetails.GetHashCode();
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
