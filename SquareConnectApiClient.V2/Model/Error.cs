using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SquareConnectApiClient.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>
    { 
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum {
            
            [EnumMember(Value = "API_ERROR")]
            ApiError,
            
            [EnumMember(Value = "AUTHENTICATION_ERROR")]
            AuthenticationError,
            
            [EnumMember(Value = "INVALID_REQUEST_ERROR")]
            InvalidRequestError,
            
            [EnumMember(Value = "RATE_LIMIT_ERROR")]
            RateLimitError,
            
            [EnumMember(Value = "PAYMENT_METHOD_ERROR")]
            PaymentMethodError,
            
            [EnumMember(Value = "REFUND_ERROR")]
            RefundError
        }

    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum {
            
            [EnumMember(Value = "INTERNAL_SERVER_ERROR")]
            InternalServerError,
            
            [EnumMember(Value = "UNAUTHORIZED")]
            Unauthorized,
            
            [EnumMember(Value = "ACCESS_TOKEN_EXPIRED")]
            AccessTokenExpired,
            
            [EnumMember(Value = "ACCESS_TOKEN_REVOKED")]
            AccessTokenRevoked,
            
            [EnumMember(Value = "FORBIDDEN")]
            Forbidden,
            
            [EnumMember(Value = "INSUFFICIENT_SCOPES")]
            InsufficientScopes,
            
            [EnumMember(Value = "APPLICATION_DISABLED")]
            ApplicationDisabled,
            
            [EnumMember(Value = "V1_APPLICATION")]
            V1Application,
            
            [EnumMember(Value = "V1_ACCESS_TOKEN")]
            V1AccessToken,
            
            [EnumMember(Value = "CARD_PROCESSING_NOT_ENABLED")]
            CardProcessingNotEnabled,
            
            [EnumMember(Value = "BAD_REQUEST")]
            BadRequest,
            
            [EnumMember(Value = "MISSING_REQUIRED_PARAMETER")]
            MissingRequiredParameter,
            
            [EnumMember(Value = "INCORRECT_TYPE")]
            IncorrectType,
            
            [EnumMember(Value = "INVALID_TIME")]
            InvalidTime,
            
            [EnumMember(Value = "INVALID_TIME_RANGE")]
            InvalidTimeRange,
            
            [EnumMember(Value = "INVALID_VALUE")]
            InvalidValue,
            
            [EnumMember(Value = "INVALID_CURSOR")]
            InvalidCursor,
            
            [EnumMember(Value = "UNKNOWN_QUERY_PARAMETER")]
            UnknownQueryParameter,
            
            [EnumMember(Value = "CONFLICTING_PARAMETERS")]
            ConflictingParameters,
            
            [EnumMember(Value = "EXPECTED_JSON_BODY")]
            ExpectedJsonBody,
            
            [EnumMember(Value = "INVALID_SORT_ORDER")]
            InvalidSortOrder,
            
            [EnumMember(Value = "VALUE_TOO_LONG")]
            ValueTooLong,
            
            [EnumMember(Value = "VALUE_TOO_LOW")]
            ValueTooLow,
            
            [EnumMember(Value = "EXPECTED_BOOLEAN")]
            ExpectedBoolean,
            
            [EnumMember(Value = "EXPECTED_INTEGER")]
            ExpectedInteger,
            
            [EnumMember(Value = "EXPECTED_FLOAT")]
            ExpectedFloat,
            
            [EnumMember(Value = "EXPECTED_STRING")]
            ExpectedString,
            
            [EnumMember(Value = "EXPECTED_OBJECT")]
            ExpectedObject,
            
            [EnumMember(Value = "EXPECTED_ARRAY")]
            ExpectedArray,
            
            [EnumMember(Value = "INVALID_ARRAY_VALUE")]
            InvalidArrayValue,
            
            [EnumMember(Value = "INVALID_ENUM_VALUE")]
            InvalidEnumValue,
            
            [EnumMember(Value = "INVALID_CONTENT_TYPE")]
            InvalidContentType,
            
            [EnumMember(Value = "INVALID_FORM_VALUE")]
            InvalidFormValue,
            
            [EnumMember(Value = "ONE_INSTRUMENT_EXPECTED")]
            OneInstrumentExpected,
            
            [EnumMember(Value = "NO_FIELDS_SET")]
            NoFieldsSet,
            
            [EnumMember(Value = "CARD_DECLINED")]
            CardDeclined,
            
            [EnumMember(Value = "CARD_EXPIRED")]
            CardExpired,
            
            [EnumMember(Value = "VERIFY_CVV_FAILURE")]
            VerifyCvvFailure,
            
            [EnumMember(Value = "VERIFY_AVS_FAILURE")]
            VerifyAvsFailure,
            
            [EnumMember(Value = "INVALID_EXPIRATION")]
            InvalidExpiration,
            
            [EnumMember(Value = "INVALID_EXPIRATION_YEAR")]
            InvalidExpirationYear,
            
            [EnumMember(Value = "INVALID_EXPIRATION_DATE")]
            InvalidExpirationDate,
            
            [EnumMember(Value = "INVALID_CARD")]
            InvalidCard,
            
            [EnumMember(Value = "DELAYED_TRANSACTION_EXPIRED")]
            DelayedTransactionExpired,
            
            [EnumMember(Value = "DELAYED_TRANSACTION_CANCELED")]
            DelayedTransactionCanceled,
            
            [EnumMember(Value = "DELAYED_TRANSACTION_CAPTURED")]
            DelayedTransactionCaptured,
            
            [EnumMember(Value = "DELAYED_TRANSACTION_FAILED")]
            DelayedTransactionFailed,
            
            [EnumMember(Value = "CARD_TOKEN_EXPIRED")]
            CardTokenExpired,
            
            [EnumMember(Value = "CARD_TOKEN_USED")]
            CardTokenUsed,
            
            [EnumMember(Value = "AMOUNT_TOO_HIGH")]
            AmountTooHigh,
            
            [EnumMember(Value = "UNSUPPORTED_INSTRUMENT_TYPE")]
            UnsupportedInstrumentType,
            
            [EnumMember(Value = "REFUND_AMOUNT_INVALID")]
            RefundAmountInvalid,
            
            [EnumMember(Value = "REFUND_ALREADY_PENDING")]
            RefundAlreadyPending,
            
            [EnumMember(Value = "PAYMENT_NOT_REFUNDABLE")]
            PaymentNotRefundable,
            
            [EnumMember(Value = "INVALID_CARD_DATA")]
            InvalidCardData,
            
            [EnumMember(Value = "NOT_FOUND")]
            NotFound,
            
            [EnumMember(Value = "REQUEST_TIMEOUT")]
            RequestTimeout,
            
            [EnumMember(Value = "REQUEST_ENTITY_TOO_LARGE")]
            RequestEntityTooLarge,
            
            [EnumMember(Value = "UNSUPPORTED_MEDIA_TYPE")]
            UnsupportedMediaType,
            
            [EnumMember(Value = "RATE_LIMITED")]
            RateLimited,
            
            [EnumMember(Value = "NOT_IMPLEMENTED")]
            NotImplemented,
            
            [EnumMember(Value = "SERVICE_UNAVAILABLE")]
            ServiceUnavailable
        }

    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum? Code { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// Initializes a new instance of the <see cref="Error" />class.
        /// </summary>
        /// <param name="Category"> (required).</param>
        /// <param name="Code"> (required).</param>
        /// <param name="Detail">.</param>
        /// <param name="Field">.</param>

        public Error(CategoryEnum? Category = null, CodeEnum? Code = null, string Detail = null, string Field = null)
        {
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for Error and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for Error and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            this.Detail = Detail;
            this.Field = Field;
            
        }
        
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            
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
            return this.Equals(obj as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="other">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Detail == other.Detail ||
                    this.Detail != null &&
                    this.Detail.Equals(other.Detail)
                ) && 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
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
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                
                if (this.Detail != null)
                    hash = hash * 59 + this.Detail.GetHashCode();
                
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                
                return hash;
            }
        }

    }
}
