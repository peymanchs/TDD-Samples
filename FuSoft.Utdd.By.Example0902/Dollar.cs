namespace FuSoft.Utdd.By.Example0902
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
            : base(amount, currency)
        {
        }

        public override Money Count(int multiplier)
        {
            return Money.Dollar(Amount * multiplier);
        }

    }
}
