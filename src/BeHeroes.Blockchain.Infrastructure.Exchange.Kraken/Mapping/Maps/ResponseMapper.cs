//TODO: Reimplement with new native Json classes and ITypeConverter interfaces
// using AutoMapper;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Http.Response;
// using System.Text.Json.Serialization;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps
// {
//     public class ResponseMapper : ITypeConverter<KrakenRpcResponse, KrakenResponse>
//     {
//         public KrakenResponse Convert(ResolutionContext context)
//         {
//             dynamic dynObj = JsonConvert.DeserializeObject(((KrakenRpcResponse)context.SourceValue).Content.Result.Object.ToString());
//             var output = JsonConvert.DeserializeObject<KrakenResponse>(dynObj.ToString());
//             return output;
//         }
//     }
// }