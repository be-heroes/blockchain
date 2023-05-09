//TODO: Clean up implementation and figure out new exchange abstractions before bringing over the other code
// using BeHeroes.Blockchain.Domain.Trading.Exchanges;

// namespace BeHeroes.Infrastructure.Exchanges.Kraken
// {
//     public sealed class KrakenExchange : IExchange
//     {
//         private readonly KrakenJsonRpcClient _rpcClient;

//         public KrakenExchange(string apiKey, string apiSecret)
//         {
//             _rpcClient = new KrakenJsonRpcClient(apiKey, apiSecret);
//         }

//         public KrakenExchange()
//         {
//             _rpcClient = new KrakenJsonRpcClient();
//         }


//         public string Name => "Kraken";

//         public async Task<IJsonRpcResponse> Process(IJsonRpcRequest request)
//         {
//             return await _rpcClient.RawRequest((KrakenRpcRequest) request);
//         }

//         public async Task<MarketVolume24Hour> Get24HVolume()
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestMarkets()));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, MarketVolume24Hour>(response);
//             return output;
//         }

//         public Task<Ticker> GetTicker(Market market)
//         {
//             throw new NotImplementedException();
//         }

//         public async Task<List<Market>> GetMarkets()
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestAssetPairs()));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, List<Market>>(response);
//             return output;
//         }

//         public async Task<List<Currency>> GetCurrencies()
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestAssets()));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, List<Currency>>(response);
//             return output;
//         }

//         public async Task<List<Order>> GetOpenOrders(Market market)
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestOrderBook(market, 50)));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, List<Order>>(response);
//             return output;
//         }

//         public Task<List<Ticker>> GetTickers()
//         {
//             throw new NotImplementedException();
//         }

//         public async Task<List<Balance>> GetAllBalances()
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestBalance()));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, List<Balance>>(response);
//             return output;
//         }

//         public Balance GetBalance(Currency currency)
//         {
//             var balance = GetAllBalances().Result.Find(item => item.Currency == currency);
//             return balance;
//         }

//         public Balance[] GetBalance(Market market)
//         {
//             var balance = GetAllBalances().Result;
//             var balances = new Balance[2];
//             balances[0] = balance.Find(item => item.Currency == market.BaseCurrency);
//             balances[1] = balance.Find(item => item.Currency == market.QuoteCurrency);
//             return balances;
//         }

//         public async Task<List<Trade>> GetTradeHistory(Market market, DateTime start, DateTime end)
//         {
//             // Kraken does not support retrieveing trades i a range.
//             // All trades should be retrieved, and the returned to the caller
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestRecentTrades(market)));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, List<Trade>>(response);
//             return output;
//         }

//         public Task<Dictionary<Market, List<Trade>>> GetAccountTradeHistory(DateTime start, DateTime end)
//         {
//             throw new NotImplementedException();
//         }

//         public async Task<List<Trade>> GetAccountTradeHistory(Market market, DateTime start, DateTime end)
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestAccountTradesHistory(market.QuoteCurrency)));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, List<Trade>>(response);
//             return output;
//         }

//         public async Task<Order> Sell(Market market, double rate, double amount, bool fillOrKill, bool immediateOrCancel)
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestAddOrder(market, "sell" , rate, amount )));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, Order>(response);
//             return output;
//         }

//         public async Task<Order> Buy(Market market, double rate, double amount, bool fillOrKill, bool immediateOrCancel)
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestAddOrder(market, "buy", rate, amount)));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, Order>(response);
//             return output;
//         }

//         public async Task<List<Order>> GetAccountOpenOrders()
//         {
//             var response = KrakenMapper.Mapper.Map<IJsonRpcResponse, KrakenRpcResponse>(await Process(new KrakenRpcRequestOpenOrders()));
//             var validationResult = response.Validate(new ValidationContext(this)).ToList();
//             validationResult.ThrowExceptionIfAnyValidationErrors();
//             var output = KrakenMapper.Mapper.Map<KrakenRpcResponse, List<Order>>(response);
//             return output;
//         }

//     }
// }
