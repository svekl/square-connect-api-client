using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the body parameters that can be included in\na request to the **CreateRefund** endpoint.
    /// </summary>
    [DataContract]
    public partial class CreateRefundRequest :  IEquatable<CreateRefundRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRefundRequest" /> class.
        /// Initializes a new instance of the <see cref="CreateRefundRequest" />class.
        /// </summary>
        /// <param name="IdempotencyKey">A value you specify that uniquely identifies this\nrefund among refunds you&#39;ve created for the tender.\n\nIf you&#39;re unsure whether a particular refund succeeded,\nyou can reattempt it with the same idempotency key without\nworrying about duplicating the refund. (required).</param>
        /// <param name="TenderId">The ID of the tender to refund. (required).</param>
        /// <param name="Reason">A description of the reason for the refund..</param>
        /// <param name="AmountMoney">The amount of money to refund. (required).</param>

        public CreateRefundRequest(string IdempotencyKey = null, string TenderId = null, string Reason = null, Money AmountMoney = null)
        {
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for CreateRefundRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
            // to ensure "TenderId" is required (not null)
            if (TenderId == null)
            {
                throw new InvalidDataException("TenderId is a required property for CreateRefundRequest and cannot be null");
            }
            else
            {
                this.TenderId = TenderId;
            }
            // to ensure "AmountMoney" is required (not null)
            if (AmountMoney == null)
            {
                throw new InvalidDataException("AmountMoney is a required property for CreateRefundRequest and cannot be null");
            }
            else
            {
                this.AmountMoney = AmountMoney;
            }
            this.Reason = Reason;
            
        }
        
    
        /// <summary>
        /// A value you specify that uniquely identifies this\nrefund among refunds you&#39;ve created for the tender.\n\nIf you&#39;re unsure whether a particular refund succeeded,\nyou can reattempt it with the same idempotency key without\nworrying about duplicating the refund.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this\nrefund among refunds you&#39;ve created for the tender.\n\nIf you&#39;re unsure whether a particular refund succeeded,\nyou can reattempt it with the same idempotency key without\nworrying about duplicating the refund.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
    
        /// <summary>
        /// The ID of the tender to refund.
        /// </summary>
        /// <value>The ID of the tender to refund.</value>
        [DataMember(Name="tender_id", EmitDefaultValue=false)]
        public string TenderId { get; set; }
    
        /// <summary>
        /// A description of the reason for the refund.
        /// </summary>
        /// <value>A description of the reason for the refund.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
    
        /// <summary>
        /// The amount of money to refund.
        /// </summary>
        /// <value>The amount of money to refund.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRefundRequest {\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  TenderId: ").Append(TenderId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            
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
            return this.Equals(obj as CreateRefundRequest);
        }

        /// <summary>
        /// Returns true if CreateRefundRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateRefundRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRefundRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
                ) && 
                (
                    this.TenderId == other.TenderId ||
                    this.TenderId != null &&
                    this.TenderId.Equals(other.TenderId)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
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
                
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                
                if (this.TenderId != null)
                    hash = hash * 59 + this.TenderId.GetHashCode();
                
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                
                return hash;
            }
        }

    }
}
