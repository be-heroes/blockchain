//TODO: Reimplement with new native Json classes and ITypeConverter interfaces
// using System.Collections.Generic;
// using AutoMapper;
// using BeHeroes.Blockchain.Domain.Trading.Model;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Http.Response;
// using System.Text.Json.Serialization;
// using Newtonsoft.Json.Linq;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps
// {
//     public class GetAllBalancesMap : ITypeConverter<KrakenRpcResponse, List<Balance>>
//     {
//         public List<Balance> Convert(ResolutionContext context)
//         {
//             var resp = KrakenMapper.Mapper.Map<KrakenRpcResponse, KrakenResponse>((KrakenRpcResponse)context.SourceValue);

//             List<Balance> output = new List<Balance>();

//             var message = resp.Result as JObject;
//             foreach (JToken token2 in message.Children())
//             {
//                 var prop2 = token2 as JProperty;
//                 var currency = new Currency(prop2.Name);
//                 var balance = new Balance();
//                 balance.Currency = currency;
//                 balance.available = (double) prop2.Value;
//                 output.Add(balance);
//             }

//             return output;
//         }
//     }
// }