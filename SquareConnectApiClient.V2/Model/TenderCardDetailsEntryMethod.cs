using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// The method used to read the card
    /// </summary>
    [DataContract]
    public partial class TenderCardDetailsEntryMethod :  IEquatable<TenderCardDetailsEntryMethod>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenderCardDetailsEntryMethod" /> class.
        /// Initializes a new instance of the <see cref="TenderCardDetailsEntryMethod" />class.
        /// </summary>

        public TenderCardDetailsEntryMethod()
        {
            
        }
        
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenderCardDetailsEntryMethod {\n");
            
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
            return this.Equals(obj as TenderCardDetailsEntryMethod);
        }

        /// <summary>
        /// Returns true if TenderCardDetailsEntryMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of TenderCardDetailsEntryMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenderCardDetailsEntryMethod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return false;
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
                
                return hash;
            }
        }

    }
}
