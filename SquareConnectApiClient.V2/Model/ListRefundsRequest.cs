using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// Defines the query parameters that can be included in\na request to the **ListRefunds** endpoint.
    /// </summary>
    [DataContract]
    public class ListRefundsRequest :  IEquatable<ListRefundsRequest>
    { 
    
        /// <summary>
        /// The order in which results are listed in the response.
        /// </summary>
        /// <value>The order in which results are listed in the response.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortOrderEnum {
            
            [EnumMember(Value = "DESC")]
            Desc,
            
            [EnumMember(Value = "ASC")]
            Asc
        }

    
        /// <summary>
        /// The order in which results are listed in the response.
        /// </summary>
        /// <value>The order in which results are listed in the response.</value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRefundsRequest" /> class.
        /// Initializes a new instance of the <see cref="ListRefundsRequest" />class.
        /// </summary>
        /// <param name="BeginTime">The beginning of the requested reporting period, in RFC 3339 format..</param>
        /// <param name="EndTime">The end of the requested reporting period, in RFC 3339 format..</param>
        /// <param name="SortOrder">The order in which results are listed in the response..</param>
        /// <param name="Cursor">A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint..</param>

        public ListRefundsRequest(string BeginTime = null, string EndTime = null, SortOrderEnum? SortOrder = null, string Cursor = null)
        {
            this.BeginTime = BeginTime;
            this.EndTime = EndTime;
            this.SortOrder = SortOrder;
            this.Cursor = Cursor;
            
        }
        
    
        /// <summary>
        /// The beginning of the requested reporting period, in RFC 3339 format.
        /// </summary>
        /// <value>The beginning of the requested reporting period, in RFC 3339 format.</value>
        [DataMember(Name="begin_time", EmitDefaultValue=false)]
        public string BeginTime { get; set; }
    
        /// <summary>
        /// The end of the requested reporting period, in RFC 3339 format.
        /// </summary>
        /// <value>The end of the requested reporting period, in RFC 3339 format.</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public string EndTime { get; set; }
    
        /// <summary>
        /// A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint.
        /// </summary>
        /// <value>A pagination cursor to retrieve the next set of results for your\noriginal query to the endpoint.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRefundsRequest {\n");
            sb.Append("  BeginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(obj as ListRefundsRequest);
        }

        /// <summary>
        /// Returns true if ListRefundsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ListRefundsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListRefundsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BeginTime == other.BeginTime ||
                    this.BeginTime != null &&
                    this.BeginTime.Equals(other.BeginTime)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) && 
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
                
                if (this.BeginTime != null)
                    hash = hash * 59 + this.BeginTime.GetHashCode();
                
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                
                return hash;
            }
        }

    }
}
