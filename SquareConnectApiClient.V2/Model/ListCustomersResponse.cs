using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the fields that are included in the response body of\na request to the **ListCustomers** endpoint.\n\nOne of `errors` or `customers` is present in a given response (never both).
    /// </summary>
    [DataContract]
    public class ListCustomersResponse :  IEquatable<ListCustomersResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomersResponse" /> class.
        /// Initializes a new instance of the <see cref="ListCustomersResponse" />class.
        /// </summary>
        /// <param name="Errors">.</param>
        /// <param name="Customers">.</param>
        /// <param name="Cursor">.</param>

        public ListCustomersResponse(List<Error> Errors = null, List<Customer> Customers = null, string Cursor = null)
        {
            this.Errors = Errors;
            this.Customers = Customers;
            this.Cursor = Cursor;
            
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
        [DataMember(Name="customers", EmitDefaultValue=false)]
        public List<Customer> Customers { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCustomersResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Customers: ").Append(Customers).Append("\n");
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
            return this.Equals(obj as ListCustomersResponse);
        }

        /// <summary>
        /// Returns true if ListCustomersResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ListCustomersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListCustomersResponse other)
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
                    this.Customers == other.Customers ||
                    this.Customers != null &&
                    this.Customers.SequenceEqual(other.Customers)
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
                
                if (this.Customers != null)
                    hash = hash * 59 + this.Customers.GetHashCode();
                
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                
                return hash;
            }
        }

    }
}
