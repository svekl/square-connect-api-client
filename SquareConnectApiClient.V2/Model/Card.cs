using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Represents a credit card.
    /// </summary>
    [DataContract]
    public class Card :  IEquatable<Card>
    { 
    
        /// <summary>
        /// The card's brand (such as `VISA`).
        /// </summary>
        /// <value>The card's brand (such as `VISA`).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardBrandEnum {
            
            [EnumMember(Value = "OTHER_BRAND")]
            OtherBrand,
            
            [EnumMember(Value = "VISA")]
            Visa,
            
            [EnumMember(Value = "MASTERCARD")]
            Mastercard,
            
            [EnumMember(Value = "AMERICAN_EXPRESS")]
            AmericanExpress,
            
            [EnumMember(Value = "DISCOVER")]
            Discover,
            
            [EnumMember(Value = "DISCOVER_DINERS")]
            DiscoverDiners,
            
            [EnumMember(Value = "JCB")]
            Jcb,
            
            [EnumMember(Value = "CHINA_UNIONPAY")]
            ChinaUnionpay,
            
            [EnumMember(Value = "SQUARE_GIFT_CARD")]
            SquareGiftCard
        }

    
        /// <summary>
        /// The card's brand (such as `VISA`).
        /// </summary>
        /// <value>The card's brand (such as `VISA`).</value>
        [DataMember(Name="card_brand", EmitDefaultValue=false)]
        public CardBrandEnum? CardBrand { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// Initializes a new instance of the <see cref="Card" />class.
        /// </summary>
        /// <param name="Id">The card&#39;s unique ID, if any..</param>
        /// <param name="CardBrand">The card&#39;s brand (such as `VISA`)..</param>
        /// <param name="Last4">The last 4 digits of the card&#39;s number..</param>
        /// <param name="ExpMonth">The month of the card&#39;s expiration date, which must be between 1-12..</param>
        /// <param name="ExpYear">The year of the card&#39;s expiration date, which must be a 4-digit year..</param>
        /// <param name="CardholderName">The cardholder name for the card on file..</param>
        /// <param name="BillingAddress">The billing address for the card on file..</param>

        public Card(string Id = null, CardBrandEnum? CardBrand = null, string Last4 = null, int? ExpMonth = null, int? ExpYear = null, string CardholderName = null, Address BillingAddress = null)
        {
            this.Id = Id;
            this.CardBrand = CardBrand;
            this.Last4 = Last4;
            this.ExpMonth = ExpMonth;
            this.ExpYear = ExpYear;
            this.CardholderName = CardholderName;
            this.BillingAddress = BillingAddress;
            
        }
        
    
        /// <summary>
        /// The card&#39;s unique ID, if any.
        /// </summary>
        /// <value>The card&#39;s unique ID, if any.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The last 4 digits of the card&#39;s number.
        /// </summary>
        /// <value>The last 4 digits of the card&#39;s number.</value>
        [DataMember(Name="last_4", EmitDefaultValue=false)]
        public string Last4 { get; set; }
    
        /// <summary>
        /// The month of the card&#39;s expiration date, which must be between 1-12.
        /// </summary>
        /// <value>The month of the card&#39;s expiration date, which must be between 1-12.</value>
        [DataMember(Name="exp_month", EmitDefaultValue=false)]
        public int? ExpMonth { get; set; }
    
        /// <summary>
        /// The year of the card&#39;s expiration date, which must be a 4-digit year.
        /// </summary>
        /// <value>The year of the card&#39;s expiration date, which must be a 4-digit year.</value>
        [DataMember(Name="exp_year", EmitDefaultValue=false)]
        public int? ExpYear { get; set; }
    
        /// <summary>
        /// The cardholder name for the card on file.
        /// </summary>
        /// <value>The cardholder name for the card on file.</value>
        [DataMember(Name="cardholder_name", EmitDefaultValue=false)]
        public string CardholderName { get; set; }
    
        /// <summary>
        /// The billing address for the card on file.
        /// </summary>
        /// <value>The billing address for the card on file.</value>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CardBrand: ").Append(CardBrand).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            
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
            return this.Equals(obj as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="other">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card other)
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
                    this.CardBrand == other.CardBrand ||
                    this.CardBrand != null &&
                    this.CardBrand.Equals(other.CardBrand)
                ) && 
                (
                    this.Last4 == other.Last4 ||
                    this.Last4 != null &&
                    this.Last4.Equals(other.Last4)
                ) && 
                (
                    this.ExpMonth == other.ExpMonth ||
                    this.ExpMonth != null &&
                    this.ExpMonth.Equals(other.ExpMonth)
                ) && 
                (
                    this.ExpYear == other.ExpYear ||
                    this.ExpYear != null &&
                    this.ExpYear.Equals(other.ExpYear)
                ) && 
                (
                    this.CardholderName == other.CardholderName ||
                    this.CardholderName != null &&
                    this.CardholderName.Equals(other.CardholderName)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
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
                
                if (this.CardBrand != null)
                    hash = hash * 59 + this.CardBrand.GetHashCode();
                
                if (this.Last4 != null)
                    hash = hash * 59 + this.Last4.GetHashCode();
                
                if (this.ExpMonth != null)
                    hash = hash * 59 + this.ExpMonth.GetHashCode();
                
                if (this.ExpYear != null)
                    hash = hash * 59 + this.ExpYear.GetHashCode();
                
                if (this.CardholderName != null)
                    hash = hash * 59 + this.CardholderName.GetHashCode();
                
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                
                return hash;
            }
        }

    }
}
