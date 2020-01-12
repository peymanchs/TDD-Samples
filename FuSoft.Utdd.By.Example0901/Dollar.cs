namespace FuSoft.Utdd.By.Example0901
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public override Money Count(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override string Currency()
        {
            return "USD";
        }



    }
}
