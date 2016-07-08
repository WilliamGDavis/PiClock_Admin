using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PiClock_Admin.Helpers
{
    class CommonMethods
    {
        //Used to read a from a webservice that returns a JSON string
        public static async Task<HttpResponseMessage> GetHttpResponseFromRpcServer(Dictionary<string, string> paramDictionary, string uriPrefix = null)
        {
            using (var wsCall = new WebServiceCall(paramDictionary, uriPrefix))
            { return await wsCall.PostJsonToRpcServer(); }
        }

        public static object Deserialize(Type type, string input)
        { return JsonConvert.DeserializeObject(input, type, new JsonSerializerSettings { Error = HandleDeserializationError, MissingMemberHandling = MissingMemberHandling.Ignore }); }

        public static void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }
    }
}
