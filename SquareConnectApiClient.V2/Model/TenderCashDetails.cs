using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Represents the details of a cash tender.
    /// </summary>
    [DataContract]
    public partial class TenderCashDetails :  IEquatable<TenderCashDetails>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenderCashDetails" /> class.
        /// Initializes a new instance of the <see cref="TenderCashDetails" />class.
        /// </summary>
        /// <param name="BuyerTenderedMoney">The total amount provided by the buyer for this tender, before change is given..</param>
        /// <param name="ChangeBackMoney">The change returned to the buyer for this tender. This amount should be &gt;= 0..</param>

        public TenderCashDetails(Money BuyerTenderedMoney = null, Money ChangeBackMoney = null)
        {
            this.BuyerTenderedMoney = BuyerTenderedMoney;
            this.ChangeBackMoney = ChangeBackMoney;
            
        }
        
    
        /// <summary>
        /// The total amount provided by the buyer for this tender, before change is given.
        /// </summary>
        /// <value>The total amount provided by the buyer for this tender, before change is given.</value>
        [DataMember(Name="buyer_tendered_money", EmitDefaultValue=false)]
        public Money BuyerTenderedMoney { get; set; }
    
        /// <summary>
        /// The change returned to the buyer for this tender. This amount should be &gt;= 0.
        /// </summary>
        /// <value>The change returned to the buyer for this tender. This amount should be &gt;= 0.</value>
        [DataMember(Name="change_back_money", EmitDefaultValue=false)]
        public Money ChangeBackMoney { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenderCashDetails {\n");
            sb.Append("  BuyerTenderedMoney: ").Append(BuyerTenderedMoney).Append("\n");
            sb.Append("  ChangeBackMoney: ").Append(ChangeBackMoney).Append("\n");
            
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
            return this.Equals(obj as TenderCashDetails);
        }

        /// <summary>
        /// Returns true if TenderCashDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of TenderCashDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenderCashDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BuyerTenderedMoney == other.BuyerTenderedMoney ||
                    this.BuyerTenderedMoney != null &&
                    this.BuyerTenderedMoney.Equals(other.BuyerTenderedMoney)
                ) && 
                (
                    this.ChangeBackMoney == other.ChangeBackMoney ||
                    this.ChangeBackMoney != null &&
                    this.ChangeBackMoney.Equals(other.ChangeBackMoney)
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
                
                if (this.BuyerTenderedMoney != null)
                    hash = hash * 59 + this.BuyerTenderedMoney.GetHashCode();
                
                if (this.ChangeBackMoney != null)
                    hash = hash * 59 + this.ChangeBackMoney.GetHashCode();
                
                return hash;
            }
        }

    }
}
