using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the fields that are included in the response body of\na request to the **Charge** endpoint.\n\nOne of `errors` or `transaction` is present in a given response (never both).
    /// </summary>
    [DataContract]
    public partial class ChargeResponse :  IEquatable<ChargeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeResponse" /> class.
        /// Initializes a new instance of the <see cref="ChargeResponse" />class.
        /// </summary>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        /// <param name="Transaction">The details of the created transaction..</param>

        public ChargeResponse(List<Error> Errors = null, Transaction Transaction = null)
        {
            this.Errors = Errors;
            this.Transaction = Transaction;
            
        }
        
    
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
    
        /// <summary>
        /// The details of the created transaction.
        /// </summary>
        /// <value>The details of the created transaction.</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            
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
            return this.Equals(obj as ChargeResponse);
        }

        /// <summary>
        /// Returns true if ChargeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ChargeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeResponse other)
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
                    this.Transaction == other.Transaction ||
                    this.Transaction != null &&
                    this.Transaction.Equals(other.Transaction)
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
                
                if (this.Transaction != null)
                    hash = hash * 59 + this.Transaction.GetHashCode();
                
                return hash;
            }
        }

    }
}
