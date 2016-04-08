using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the fields that are included in the response body of\na request to the **ListTenderRefunds** endpoint.\n\nOne of `errors` or `refunds` is present in a given response (never both).
    /// </summary>
    [DataContract]
    public class ListRefundsResponse :  IEquatable<ListRefundsResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRefundsResponse" /> class.
        /// Initializes a new instance of the <see cref="ListRefundsResponse" />class.
        /// </summary>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        /// <param name="Refunds">An array of refunds that match your query..</param>
        /// <param name="Cursor">A pagination cursor for retrieving the next set of results,\nif any remain.\n\nProvide this value as the `cursor` parameter in a subsequent request\nto the **ListTenderRefunds** endpoint..</param>

        public ListRefundsResponse(List<Error> Errors = null, List<Refund> Refunds = null, string Cursor = null)
        {
            this.Errors = Errors;
            this.Refunds = Refunds;
            this.Cursor = Cursor;
            
        }
        
    
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
    
        /// <summary>
        /// An array of refunds that match your query.
        /// </summary>
        /// <value>An array of refunds that match your query.</value>
        [DataMember(Name="refunds", EmitDefaultValue=false)]
        public List<Refund> Refunds { get; set; }
    
        /// <summary>
        /// A pagination cursor for retrieving the next set of results,\nif any remain.\n\nProvide this value as the `cursor` parameter in a subsequent request\nto the **ListTenderRefunds** endpoint.
        /// </summary>
        /// <value>A pagination cursor for retrieving the next set of results,\nif any remain.\n\nProvide this value as the `cursor` parameter in a subsequent request\nto the **ListTenderRefunds** endpoint.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRefundsResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ListRefundsResponse);
        }

        /// <summary>
        /// Returns true if ListRefundsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ListRefundsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListRefundsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Refunds == other.Refunds ||
                    this.Refunds != null &&
                    this.Refunds.SequenceEqual(other.Refunds)
                ) && 
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                
                if (this.Refunds != null)
                    hash = hash * 59 + this.Refunds.GetHashCode();
                
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                
                return hash;
            }
        }

    }
}
