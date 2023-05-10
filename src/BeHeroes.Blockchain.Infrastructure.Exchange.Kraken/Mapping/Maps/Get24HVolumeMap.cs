// using System;
//TODO: Reimplement with new native Json classes and ITypeConverter interfaces
// using System.Collections.Generic;
// using AutoMapper;
// using BeHeroes.Blockchain.Domain.Trading.Model;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Http.Response;
// using System.Text.Json;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps
// {
//     public class Get24HVolumeMap : ITypeConverter<KrakenRpcResponse, MarketVolume24Hour>
//     {
//         public MarketVolume24Hour Convert(ResolutionContext context)
//         {
//             dynamic dynObj = JsonSerializer.Deserialize(((KrakenRpcResponse)context..SourceValue).Content.Result.Object.ToString());

//             var output = new MarketVolume24Hour
//             {
//                 Timestamp = DateTime.Now,
//                 Exchange = new Exchange {Name = "Kraken"},
//                 MarketVolumes = new List<MarketVolume>()
//             };

//             //JContainer is the base class
//             if (dynObj != null)
//             {
//                 var jObj = (JObject)dynObj;
                
//                 // ReSharper disable once LoopCanBePartlyConvertedToQuery
//                 foreach (var token in jObj.Children())
//                 {
//                     if (!(token is JProperty)) continue;

//                     var prop = token as JProperty;

//                     if (!"result".Equals(prop.Name)) continue;

//                     // ReSharper disable once LoopCanBePartlyConvertedToQuery
//                     foreach (var token2 in prop.Value.Children())
//                     {
//                         // TODO Some markets are mentioned more than once
//                         var prop2 = token2 as JProperty;

//                         if (prop2 != null && prop2.Name.IndexOf(".", StringComparison.Ordinal) >= 0) continue;

//                         if (prop2 == null) continue;

//                         var marketVolume = new MarketVolume
//                         {
//                             Market = new Market(prop2.Name.Substring(1, 3), prop2.Name.Substring(4, 3))
//                         };

//                         output.MarketVolumes.Add(marketVolume);
//                     }
//                 }
//             }

//             //var obj = value.Deserialize<MarketVolume[]>();
//             foreach (var marketVolume in output.MarketVolumes)
//             {
//                 // Now update the Volume for each Market
//             }

//             return output;
//         }
//     }
// }