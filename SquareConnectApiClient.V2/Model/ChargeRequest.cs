using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the parameters that can be included in the body of\na request to the **Charge** endpoint.
    /// </summary>
    [DataContract]
    public partial class ChargeRequest :  IEquatable<ChargeRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRequest" /> class.
        /// Initializes a new instance of the <see cref="ChargeRequest" />class.
        /// </summary>
        /// <param name="IdempotencyKey">A value you specify that uniquely identifies this\ntransaction among transactions you&#39;ve created.\n\nIf you&#39;re unsure whether a particular transaction succeeded,\nyou can reattempt it with the same idempotency key without\nworrying about double-charging the buyer. Note that *all other fields*\nmust also remain identical in your followup request, or an error will occur. (required).</param>
        /// <param name="AmountMoney">The amount of money to collect in the transaction. (required).</param>
        /// <param name="CardNonce">A nonce representing the credit card to charge for this transaction.\nDo not provide a value for this field if you provide a value for\n`customer_card_id`..</param>
        /// <param name="CustomerCardId">The ID of the customer card on file to charge for this transaction. Do\nnot provide a value for this field if you provide a value for `card_nonce`..</param>
        /// <param name="DelayCapture">If `true`, the request will only perform an Auth on the provided\ncard. You can then later perform either a Capture (with the\n*CaptureTransaction** endpoint) or a Void (with the **VoidTransation**\nendpoint..</param>
        /// <param name="ReferenceId">An optional ID you can associate with the transaction for your own\npurposes (such as to associate the transaction with an entity ID in your\nown database)..</param>
        /// <param name="Note">An optional note to associate with the transaction..</param>
        /// <param name="CustomerId">The ID of the customer to associate this transaction with. This field\nis required if you provide a value for `customer_card_id`, and optional\notherwise..</param>
        /// <param name="BillingAddress">If available, Postal code in the billing address for US and Canada payments may reduce decline rate..</param>
        /// <param name="ShippingAddress">.</param>

        public ChargeRequest(string IdempotencyKey = null, Money AmountMoney = null, string CardNonce = null, string CustomerCardId = null, bool? DelayCapture = null, string ReferenceId = null, string Note = null, string CustomerId = null, Address BillingAddress = null, Address ShippingAddress = null)
        {
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for ChargeRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
            // to ensure "AmountMoney" is required (not null)
            if (AmountMoney == null)
            {
                throw new InvalidDataException("AmountMoney is a required property for ChargeRequest and cannot be null");
            }
            else
            {
                this.AmountMoney = AmountMoney;
            }
            this.CardNonce = CardNonce;
            this.CustomerCardId = CustomerCardId;
            this.DelayCapture = DelayCapture;
            this.ReferenceId = ReferenceId;
            this.Note = Note;
            this.CustomerId = CustomerId;
            this.BillingAddress = BillingAddress;
            this.ShippingAddress = ShippingAddress;
            
        }
        
    
        /// <summary>
        /// A value you specify that uniquely identifies this\ntransaction among transactions you&#39;ve created.\n\nIf you&#39;re unsure whether a particular transaction succeeded,\nyou can reattempt it with the same idempotency key without\nworrying about double-charging the buyer. Note that *all other fields*\nmust also remain identical in your followup request, or an error will occur.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this\ntransaction among transactions you&#39;ve created.\n\nIf you&#39;re unsure whether a particular transaction succeeded,\nyou can reattempt it with the same idempotency key without\nworrying about double-charging the buyer. Note that *all other fields*\nmust also remain identical in your followup request, or an error will occur.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
    
        /// <summary>
        /// The amount of money to collect in the transaction.
        /// </summary>
        /// <value>The amount of money to collect in the transaction.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
    
        /// <summary>
        /// A nonce representing the credit card to charge for this transaction.\nDo not provide a value for this field if you provide a value for\n`customer_card_id`.
        /// </summary>
        /// <value>A nonce representing the credit card to charge for this transaction.\nDo not provide a value for this field if you provide a value for\n`customer_card_id`.</value>
        [DataMember(Name="card_nonce", EmitDefaultValue=false)]
        public string CardNonce { get; set; }
    
        /// <summary>
        /// The ID of the customer card on file to charge for this transaction. Do\nnot provide a value for this field if you provide a value for `card_nonce`.
        /// </summary>
        /// <value>The ID of the customer card on file to charge for this transaction. Do\nnot provide a value for this field if you provide a value for `card_nonce`.</value>
        [DataMember(Name="customer_card_id", EmitDefaultValue=false)]
        public string CustomerCardId { get; set; }
    
        /// <summary>
        /// If `true`, the request will only perform an Auth on the provided\ncard. You can then later perform either a Capture (with the\n*CaptureTransaction** endpoint) or a Void (with the **VoidTransation**\nendpoint.
        /// </summary>
        /// <value>If `true`, the request will only perform an Auth on the provided\ncard. You can then later perform either a Capture (with the\n*CaptureTransaction** endpoint) or a Void (with the **VoidTransation**\nendpoint.</value>
        [DataMember(Name="delay_capture", EmitDefaultValue=false)]
        public bool? DelayCapture { get; set; }
    
        /// <summary>
        /// An optional ID you can associate with the transaction for your own\npurposes (such as to associate the transaction with an entity ID in your\nown database).
        /// </summary>
        /// <value>An optional ID you can associate with the transaction for your own\npurposes (such as to associate the transaction with an entity ID in your\nown database).</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
    
        /// <summary>
        /// An optional note to associate with the transaction.
        /// </summary>
        /// <value>An optional note to associate with the transaction.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
    
        /// <summary>
        /// The ID of the customer to associate this transaction with. This field\nis required if you provide a value for `customer_card_id`, and optional\notherwise.
        /// </summary>
        /// <value>The ID of the customer to associate this transaction with. This field\nis required if you provide a value for `customer_card_id`, and optional\notherwise.</value>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
    
        /// <summary>
        /// If available, Postal code in the billing address for US and Canada payments may reduce decline rate.
        /// </summary>
        /// <value>If available, Postal code in the billing address for US and Canada payments may reduce decline rate.</value>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public Address ShippingAddress { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeRequest {\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  CardNonce: ").Append(CardNonce).Append("\n");
            sb.Append("  CustomerCardId: ").Append(CustomerCardId).Append("\n");
            sb.Append("  DelayCapture: ").Append(DelayCapture).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            
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
            return this.Equals(obj as ChargeRequest);
        }

        /// <summary>
        /// Returns true if ChargeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChargeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeRequest other)
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
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.CardNonce == other.CardNonce ||
                    this.CardNonce != null &&
                    this.CardNonce.Equals(other.CardNonce)
                ) && 
                (
                    this.CustomerCardId == other.CustomerCardId ||
                    this.CustomerCardId != null &&
                    this.CustomerCardId.Equals(other.CustomerCardId)
                ) && 
                (
                    this.DelayCapture == other.DelayCapture ||
                    this.DelayCapture != null &&
                    this.DelayCapture.Equals(other.DelayCapture)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
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
                
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                
                if (this.CardNonce != null)
                    hash = hash * 59 + this.CardNonce.GetHashCode();
                
                if (this.CustomerCardId != null)
                    hash = hash * 59 + this.CustomerCardId.GetHashCode();
                
                if (this.DelayCapture != null)
                    hash = hash * 59 + this.DelayCapture.GetHashCode();
                
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                
                return hash;
            }
        }

    }
}
