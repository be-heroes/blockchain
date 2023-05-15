// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Threading.Tasks;
// using BeHeroes.Core.Interfaces.Rpc;
// using BeHeroes.Domain.Trade.Interfaces;
// using BeHeroes.Domain.Trade.Model;
// using BeHeroes.Infrastructure.Exchanges.Bitfinex.Mapping;
// using BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc;
// using BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc.Request;
// using BeHeroes.Infrastructure.Exchanges.Bitfinex.Rpc.Response;
// using BeHeroes.Core.Common.ExtensionMethods;

// namespace BeHeroes.Infrastructure.Exchanges.Bitfinex
// {
//     public sealed class BitfinexExchange : IExchange, ITrade, IDeposit, IMarket
//     {
//         private readonly BitfinexJsonRpcClient _rpcClient;

//         public BitfinexExchange(string apiKey, string apiSecret)
//         {
//             _rpcClient = new BitfinexJsonRpcClient(apiKey, apiSecret);
//         }

//         public BitfinexExchange()
//         {
//             _rpcClient = new BitfinexJsonRpcClient();
//         }

//         public string Name => "Bitfinex";

//         public async Task<IJsonRpcResponse> Process(IJsonRpcRequest request)
//         {
//             return await _rpcClient.RawRequest((BitfinexRpcRequest) request);
//         }

//         public Task<Dictionary<Market, List<Trade>>> GetAccountTradeHistory(DateTime start, DateTime end)
//         {
//             throw new NotImplementedException();
//         }

//         public Task<List<Trade>> GetAccountTradeHistory(Market market, DateTime start, DateTime end)
//         {
//             throw new NotImplementedException();
//         }

//         public Task<Order> Sell(Market market, double rate, double amount, bool fillOrKill, bool immediateOrCancel)
//         {
//             throw new NotImplementedException();
//         }

//         public Task<Order> Buy(Market market, double rate, double amount, bool fillOrKill, bool immediateOrCancel)
//         {
//             throw new NotImplementedException();
//         }

//         public Task<List<Order>> GetAccountOpenOrders()
//         {
//             throw new NotImplementedException();
//         }

//         public async Task<List<Balance>> GetAllBalances()
//         {
//             var response = BitfinexMapper.Mapper.Map<IJsonRpcResponse, BitfinexRpcResponse>(await Process(new BitfinexRpcRequestBalances()));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = BitfinexMapper.Mapper.Map<BitfinexRpcResponse, List<Balance>>(response);
//             return output;
//         }

//         public Balance GetBalance(Currency currency)
//         {
//             throw new NotImplementedException();
//         }

//         public Balance[] GetBalance(Market market)
//         {
//             throw new NotImplementedException();
//         }

//         public Task<MarketVolume24Hour> Get24HVolume()
//         {
//             // Need to iterate over available markets
//             throw new NotImplementedException();
//         }

//         public async Task<Ticker> GetTicker(Market market)
//         {
//             var response = BitfinexMapper.Mapper.Map<IJsonRpcResponse, BitfinexRpcResponse>(await Process(new BitfinexRpcRequestTicker(market)));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = BitfinexMapper.Mapper.Map<BitfinexRpcResponse, Ticker>(response);
//             output.Market = market;

//             return output;
//         }

//         public async Task<List<Market>> GetMarkets()
//         {
//             var response = BitfinexMapper.Mapper.Map<IJsonRpcResponse, BitfinexRpcResponse>(await Process(new BitfinexRpcRequestSymbols()));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = BitfinexMapper.Mapper.Map<BitfinexRpcResponse, List<Market>>(response);
//             return output;
//         }

//         public Task<List<Currency>> GetCurrencies()
//         {
//             throw new NotImplementedException();
//         }

//         public Task<List<Trade>> GetTradeHistory(Market market, DateTime start, DateTime end)
//         {
//             throw new NotImplementedException();
//         }

//         public Task<List<Order>> GetOpenOrders(Market market)
//         {
//             throw new NotImplementedException();
//         }

//         public Task<List<Ticker>> GetTickers()
//         {
//             throw new NotImplementedException();
//         }
//     }
// }
