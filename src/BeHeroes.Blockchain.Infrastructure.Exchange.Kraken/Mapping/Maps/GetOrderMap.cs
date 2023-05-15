//TODO: Reimplement with new native Json classes and ITypeConverter interfaces
// using System.Collections.Generic;
// using System.Linq;
// using AutoMapper;
// using BeHeroes.Blockchain.Domain.Trading.ValueObjects;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Http.Response;
// using Newtonsoft.Json.Linq;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps
// {
//     public class GetOrderMap : ITypeConverter<KrakenRpcResponse, List<Order>>
//     {
//         public List<Order> Convert(ResolutionContext context)
//         {
//             var resp = KrakenMapper.Mapper.Map<KrakenRpcResponse, KrakenResponse>((KrakenRpcResponse)context.SourceValue);
//             var output = new List<Order>();

//                 var jObj2 = resp.Result as JObject;
//                 foreach (var prop in jObj2.Children().OfType<JProperty>().Select(token => token))
//                 {
//                     var currency = prop.Name;
//                     var x = prop.Values().First() as JProperty;
//                     if ("bid".Equals(x.Name) || "asks".Equals(x.Name))
//                     {
//                         var orderlist = x.Value as JArray;
//                         foreach (var order in orderlist)
//                         {
//                             Order o = new Order();
//                         var trade = new Trade();
//                         //o.Ordertype = x.Name;
//                         trade.rate = (double)order[0];
//                         trade.amount = (double)order[1];
//                         trade.total = trade.amount * trade.rate;
//                         o.Trades = new List<Trade>();
//                         o.Trades.Add(trade);
//                             o.Currency = new Currency(currency);
//                             output.Add(o);
//                         }
//                     }
//                 }
//             return output;
//         }
//     }
// }