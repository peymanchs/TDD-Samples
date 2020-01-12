namespace FuSoft.Utdd.By.Example06
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
