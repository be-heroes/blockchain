//TODO: Reimplement with new native Json classes and ITypeConverter interfaces
// using System;
// using BeHeroes.Core.Common;
// using BeHeroes.Blockchain.Domain.Trading.ValueObjects;
// using Newtonsoft.Json.Linq;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps
// {
//     public class JsonTradeConverter : JsonCreationConverter<Trade>
//     {
//         protected override Trade Create(Type objectType, JObject jsonObject)
//         {
//             var trade = new Trade();
//             //jsonObject["id"].ToString()
//             //Currency.IsActive = true;
//             return trade;
//         }
//     }
// }
