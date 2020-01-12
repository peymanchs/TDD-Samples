namespace FuSoft.Utdd.By.Example03
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public int Amount;

        public Dollar Count(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return Amount.Equals(((Dollar)obj).Amount);
        }


    }
}
