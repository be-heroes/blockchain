namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class LoanOffer
    {
        public Currency currency;
        public double amount;
        public double duration;
        public string autoRenew;
        public double lendingRate;
    }
}
