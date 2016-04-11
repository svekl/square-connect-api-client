using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using SquareConnectApiClient.Client;
using SquareConnectApiClient.V2.Model;

namespace SquareConnectApiClient.V2.Api
{
    public class ApiV2Exception : ApiException
    {
        private static string GetErrorMessage(string errorContent, string errorMessage)
        {
            try
            {
                var errorsArray = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorsArray>(errorContent);
                return FlattenErrorsArray(errorsArray.Errors);
            }
            catch (Exception)
            {
                return errorMessage;
            }
        }

        private static string FlattenErrorsArray(Error[] errors)
        {
            return string.Join("; ", errors.Select(x =>
            {
                var resultText = new StringBuilder();
                if (x.Category != null)
                {
                    resultText.Append(x.Category.ToString());
                    resultText.Append(" - ");
                }
                if (x.Code != null) resultText.Append(x.Code.ToString());
                if (!string.IsNullOrWhiteSpace(x.Field))
                {
                    resultText.Append(" at field \"");
                    resultText.Append(x.Field);
                    resultText.Append("\"");
                }
                resultText.Append(" : ");
                resultText.Append(x.Detail);
                return resultText.ToString();
            }));
        }

        public ApiV2Exception(int errorCode, string message) : base(errorCode, message)
        {

        }

        public ApiV2Exception(int errorCode, string message, string errorContent) : base(errorCode, GetErrorMessage(errorContent, message), errorContent)
        {
            this.ErrorCode = errorCode;
        }
    }
}
