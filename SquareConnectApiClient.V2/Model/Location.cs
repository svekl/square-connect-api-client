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
    /// Represents one of a business&#39;s locations.
    /// </summary>
    [DataContract]
    public class Location :  IEquatable<Location>
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CapabilitiesEnum
        {
            
            [EnumMember(Value = "CREDIT_CARD_PROCESSING")]
            Processing
        }

    
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// Initializes a new instance of the <see cref="Location" />class.
        /// </summary>
        /// <param name="Id">The location&#39;s unique ID..</param>
        /// <param name="Name">The name given to the location..</param>
        /// <param name="Address">The address of this location..</param>
        /// <param name="Timezone">The IANA Timezone Database identifier for the location&#39;s timezone..</param>
        /// <param name="Capabilities">Indicates which Square features are enabled for the location.\n\nCurrently, there is only one value that might be present in this array:\n`CREDIT_CARD_PROCESSING`..</param>

        public Location(string Id = null, string Name = null, Address Address = null, string Timezone = null, List<CapabilitiesEnum> Capabilities = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Timezone = Timezone;
            this.Capabilities = Capabilities;
            
        }
        
    
        /// <summary>
        /// The location&#39;s unique ID.
        /// </summary>
        /// <value>The location&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The name given to the location.
        /// </summary>
        /// <value>The name given to the location.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// The address of this location.
        /// </summary>
        /// <value>The address of this location.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }
    
        /// <summary>
        /// The IANA Timezone Database identifier for the location&#39;s timezone.
        /// </summary>
        /// <value>The IANA Timezone Database identifier for the location&#39;s timezone.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
    
        /// <summary>
        /// Indicates which Square features are enabled for the location.\n\nCurrently, there is only one value that might be present in this array:\n`CREDIT_CARD_PROCESSING`.
        /// </summary>
        /// <value>Indicates which Square features are enabled for the location.\n\nCurrently, there is only one value that might be present in this array:\n`CREDIT_CARD_PROCESSING`.</value>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public List<CapabilitiesEnum> Capabilities { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            
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
            return this.Equals(obj as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="other">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.Capabilities == other.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.SequenceEqual(other.Capabilities)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                
                if (this.Capabilities != null)
                    hash = hash * 59 + this.Capabilities.GetHashCode();
                
                return hash;
            }
        }

    }
}
