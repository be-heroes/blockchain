using System;
using System.Collections.Generic;

namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class MarketVolume24Hour
    {
        public Exchange Exchange;
        public DateTime Timestamp;
        public List<MarketVolume> MarketVolumes;
    }
}
