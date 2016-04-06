using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Represents a transaction processed with Square, either with the\nConnect API or with Square Register.
    /// </summary>
    [DataContract]
    public partial class Transaction :  IEquatable<Transaction>
    { 
    
        /// <summary>
        /// The product that processed the transaction.
        /// </summary>
        /// <value>The product that processed the transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductEnum {
            
            [EnumMember(Value = "REGISTER")]
            Register,
            
            [EnumMember(Value = "EXTERNAL_API")]
            ExternalApi,
            
            [EnumMember(Value = "BILLING")]
            Billing,
            
            [EnumMember(Value = "APPOINTMENTS")]
            Appointments,
            
            [EnumMember(Value = "INVOICES")]
            Invoices,
            
            [EnumMember(Value = "ONLINE_STORE")]
            OnlineStore,
            
            [EnumMember(Value = "PAYROLL")]
            Payroll,
            
            [EnumMember(Value = "OTHER")]
            Other
        }

    
        /// <summary>
        /// The product that processed the transaction.
        /// </summary>
        /// <value>The product that processed the transaction.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public ProductEnum? Product { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// Initializes a new instance of the <see cref="Transaction" />class.
        /// </summary>
        /// <param name="Id">The transaction&#39;s unique ID..</param>
        /// <param name="LocationId">The ID of the transaction&#39;s associated location..</param>
        /// <param name="CreatedAt">The time when the transaction was created, in RFC 3339 format..</param>
        /// <param name="Tenders">Descriptions of the tenders used to pay for the transaction..</param>
        /// <param name="Refunds">An array of any refunds associated with the transaction..</param>
        /// <param name="ReferenceId">If the transaction was created with the **Charge** endpoint, this\nvalue is the same as the value provided as the `reference_id` parameter\nin the request to that endpoint..</param>
        /// <param name="Product">The product that processed the transaction..</param>

        public Transaction(string Id = null, string LocationId = null, string CreatedAt = null, List<Tender> Tenders = null, List<Refund> Refunds = null, string ReferenceId = null, ProductEnum? Product = null)
        {
            this.Id = Id;
            this.LocationId = LocationId;
            this.CreatedAt = CreatedAt;
            this.Tenders = Tenders;
            this.Refunds = Refunds;
            this.ReferenceId = ReferenceId;
            this.Product = Product;
            
        }
        
    
        /// <summary>
        /// The transaction&#39;s unique ID.
        /// </summary>
        /// <value>The transaction&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The ID of the transaction&#39;s associated location.
        /// </summary>
        /// <value>The ID of the transaction&#39;s associated location.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
    
        /// <summary>
        /// The time when the transaction was created, in RFC 3339 format.
        /// </summary>
        /// <value>The time when the transaction was created, in RFC 3339 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// Descriptions of the tenders used to pay for the transaction.
        /// </summary>
        /// <value>Descriptions of the tenders used to pay for the transaction.</value>
        [DataMember(Name="tenders", EmitDefaultValue=false)]
        public List<Tender> Tenders { get; set; }
    
        /// <summary>
        /// An array of any refunds associated with the transaction.
        /// </summary>
        /// <value>An array of any refunds associated with the transaction.</value>
        [DataMember(Name="refunds", EmitDefaultValue=false)]
        public List<Refund> Refunds { get; set; }
    
        /// <summary>
        /// If the transaction was created with the **Charge** endpoint, this\nvalue is the same as the value provided as the `reference_id` parameter\nin the request to that endpoint.
        /// </summary>
        /// <value>If the transaction was created with the **Charge** endpoint, this\nvalue is the same as the value provided as the `reference_id` parameter\nin the request to that endpoint.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Tenders: ").Append(Tenders).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            
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
            return this.Equals(obj as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="other">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Tenders == other.Tenders ||
                    this.Tenders != null &&
                    this.Tenders.SequenceEqual(other.Tenders)
                ) && 
                (
                    this.Refunds == other.Refunds ||
                    this.Refunds != null &&
                    this.Refunds.SequenceEqual(other.Refunds)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.Tenders != null)
                    hash = hash * 59 + this.Tenders.GetHashCode();
                
                if (this.Refunds != null)
                    hash = hash * 59 + this.Refunds.GetHashCode();
                
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                
                return hash;
            }
        }

    }
}
