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
    public partial class ListCustomersRequest :  IEquatable<ListCustomersRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomersRequest" /> class.
        /// Initializes a new instance of the <see cref="ListCustomersRequest" />class.
        /// </summary>
        /// <param name="Cursor">.</param>

        public ListCustomersRequest(string Cursor = null)
        {
            this.Cursor = Cursor;
            
        }
        
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCustomersRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            
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
            return this.Equals(obj as ListCustomersRequest);
        }

        /// <summary>
        /// Returns true if ListCustomersRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ListCustomersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListCustomersRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
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
                
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                
                return hash;
            }
        }

    }
}
