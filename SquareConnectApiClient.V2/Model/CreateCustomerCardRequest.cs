using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CreateCustomerCardRequest :  IEquatable<CreateCustomerCardRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerCardRequest" /> class.
        /// Initializes a new instance of the <see cref="CreateCustomerCardRequest" />class.
        /// </summary>
        /// <param name="CardNonce">A card nonce representing the card data to link to the customer. (required).</param>
        /// <param name="BillingAddress">Postal code in the address is required for US and Canada payments..</param>
        /// <param name="CardholderName">The cardholder name..</param>

        public CreateCustomerCardRequest(string CardNonce = null, Address BillingAddress = null, string CardholderName = null)
        {
            // to ensure "CardNonce" is required (not null)
            if (CardNonce == null)
            {
                throw new InvalidDataException("CardNonce is a required property for CreateCustomerCardRequest and cannot be null");
            }
            else
            {
                this.CardNonce = CardNonce;
            }
            this.BillingAddress = BillingAddress;
            this.CardholderName = CardholderName;
            
        }
        
    
        /// <summary>
        /// A card nonce representing the card data to link to the customer.
        /// </summary>
        /// <value>A card nonce representing the card data to link to the customer.</value>
        [DataMember(Name="card_nonce", EmitDefaultValue=false)]
        public string CardNonce { get; set; }
    
        /// <summary>
        /// Postal code in the address is required for US and Canada payments.
        /// </summary>
        /// <value>Postal code in the address is required for US and Canada payments.</value>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }
    
        /// <summary>
        /// The cardholder name.
        /// </summary>
        /// <value>The cardholder name.</value>
        [DataMember(Name="cardholder_name", EmitDefaultValue=false)]
        public string CardholderName { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomerCardRequest {\n");
            sb.Append("  CardNonce: ").Append(CardNonce).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            
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
            return this.Equals(obj as CreateCustomerCardRequest);
        }

        /// <summary>
        /// Returns true if CreateCustomerCardRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCustomerCardRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomerCardRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardNonce == other.CardNonce ||
                    this.CardNonce != null &&
                    this.CardNonce.Equals(other.CardNonce)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.CardholderName == other.CardholderName ||
                    this.CardholderName != null &&
                    this.CardholderName.Equals(other.CardholderName)
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
                
                if (this.CardNonce != null)
                    hash = hash * 59 + this.CardNonce.GetHashCode();
                
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                
                if (this.CardholderName != null)
                    hash = hash * 59 + this.CardholderName.GetHashCode();
                
                return hash;
            }
        }

    }
}
