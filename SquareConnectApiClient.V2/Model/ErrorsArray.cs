using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnectApiClient.V2.Model
{
    [DataContract]
    public class ErrorsArray
    {
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public Error[] Errors { get; set; }
    }
}
