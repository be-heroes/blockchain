using System.Text.Json.Serialization;

namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class Market
    {
        [JsonPropertyName("name")]
        public string Name { get { return BaseCurrency.Name + "_" + QuoteCurrency.Name; }}

        [JsonPropertyName("baseCurrency")]
        public Currency BaseCurrency { get; set; }

        [JsonPropertyName("quoteCurrency")]
        public Currency QuoteCurrency { get; set; }

        [JsonPropertyName("IsActive")]
        public bool IsActive { get; set; }

        [JsonPropertyName("logoUrl")]
        public string LogoUrl { get; set; }


        public Market(string baseCurrency, string quoteCurrency)
        {
            BaseCurrency = new Currency(baseCurrency);
            QuoteCurrency = new Currency(quoteCurrency);
        }

        public Market(string name)
        {
            // Derive base and quote from name
            // This will be moved to the different exchanges so this is more clean
            if (name.IndexOf("_") > -1)
            {
                BaseCurrency = new Currency(name.Substring(0, name.IndexOf("_")));
                QuoteCurrency = new Currency(name.Substring(name.IndexOf("_") + 1, name.Length - name.IndexOf("_") - 1));
            }
            else
            {
                if (name.IndexOf("-") > -1)
                {
                    BaseCurrency = new Currency(name.Substring(0, name.IndexOf("-")));
                    QuoteCurrency = new Currency(name.Substring(name.IndexOf("-") + 1, name.Length - name.IndexOf("-") - 1));
                }
                else
                {
                    BaseCurrency = new Currency(name.Substring(0, 3));
                    QuoteCurrency = new Currency(name.Substring(3, name.Length - 3));
                }
            }
            IsActive = true;
        }
    }
}
