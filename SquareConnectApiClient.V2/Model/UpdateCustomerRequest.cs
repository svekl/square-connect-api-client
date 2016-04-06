using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class UpdateCustomerRequest :  IEquatable<UpdateCustomerRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest" /> class.
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest" />class.
        /// </summary>
        /// <param name="GivenName">.</param>
        /// <param name="FamilyName">.</param>
        /// <param name="CompanyName">.</param>
        /// <param name="Nickname">.</param>
        /// <param name="EmailAddress">.</param>
        /// <param name="Address">.</param>
        /// <param name="PhoneNumber">.</param>
        /// <param name="ReferenceId">.</param>
        /// <param name="Note">.</param>

        public UpdateCustomerRequest(string GivenName = null, string FamilyName = null, string CompanyName = null, string Nickname = null, string EmailAddress = null, Address Address = null, string PhoneNumber = null, string ReferenceId = null, string Note = null)
        {
            this.GivenName = GivenName;
            this.FamilyName = FamilyName;
            this.CompanyName = CompanyName;
            this.Nickname = Nickname;
            this.EmailAddress = EmailAddress;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.ReferenceId = ReferenceId;
            this.Note = Note;
            
        }
        
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="given_name", EmitDefaultValue=false)]
        public string GivenName { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="family_name", EmitDefaultValue=false)]
        public string FamilyName { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="email_address", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCustomerRequest {\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            
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
            return this.Equals(obj as UpdateCustomerRequest);
        }

        /// <summary>
        /// Returns true if UpdateCustomerRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCustomerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCustomerRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GivenName == other.GivenName ||
                    this.GivenName != null &&
                    this.GivenName.Equals(other.GivenName)
                ) && 
                (
                    this.FamilyName == other.FamilyName ||
                    this.FamilyName != null &&
                    this.FamilyName.Equals(other.FamilyName)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.Nickname == other.Nickname ||
                    this.Nickname != null &&
                    this.Nickname.Equals(other.Nickname)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                
                if (this.GivenName != null)
                    hash = hash * 59 + this.GivenName.GetHashCode();
                
                if (this.FamilyName != null)
                    hash = hash * 59 + this.FamilyName.GetHashCode();
                
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                
                if (this.Nickname != null)
                    hash = hash * 59 + this.Nickname.GetHashCode();
                
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                return hash;
            }
        }

    }
}
