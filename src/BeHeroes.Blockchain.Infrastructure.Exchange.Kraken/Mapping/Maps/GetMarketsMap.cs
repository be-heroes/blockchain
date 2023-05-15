//TODO: Reimplement with new native Json classes and ITypeConverter interfaces
// using System.Collections.Generic;
// using AutoMapper;
// using BeHeroes.Blockchain.Domain.Trading.ValueObjects;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Http.Response;
// using System.Text.Json.Serialization;
// using Newtonsoft.Json.Linq;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps
// {
//     public class GetMarketsMap : ITypeConverter<KrakenRpcResponse, List<Market>>
//     {
//         public List<Market> Convert(ResolutionContext context)
//         {
//             dynamic dynObj = JsonConvert.DeserializeObject(((KrakenRpcResponse)context.SourceValue).Content.Result.Object.ToString());

//             var output = new List<Market>();
//             if (dynObj != null)
//             {
//                 var jObj = (JObject)dynObj;

//                 foreach (JToken token in jObj.Children())
//                 {
//                     if (token is JProperty)
//                     {
//                         var prop = token as JProperty;
//                         if (prop.Name.Equals("result"))
//                         {
//                             var message = prop.Value as JObject;
//                             foreach (JToken token2 in message.Children())
//                             {
//                                 var prop2 = token2 as JProperty;
//                                 var market = new Market(prop2.Name);
//                                 market.IsActive = true;
//                                 output.Add(market);
//                             }
//                         }
//                     }
//                 }
//             }

//             return output;
//         }
//     }
// }