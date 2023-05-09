namespace BeHeroes.Blockchain.Domain.Trading.Model
{
    public class Transfer
    {
        public Currency currency;
        public Account toAccount;
        public Account fromAccount;
        public double amount;
    }
}
