using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the fields that are included in the response body of\na request to the **ListTransactions** endpoint.\n\nOne of `errors` or `transactions` is present in a given response (never both).
    /// </summary>
    [DataContract]
    public class ListTransactionsResponse :  IEquatable<ListTransactionsResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsResponse" /> class.
        /// Initializes a new instance of the <see cref="ListTransactionsResponse" />class.
        /// </summary>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        /// <param name="Transactions">An array of transactions that match your query..</param>
        /// <param name="Cursor">A pagination cursor for retrieving the next set of results,\nif any remain.\n\nProvide this value as the `cursor` parameter in a subsequent request\nto the **ListTransactions** endpoint..</param>

        public ListTransactionsResponse(List<Error> Errors = null, List<Transaction> Transactions = null, string Cursor = null)
        {
            this.Errors = Errors;
            this.Transactions = Transactions;
            this.Cursor = Cursor;
            
        }
        
    
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
    
        /// <summary>
        /// An array of transactions that match your query.
        /// </summary>
        /// <value>An array of transactions that match your query.</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<Transaction> Transactions { get; set; }
    
        /// <summary>
        /// A pagination cursor for retrieving the next set of results,\nif any remain.\n\nProvide this value as the `cursor` parameter in a subsequent request\nto the **ListTransactions** endpoint.
        /// </summary>
        /// <value>A pagination cursor for retrieving the next set of results,\nif any remain.\n\nProvide this value as the `cursor` parameter in a subsequent request\nto the **ListTransactions** endpoint.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransactionsResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(obj as ListTransactionsResponse);
        }

        /// <summary>
        /// Returns true if ListTransactionsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ListTransactionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTransactionsResponse other)
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
                    this.Transactions == other.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(other.Transactions)
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
                
                if (this.Transactions != null)
                    hash = hash * 59 + this.Transactions.GetHashCode();
                
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                
                return hash;
            }
        }

    }
}
