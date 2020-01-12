namespace FuSoft.Utdd.By.Example0901
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
        }


        public override Money Count(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override string Currency()
        {
            return "CHF";
        }


    }
}
