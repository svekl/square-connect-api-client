using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnectApiClient.V1.Model
{
    [DataContract]
    public class RenewTokenResponse
    {
        /// <summary>
        //  Your application's access token. You provide this token in a header with every request to Connect API endpoints. See Request and response headers for the format of this header.
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// This value is always bearer.
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// The date when access_token expires, in ISO 8601 format.
        /// </summary>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// The ID of the authorizing merchant.
        /// </summary>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }
    }
}
