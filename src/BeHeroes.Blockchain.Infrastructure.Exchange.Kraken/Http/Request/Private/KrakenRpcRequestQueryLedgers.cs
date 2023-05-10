namespace BeHeroes.Infrastructure.Exchanges.Kraken.Http.Request.Private
{
    public sealed class KrakenRequestQueryLedgers : KrakenRequest
    {
        public KrakenRequestQueryLedgers(List<int> ids)
        {
            string idString = "";
            foreach (var id in ids)
            {
                idString += id + ",";
            }
            idString = idString.Remove(idString.Length - 1);
            var postData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("id", idString),
                new KeyValuePair<string, string>("nonce", TimeStamp.Ticks.ToString())
            };

            RequestUri = new Uri("https://api.kraken.com/0/private/QueryLedgers");
            Method = HttpMethod.Post;
            Content = new FormUrlEncodedContent(postData);
        }
    }
}
