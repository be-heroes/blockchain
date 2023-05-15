//TODO: Reimplement with new native Json classes and ITypeConverter interfaces
// using System;
// using System.Collections.Generic;
// using AutoMapper;
// using BeHeroes.Core.Common.ExtensionMethods;
// using BeHeroes.Blockchain.Domain.Trading.ValueObjects;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Http.Response;
// using System.Text.Json.Serialization;
// using Newtonsoft.Json.Linq;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps
// {
//     public class GetTradeHistoryMap : ITypeConverter<KrakenRpcResponse, List<Trade>>
//     {
//         public List<Trade> Convert(ResolutionContext context)
//         {
//             var resp = KrakenMapper.Mapper.Map<KrakenRpcResponse, KrakenResponse>((KrakenRpcResponse)context.SourceValue);

//             var output = new List<Trade>();
//             if (resp.Result != null)
//             {
//                 var jObj = (JObject)resp.Result;

//                 foreach (JToken token in jObj.Children())
//                 {
//                     if (token is JProperty)
//                     {
//                         var prop = token as JProperty;
//                         if ("last".Equals(prop.Name))
//                         {
//                             var next = prop.Value;
//                             // id to be used as since when polling for new trade data
//                         }
//                         else
//                         {
//                             var message = prop.Value as JArray;
//                             foreach (JToken token2 in message.Children())
//                             {
//                                 var trade = new Trade();
//                                 trade.rate = (double)token2[0];
//                                 trade.amount = (double)token2[1];
//                                 trade.date = new DateTime().UnixTimeStampToDateTime((double)token2[2]);
//                                 trade.type = token2[3].ToString();
//                                 trade.total = trade.rate * trade.amount;
//                                 output.Add(trade);
//                             }
//                         }
//                     }
//                 }
//             }

//             return output;
//         }
//     }
// }