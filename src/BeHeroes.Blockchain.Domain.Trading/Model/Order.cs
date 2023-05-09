using System;
using System.Collections.Generic;

namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class Order
    {
        public Currency Currency { get; set; }
        public string OrderNumber { get; set; }
        public Ordertype Ordertype { get; set; }
        public List<Trade> Trades { get; set; }
        public double AmountUnfilled { get; set; }
    }
}
