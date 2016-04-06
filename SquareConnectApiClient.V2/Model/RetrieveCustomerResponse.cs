using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the fields that are included in the response body of\na request to the **RetrieveCustomer** endpoint.\n\nOne of `errors` or `customer` is present in a given response (never both).
    /// </summary>
    [DataContract]
    public partial class RetrieveCustomerResponse :  IEquatable<RetrieveCustomerResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCustomerResponse" /> class.
        /// Initializes a new instance of the <see cref="RetrieveCustomerResponse" />class.
        /// </summary>
        /// <param name="Errors">.</param>
        /// <param name="Customer">.</param>

        public RetrieveCustomerResponse(List<Error> Errors = null, Customer Customer = null)
        {
            this.Errors = Errors;
            this.Customer = Customer;
            
        }
        
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public Customer Customer { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveCustomerResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            
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
            return this.Equals(obj as RetrieveCustomerResponse);
        }

        /// <summary>
        /// Returns true if RetrieveCustomerResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RetrieveCustomerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveCustomerResponse other)
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
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
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
                
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                
                return hash;
            }
        }

    }
}
