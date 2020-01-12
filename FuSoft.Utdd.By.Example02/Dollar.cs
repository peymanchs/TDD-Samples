namespace FuSoft.Utdd.By.Example02
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
    }
}
