//TODO: Reimplement once I decided once to do with the legacy IJsonRpc* interfaces
// using AutoMapper;
// using BeHeroes.Blockchain.Domain.Trading.Model;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Maps;
// using BeHeroes.Infrastructure.Exchanges.Kraken.Rpc.Response;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken.Mapping.Profile
// {
//     public class DefaultProfile : AutoMapper.Profile
//     {
//         protected override void Configure()
//         {
//             CreateMap<IJsonRpcResponse, KrakenRpcResponse>().ConvertUsing((response) =>
//             {
//                 var result = (JsonRpcResponse)response;

//                 return Mapper.Map<KrakenRpcResponse>(result);
//             });

//             CreateMap<KrakenRpcResponse, KrakenResponse>().ConvertUsing(new ResponseMapper());
//             CreateMap<KrakenRpcResponse, List<Currency>>().ConvertUsing(new GetCurrencyMap());
//             CreateMap<KrakenRpcResponse, List<Market>>().ConvertUsing(new GetMarketsMap());
//             CreateMap<KrakenRpcResponse, MarketVolume24Hour>().ConvertUsing(new Get24HVolumeMap());
//             CreateMap<KrakenRpcResponse, List<Balance>>().ConvertUsing(new GetAllBalancesMap());
//             CreateMap<KrakenRpcResponse, List<Trade>>().ConvertUsing(new GetTradeHistoryMap());
//             CreateMap<KrakenRpcResponse, List<Order>>().ConvertUsing(new GetOrderMap());
//             CreateMap<KrakenRpcResponse, Trade>().ConvertUsing(new GetTradeMap());
//         }
//     }
// }
