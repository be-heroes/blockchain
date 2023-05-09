using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Response
{
    public class KrakenRpcResponse : HttpResponseMessage
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //TODO: Review kraken API for current error handling logic.
            // var result = (List<ValidationResult>)base.Validate(validationContext);

            // dynamic dynObj = JsonConvert.DeserializeObject(Content.Result.Object.ToString());
            // if (dynObj != null)
            // {
            //     var jObj = (JObject)dynObj;

            //     foreach (JToken token in jObj.Children())
            //     {
            //         if (token is JProperty)
            //         {
            //             var prop = token as JProperty;
            //             if (prop.Name.Equals("error"))
            //             {
            //                 var message = prop.Value as JArray;
            //                 if (message.Count != 0)
            //                 {
            //                     result.Add(new ValidationResult(message.ToString(), new[] { "error" }));
            //                 }

            //             }
            //         }
            //     }
            // }
            // return result;
            return Array.Empty<ValidationResult>();
        }
    }
}
