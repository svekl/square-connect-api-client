using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnectApiClient.V1.Model
{
    /// <summary>
    /// OAuth access tokens besides your application's personal access token expire after 30 days. Use this endpoint to renew an expired token. If you provide a token that isn't expired, this endpoint does not extend its lifetime.
    /// You cannot renew an access token that has been expired for more than 15 days.Instead, the associated merchant must complete the OAuth flow from the beginning.
    /// </summary>
    [DataContract]
    public class RenewTokenRequest
    {
        /// <summary>
        /// The token you want to renew.
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }
    }
}
