using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Represents a form of tender used to pay in a transaction.
    /// </summary>
    [DataContract]
    public class Tender :  IEquatable<Tender>
    { 
    
        /// <summary>
        /// The type of tender.
        /// </summary>
        /// <value>The type of tender.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "OTHER")]
            Other,
            
            [EnumMember(Value = "CARD")]
            Card,
            
            [EnumMember(Value = "CASH")]
            Cash,
            
            [EnumMember(Value = "THIRD_PARTY_CARD")]
            ThirdPartyCard,
            
            [EnumMember(Value = "SQUARE_GIFT_CARD")]
            SquareGiftCard,
            
            [EnumMember(Value = "NO_SALE")]
            NoSale
        }

    
        /// <summary>
        /// The type of tender.
        /// </summary>
        /// <value>The type of tender.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Tender" /> class.
        /// Initializes a new instance of the <see cref="Tender" />class.
        /// </summary>
        /// <param name="Id">The tender&#39;s unique ID..</param>
        /// <param name="LocationId">The ID of the tender&#39;s associated location..</param>
        /// <param name="TransactionId">The ID of the tender&#39;s associated transaction..</param>
        /// <param name="CreatedAt">The time when the tender was created, in RFC 3339 format..</param>
        /// <param name="Note">An optional note associated with the tender at the time of payment..</param>
        /// <param name="AmountMoney">The amount of the tender..</param>
        /// <param name="ProcessingFeeMoney">The amount of any Square processing fees applied to the tender..</param>
        /// <param name="CustomerId">If the tender represents a customer&#39;s card on file, this is\nthe ID of the associated customer..</param>
        /// <param name="Type">The type of tender. (required).</param>
        /// <param name="CardDetails">The details of the card tender.\nThis value is present only if the value of `type` is `CARD`..</param>
        /// <param name="CashDetails">The details of the cash tender.\nThis value is present only if the value of `type` is `CASH`..</param>

        public Tender(string Id = null, string LocationId = null, string TransactionId = null, string CreatedAt = null, string Note = null, Money AmountMoney = null, Money ProcessingFeeMoney = null, string CustomerId = null, TypeEnum? Type = null, TenderCardDetails CardDetails = null, TenderCashDetails CashDetails = null)
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Tender and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Id = Id;
            this.LocationId = LocationId;
            this.TransactionId = TransactionId;
            this.CreatedAt = CreatedAt;
            this.Note = Note;
            this.AmountMoney = AmountMoney;
            this.ProcessingFeeMoney = ProcessingFeeMoney;
            this.CustomerId = CustomerId;
            this.CardDetails = CardDetails;
            this.CashDetails = CashDetails;
            
        }
        
    
        /// <summary>
        /// The tender&#39;s unique ID.
        /// </summary>
        /// <value>The tender&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The ID of the tender&#39;s associated location.
        /// </summary>
        /// <value>The ID of the tender&#39;s associated location.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
    
        /// <summary>
        /// The ID of the tender&#39;s associated transaction.
        /// </summary>
        /// <value>The ID of the tender&#39;s associated transaction.</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
    
        /// <summary>
        /// The time when the tender was created, in RFC 3339 format.
        /// </summary>
        /// <value>The time when the tender was created, in RFC 3339 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// An optional note associated with the tender at the time of payment.
        /// </summary>
        /// <value>An optional note associated with the tender at the time of payment.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
    
        /// <summary>
        /// The amount of the tender.
        /// </summary>
        /// <value>The amount of the tender.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
    
        /// <summary>
        /// The amount of any Square processing fees applied to the tender.
        /// </summary>
        /// <value>The amount of any Square processing fees applied to the tender.</value>
        [DataMember(Name="processing_fee_money", EmitDefaultValue=false)]
        public Money ProcessingFeeMoney { get; set; }
    
        /// <summary>
        /// If the tender represents a customer&#39;s card on file, this is\nthe ID of the associated customer.
        /// </summary>
        /// <value>If the tender represents a customer&#39;s card on file, this is\nthe ID of the associated customer.</value>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
    
        /// <summary>
        /// The details of the card tender.\nThis value is present only if the value of `type` is `CARD`.
        /// </summary>
        /// <value>The details of the card tender.\nThis value is present only if the value of `type` is `CARD`.</value>
        [DataMember(Name="card_details", EmitDefaultValue=false)]
        public TenderCardDetails CardDetails { get; set; }
    
        /// <summary>
        /// The details of the cash tender.\nThis value is present only if the value of `type` is `CASH`.
        /// </summary>
        /// <value>The details of the cash tender.\nThis value is present only if the value of `type` is `CASH`.</value>
        [DataMember(Name="cash_details", EmitDefaultValue=false)]
        public TenderCashDetails CashDetails { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tender {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  ProcessingFeeMoney: ").Append(ProcessingFeeMoney).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CardDetails: ").Append(CardDetails).Append("\n");
            sb.Append("  CashDetails: ").Append(CashDetails).Append("\n");
            
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
            return this.Equals(obj as Tender);
        }

        /// <summary>
        /// Returns true if Tender instances are equal
        /// </summary>
        /// <param name="other">Instance of Tender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tender other)
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
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.ProcessingFeeMoney == other.ProcessingFeeMoney ||
                    this.ProcessingFeeMoney != null &&
                    this.ProcessingFeeMoney.Equals(other.ProcessingFeeMoney)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.CardDetails == other.CardDetails ||
                    this.CardDetails != null &&
                    this.CardDetails.Equals(other.CardDetails)
                ) && 
                (
                    this.CashDetails == other.CashDetails ||
                    this.CashDetails != null &&
                    this.CashDetails.Equals(other.CashDetails)
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
                
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                
                if (this.ProcessingFeeMoney != null)
                    hash = hash * 59 + this.ProcessingFeeMoney.GetHashCode();
                
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.CardDetails != null)
                    hash = hash * 59 + this.CardDetails.GetHashCode();
                
                if (this.CashDetails != null)
                    hash = hash * 59 + this.CashDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
