namespace FuSoft.Utdd.By.Example07
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Count(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }


    }
}
