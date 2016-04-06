using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Represents the details of a credit card tender.
    /// </summary>
    [DataContract]
    public partial class TenderCardDetails :  IEquatable<TenderCardDetails>
    { 
    
        /// <summary>
        /// The credit card payment's current state (such as `CAPTURED`)
        /// </summary>
        /// <value>The credit card payment's current state (such as `CAPTURED`)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "AUTHORIZED")]
            Authorized,
            
            [EnumMember(Value = "CAPTURED")]
            Captured,
            
            [EnumMember(Value = "VOIDED")]
            Voided,
            
            [EnumMember(Value = "FAILED")]
            Failed
        }

    
        /// <summary>
        /// The method used to read the card.
        /// </summary>
        /// <value>The method used to read the card.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntryMethodEnum {
            
            [EnumMember(Value = "SWIPED")]
            Swiped,
            
            [EnumMember(Value = "KEYED")]
            Keyed,
            
            [EnumMember(Value = "EMV")]
            Emv,
            
            [EnumMember(Value = "ON_FILE")]
            OnFile,
            
            [EnumMember(Value = "CONTACTLESS")]
            Contactless
        }

    
        /// <summary>
        /// The credit card payment's current state (such as `CAPTURED`)
        /// </summary>
        /// <value>The credit card payment's current state (such as `CAPTURED`)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// The method used to read the card.
        /// </summary>
        /// <value>The method used to read the card.</value>
        [DataMember(Name="entry_method", EmitDefaultValue=false)]
        public EntryMethodEnum? EntryMethod { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenderCardDetails" /> class.
        /// Initializes a new instance of the <see cref="TenderCardDetails" />class.
        /// </summary>
        /// <param name="Status">The credit card payment&#39;s current state (such as `CAPTURED`).</param>
        /// <param name="Card">The credit card&#39;s non-confidential details..</param>
        /// <param name="EntryMethod">The method used to read the card..</param>

        public TenderCardDetails(StatusEnum? Status = null, Card Card = null, EntryMethodEnum? EntryMethod = null)
        {
            this.Status = Status;
            this.Card = Card;
            this.EntryMethod = EntryMethod;
            
        }
        
    
        /// <summary>
        /// The credit card&#39;s non-confidential details.
        /// </summary>
        /// <value>The credit card&#39;s non-confidential details.</value>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public Card Card { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenderCardDetails {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  EntryMethod: ").Append(EntryMethod).Append("\n");
            
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
            return this.Equals(obj as TenderCardDetails);
        }

        /// <summary>
        /// Returns true if TenderCardDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of TenderCardDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenderCardDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.EntryMethod == other.EntryMethod ||
                    this.EntryMethod != null &&
                    this.EntryMethod.Equals(other.EntryMethod)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                
                if (this.EntryMethod != null)
                    hash = hash * 59 + this.EntryMethod.GetHashCode();
                
                return hash;
            }
        }

    }
}
