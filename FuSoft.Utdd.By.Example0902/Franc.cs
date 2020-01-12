namespace FuSoft.Utdd.By.Example0902
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
            : base(amount, currency)
        {
        }


        public override Money Count(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }

    }
}
