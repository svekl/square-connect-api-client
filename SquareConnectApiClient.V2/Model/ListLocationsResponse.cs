using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the fields that are included in the response body of \na request to the **ListLocations** endpoint.\n\nOne of `errors` or `locations` is present in a given response (never both).
    /// </summary>
    [DataContract]
    public partial class ListLocationsResponse :  IEquatable<ListLocationsResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListLocationsResponse" /> class.
        /// Initializes a new instance of the <see cref="ListLocationsResponse" />class.
        /// </summary>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        /// <param name="Locations">An array of the business&#39;s locations..</param>

        public ListLocationsResponse(List<Error> Errors = null, List<Location> Locations = null)
        {
            this.Errors = Errors;
            this.Locations = Locations;
            
        }
        
    
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
    
        /// <summary>
        /// An array of the business&#39;s locations.
        /// </summary>
        /// <value>An array of the business&#39;s locations.</value>
        [DataMember(Name="locations", EmitDefaultValue=false)]
        public List<Location> Locations { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLocationsResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            
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
            return this.Equals(obj as ListLocationsResponse);
        }

        /// <summary>
        /// Returns true if ListLocationsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ListLocationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListLocationsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Locations == other.Locations ||
                    this.Locations != null &&
                    this.Locations.SequenceEqual(other.Locations)
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
                
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                
                if (this.Locations != null)
                    hash = hash * 59 + this.Locations.GetHashCode();
                
                return hash;
            }
        }

    }
}
