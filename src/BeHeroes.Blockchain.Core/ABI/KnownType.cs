namespace BeHeroes.Blockchain.Core.ABI
{
    //TODO: Finish this abstraction
    public abstract class KnownType
    {
        public KnownTypes Indicator { get; init; }

        protected KnownType(KnownTypes indicator)
        {
            Indicator = indicator;
        }
    }
}