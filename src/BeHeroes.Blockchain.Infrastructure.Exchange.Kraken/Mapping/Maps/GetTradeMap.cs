//TODO: Reimplement with new native Json classes and ITypeConverter interfaces
// using AutoMapper;
// using BeHeroes.Blockchain.Domain.Trading.Model;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Http.Response;
// using System.Text.Json.Serialization;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps
// {
//     public class GetTradeMap : ITypeConverter<KrakenRpcResponse, Trade>
//     {
//         public Trade Convert(ResolutionContext context)
//         {
//             var resp = KrakenMapper.Mapper.Map<KrakenRpcResponse, KrakenResponse>((KrakenRpcResponse)context.SourceValue);

//             var output = JsonConvert.DeserializeObject<Trade>(resp.Result.ToString(), new JsonTradeConverter());

//             return output;
//         }
//     }
// }