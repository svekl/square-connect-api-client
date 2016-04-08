using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnectApiClient.V1.Model
{
    /// <summary>
    /// If you obtained a temporary authorization code from a request to the Authorize endpoint, you exchange that code for an access token with a request to this endpoint.
    /// </summary>
    [DataContract]
    public class ObtainTokenRequest
    {
        /// <summary>
        /// Your application's ID, available from the application dashboard.
        /// </summary>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Your application's secret, available from the application dashboard.
        /// </summary>
        [DataMember(Name = "client_secret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The authorization code to exchange.
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// If you provided a redirect_uri in your corresponding request to the Authorize endpoint, you must provide the exact same redirect_uri here.
        /// </summary>
        [DataMember(Name = "redirect_uri", EmitDefaultValue = false)]
        public string RedirectUri { get; set; }
    }
}
